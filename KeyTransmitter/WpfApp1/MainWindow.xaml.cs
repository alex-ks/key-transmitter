using KeyTransmitter.Client;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public static class Print2LPT
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        static extern SafeFileHandle CreateFile(string lpFileName, FileAccess dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, FileMode dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        [System.Runtime.InteropServices.DllImport("InpOutx64.dll", EntryPoint = "Out32")]
        public static extern void Out32(int PortAddress, int Data);
        


        public static bool Print()
        {
            string nl = Convert.ToChar(13).ToString() + Convert.ToChar(10).ToString();
            bool IsConnected = false;

            string sampleText = "Hello World!" + nl +
            "Enjoy Printing...";
           /* try
            {
                Byte[] buffer = new byte[sampleText.Length];
                buffer = System.Text.Encoding.ASCII.GetBytes(sampleText);

                SafeFileHandle fh = CreateFile("LPT1:", FileAccess.Write, 0, IntPtr.Zero, FileMode.OpenOrCreate, 0, IntPtr.Zero);
                if (!fh.IsInvalid)
                {
                    IsConnected = true;
                    FileStream lpt1 = new FileStream(fh, FileAccess.ReadWrite);
                    lpt1.Write(buffer, 0, buffer.Length);
                    lpt1.Close();
                }

            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            */
            return IsConnected;
        }
    }

    public partial class MainWindow : Window
    {
       


        private Transmitter transmitter;
 Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
           // int b1 = rnd.Next(1, 30);
            int b2 = rnd.Next(2);
             int decData = 0;
             int decAdd = 888; // 378h Selected Default
            //Print2LPT.Print();
    Print2LPT.Out32(956, 1);

            //transmitter = new Transmitter("localhost", 12200);
            //          transmitter.Send4Int(b1,b2,800,400);//ConsoleKey.A
            //        transmitter.Dispose();
        }
    }
}
