using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace KeyTransmitter.Server.ViewModels
{
    public class MainViewModel : PropertyChangedBase
    {
        private string lastKey = "None";
        private string status = "No connection";
        private int port = 12200;
        private bool notStarted = true;

        private IWindowManager windowManager;

        public MainViewModel(IWindowManager windowManager)
        {
            this.windowManager = windowManager;
        }

        public string LastKey
        {
            get { return lastKey; }
            set
            {
                if (value == lastKey)
                    return;
                lastKey = value;
                NotifyOfPropertyChange(() => LastKey);
            }
        }

        public string Status
        {
            get { return status; }
            set
            {
                if (value == status)
                    return;
                status = value;
                NotifyOfPropertyChange(() => Status);
            }
        }      

        public string Port
        {
            get { return port.ToString(); }
            set
            {
                if (int.TryParse(value, out int temp))
                    port = temp;
            }
        }

        public bool NotStarted
        {
            get { return notStarted; }
            set
            {
                if (notStarted == value)
                    return;
                notStarted = value;
                NotifyOfPropertyChange(() => NotStarted);
            }
        }

        async Task ProcessKeys(TcpClient client, Action<string> notifier)
        {
            try
            {
                var stream = client.GetStream();
                var buffer = new byte[sizeof(int)];
                var presser = new KeyPresser();

                while (true)
                {
                    var read = await stream.ReadAsync(buffer, 0, sizeof(int));
                    if (read < sizeof(int))
                        break;
                    var key = (ConsoleKey)BitConverter.ToInt32(buffer, 0);
                    notifier(key.ToString());
                    presser.PressKey(key);
                }
            }
            finally
            {
                client.Dispose();
                Status = "No connection";
                NotStarted = true;
                LastKey = "None";
            }
        }


        public async void StartListening()
        {
            TcpListener listener = null;
            NotStarted = false;
            try
            {
                listener = new TcpListener(IPAddress.Any, port);
                listener.Start();
                var client = await listener.AcceptTcpClientAsync();
                Status = "Connection established";

                var keyModel = new KeyViewModel();
                // creating delegate to update this.LastKey and keyModel.Key properties
                Action<string> notifier = s => LastKey = s;
                notifier += s => keyModel.Key = s;
                Task.Factory.StartNew(() => ProcessKeys(client, notifier));
                windowManager.ShowWindow(keyModel);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                NotStarted = true;
            }
            finally
            {
                listener?.Stop();
            }
        }
    }
}
