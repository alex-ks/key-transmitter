using Caliburn.Micro;
using KeyTransmitter.Server.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace KeyTransmitter.Server.ViewModels
{
    public class ActionCommand : ICommand
    {
        private readonly System.Action _action;

        public ActionCommand(System.Action action)
        {
            _action = action;
        }

        public void Execute(object parameter)
        {
            _action();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }

    public class MainViewModel : PropertyChangedBase
    {
       
        private string status = "No connection";
        private int port = 12200;
        private int lptport = 888;//956;
        private bool notStarted = true;
        private string newkey = "";

        /// <summary>
        /// KEY
        /// </summary>
        private ICommand someCommand;
        public ICommand SomeCommand
        {
            get
            {
                return someCommand
                    ?? (someCommand = new ActionCommand(() =>
                    {
                        MessageBox.Show("SomeCommand");
                    }));
            }
        }
        /// <summary>
        /// END KEY
        /// </summary>


        public void KeyPressed(Key key)
        {
            switch (key)
            {
                case Key.A:
                    // some work for A
                    MessageBox.Show("A");
                    break;

                case Key.B:
                    // some work for B
                    MessageBox.Show("B");
                    break;

                case Key.C:
                    // some work for C
                    MessageBox.Show("C");
                    break;

                case Key.D:
                    // some work for D
                    MessageBox.Show("D");
                    break;

                default:
                    //ignore
                    break;
            }
        }

        private IWindowManager windowManager;

        KeyViewModel keyModel = new KeyViewModel();

        public MainViewModel(IWindowManager windowManager)
        {
            this.windowManager = windowManager;
        }
        private string lastKey = "None";
        public string LastKey
        {   get { return lastKey; }
            set{
                if (value == lastKey) return;
                lastKey = value;
                NotifyOfPropertyChange(() => LastKey);
            }
        }

        public string Status
        {   get { return status; }
            set {
                if (value == status) return;
                status = value;
                NotifyOfPropertyChange(() => Status);
            }
        }

        public string Port
        {   get { return port.ToString(); }
            set {
                if (int.TryParse(value, out int temp)) port = temp;
            }
        }

        
        public string Lptport
        {   get { return lptport.ToString(); }
            set
            {  if (int.TryParse(value, out int temp)) lptport = temp;//956
            }
        }

        public bool NotStarted
        {   get { return notStarted; }
            set {
                if (notStarted == value) return;
                notStarted = value;
                NotifyOfPropertyChange(() => NotStarted);
            }
        }



        /* 
          <Window.InputBindings>
         <KeyBinding Command="{Binding SomeCommand}" Key="r">
         </KeyBinding>
     </Window.InputBindings>



         public string SomeCommand
         {
             get { return newkey; }
             set
             {

                 newkey = value;
                 string newFileName = "C:\\newkey.csv";
                 string s = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss.fff");
                 string clientDetails = s + '-' + newkey+ "\n";
                 File.AppendAllText(newFileName, clientDetails);
                // NotifyOfPropertyChange(() => NotStarted);
             }
         }*/

        private string b = "0";
        public string B
        {   get { return b; }
            set {
                if (value == b) return;
                b = value;
                NotifyOfPropertyChange(() => B);
                string newFileName = "C:\\b.csv";
                string s = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss.fff");
                string clientDetails = s + ',' + value+','+W + "\n";
                File.AppendAllText(newFileName, clientDetails);
            }
        }

        private string b1 = "0";
        public string B1
        {   get { return b1; }
            set { 
                if (value == b1)                     return;
                b1 = value;
                NotifyOfPropertyChange(() => B1);
            }
        }
        private string b2 = "0";
        public string B2
        {
            get { return b2; }
            set {
                if (value == b2) return;
                b2 = value;
                NotifyOfPropertyChange(() => B2);
            }
        }


        public static class PortControl // Import dll to project
        {
            [System.Runtime.InteropServices.DllImport("InpOutx64.dll", EntryPoint = "Out32")]
            public static extern void Out32(int PortAddress, int Data);
        }

        

        private string ww = "0";
        public string W
        {   get { return ww; }
            set {
                if (value == ww) return;
                 //if (String.Compare(w, value, true) == 0 && String.Compare(w, "1", true) == 0) { nmax = 0; nmin = 0; }
               /// if (Ar && IsCh) { ArmNow = Convert.ToBoolean(value); //NotifyOfPropertyChange(() => ArmNow); 
               /// }
                    ww = value;
                NotifyOfPropertyChange(() => W);
                // int decData = 0;
                // int decAdd = 888; // 378h Selected Default   956 3bc
                // PortControl.Output(decAdd, decData);
                //PortControl.Out32(lptport, Int32.Parse(ww));

                if (String.Compare(ww, "1", true) == 0)
                { 
                    PortControl.Out32(lptport, 1);
                }
                else {
                    PortControl.Out32(lptport, 2);
                }


            }
        }


        private bool armNow;
        public bool ArmNow
        {   get { return this.armNow; }
            set
            {   if (Ar == false)
                {   keyModel.ArmNow = value;
                    this.armNow = value;
                    keyModel.ArmPlace = "1";
                }
                else
                { keyModel.ArmPlace = "2";
                  this.armNow = value;
                }
                NotifyOfPropertyChange(() => ArmNow);

                keyModel.ArmNow = value;
                //if (int.TryParse(keyModel.Rad, out int rad))
                    
               // keyModel.Rad = (rad=rad*2).ToString();

            }
        }

        private bool m1;
        public bool M1
        {   get { return this.m1; }
            set {
                this.m1 = value;
                NotifyOfPropertyChange(() => M1);
            }
        }

        private bool isCh;
        public bool IsCh
        {   get {   return this.isCh;   }
            set {
                this.isCh = value;
                NotifyOfPropertyChange(() => IsCh);
            }
        }

        private bool ar;
        public bool Ar
        {   get { return this.ar; }
            set {
                if (value == false) { ArmNow = false; NotifyOfPropertyChange(() => ArmNow); }
                this.ar = value;
               /// if (value == false) { ArmNow = false; NotifyOfPropertyChange(() => ArmNow); }
                NotifyOfPropertyChange(() => Ar);
            }
        }
        private int coef = 10;
        public string Coef
        {   get { return coef.ToString(); }
            set {
                if (int.TryParse(value, out int temp))
                    coef = temp;
                NotifyOfPropertyChange(() => Coef);
            }
        }
        private int zero = 0;
        public string Zero
        {
            get { return zero.ToString(); }
            set {
                if (int.TryParse(value, out int temp))
                    zero = temp;
                NotifyOfPropertyChange(() => Zero);
            }
        }
        private int abc = 1;
        public string Abc
        {   get { return abc.ToString(); }
            set {
                if (int.TryParse(value, out int temp))
                    abc = temp;
                NotifyOfPropertyChange(() => Abc);
            }
        }
        async Task ProcessKeys(TcpClient client)//, Action<string> notifier)
        {
            try
            {
                var stream = client.GetStream();
                var buffer = new byte[4*sizeof(int)];
                var buffer0 = new byte[sizeof(int)];
                var buffer1 = new byte[sizeof(int)];
                var buffer2 = new byte[sizeof(int)];
                var buffer3 = new byte[sizeof(int)];
                var buffer01 = new byte[3*sizeof(int)];
                var buffer12 = new byte[2*sizeof(int)];
                //var buffer23 = new byte[sizeof(int)];
                string r;
                //var presser = new KeyPresser();

                while (true)
                {
                    var read = await stream.ReadAsync(buffer, 0, 4*sizeof(int));
                    //LastKey = "Byte came"+buffer.Length+"_"+read.ToString();
                    
                    if (read < 4*sizeof(int))
                        break;
                    //LastKey = "4 Byte came";
                    buffer0 = buffer.Take(4).ToArray();
                    buffer01 = buffer.Skip(4).ToArray();

                    buffer1 = buffer01.Take(4).ToArray();
                    buffer12 = buffer01.Skip(4).ToArray();

                    buffer2 = buffer12.Take(4).ToArray();
                    buffer3 = buffer12.Skip(4).ToArray();
                     

                    //var key = (ConsoleKey)BitConverter.ToInt32(buffer, 0);
                    B = BitConverter.ToInt32(buffer0, 0).ToString();
                    B1 = BitConverter.ToInt32(buffer1, 0).ToString();
                    B2 = BitConverter.ToInt32(buffer2, 0).ToString();
                    int w;
                    w = BitConverter.ToInt32(buffer3, 0);
                    W = w.ToString();


                    string newFileName = ".\\rec.csv";
                    string s = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss.fff");
                    string clientDetails = s + ',' + B + ',' + B1 + ',' + B2 + ',' + W + "\n";
                    File.AppendAllText(newFileName, clientDetails);

                    // notifier(key.ToString());
                    // presser.PressKey(key);
                    //LastKey = key.ToString();
                    //coef = Convert.ToInt(Coef);
                    int.TryParse(Coef, out int coef);
                    int.TryParse(Zero, out int zero);
                    int.TryParse(Abc, out int abcd);
                    //int abcd = abc;// BitConverter.ToInt32(Abc, 0);
                    int brad;
                    if (abcd ==2) brad = BitConverter.ToInt32(buffer1, 0);
                    else if (abcd == 2)
                        brad = BitConverter.ToInt32(buffer1, 0);
                    else                     brad = BitConverter.ToInt32(buffer1, 0);
                    if (M1) brad = brad - (BitConverter.ToInt32(buffer0, 0)+ BitConverter.ToInt32(buffer2, 0)) / 2;
                    
                    if (IsCh)
                    {

                        r =  (brad * w * coef+zero).ToString();
                        
                       // if(Ar)
                       // {
                            ArmNow = Convert.ToBoolean(w);
                       // }
                        // = (BitConverter.ToInt32(buffer0, 0) * BitConverter.ToInt32(buffer1, 0) * coef).ToString();

                    }
                    else {
                     r = (brad * coef+zero).ToString(); ;

                    }
                    
                    keyModel.Rad = r;
                    LastKey = r;


                }
            }
            finally
            {
                client.Dispose();
                Status = "No connection";
                NotStarted = true;
               // LastKey = "None";
                StartListening();
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

                Task.Factory.StartNew(() => ProcessKeys(client));
                // creating delegate to update this.LastKey and keyModel.Key properties
                //Action<string> notifier = s => LastKey = s;
                //notifier += s => keyModel.Key = s;
                //Task.Factory.StartNew(() => ProcessKeys(client, notifier));
                //
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
        public void OpenWindow()
        {
           // if (keyModel == null)
                windowManager.ShowWindow(keyModel);

               //var client = await listener.AcceptTcpClientAsync();

            //Task.FromResult<object>(null);
        }
       
    }
}