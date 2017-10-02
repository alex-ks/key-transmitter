using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyTransmitter.Client;
using System.Windows.Threading;
using System.Drawing.Imaging;
using System.Threading;
//using System.Windows.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("rotaf4.dll")]
         public static extern void rotaf4(byte[] img, double[] ext);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        static extern bool BitBlt(IntPtr hdcDest, int xDest, int yDest, int
    wDest, int hDest, IntPtr hdcSource, int xSrc, int ySrc, CopyPixelOperation rop);

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        private struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        private Transmitter transmitter;
        Random rnd = new Random();
        int port;
        DispatcherTimer dtClockTime = new DispatcherTimer();
        bool wtaken = false;
        IntPtr handle;
        Rect rect;
        Rectangle bounds;

        int pktindex=1;
        int ii = 100000;
        //private Bitmap captured2;
 PixelFormat format;
        private Bitmap captured;

        public Form1()
        {
            InitializeComponent();

           
            int colourDepth = Screen.PrimaryScreen.BitsPerPixel;
            switch (colourDepth)
            {
                case 8:
                case 16:
                    format = PixelFormat.Format16bppRgb565;
                    break;

                case 24:
                    format = PixelFormat.Format24bppRgb;
                    break;

                case 32:
                    format = PixelFormat.Format32bppArgb;
                    break;

                default:
                    format = PixelFormat.Format32bppArgb;
                    break;

            }


           

            //dtClockTime.Interval = new TimeSpan(0,0, 0,0, 1000); //indays Hour, Minutes, Second, ms.
            //dtClockTime.Tick += dtClockTime_Tick;

            //dtClockTime.Start();
            


        }

        private void dtClockTime_Tick(object sender, EventArgs e)
        {
            int qq = 1;
            button1.Text = DateTime.Now.ToLongTimeString();
            DateTime localDate = DateTime.Now;
            pktindex++;
            double[] zzz = new double[1251+qq*50];
            double[] ext = new double[4];

            Bitmap captured2 = new Bitmap(1251+qq*50, 142, format);
            //

            Graphics gdi2 = Graphics.FromImage(captured2);


            if (testcheckBox.Checked)
            {

                captured2 = (Bitmap)Image.FromFile(@".\test\" + pktindex +
               @".png", true);

            }
            else {

                GetWindowRect(handle, ref rect);
                bounds = new Rectangle(rect.Left + 196-qq*40, rect.Top + 958, 1251+qq*50, 142);

                gdi2.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bounds.Size, CopyPixelOperation.SourceInvert);
            }
            
            //GetWindowRect(handle, ref rect);
            //bounds = new Rectangle(rect.Left+196, rect.Top+958, 1251, 142);
            //gdi2.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bounds.Size, CopyPixelOperation.SourceInvert);
            
           



            img.Image = captured2;
            
            var imag = captured2;//new Bitmap(10, 10);
            Byte[] data = new byte[537186];//[9676800];

            var memoryStream = new System.IO.MemoryStream();
            imag.Save(memoryStream, ImageFormat.Bmp);
            data = memoryStream.ToArray();

            int width = imag.Width,                height = imag.Height;

            //1251 x 142 = 177642 355284 532926
            //1261 x 142 = 179062 358124 537186
            //button1.Text = height.ToString();
            ////////// byte[] res = new byte[3* height* width];
            //byte[] res = new byte[537186];// 407268 9676800
            byte[] res = new byte[532926];
            try
            {
                for (int tm1 = 0; tm1 < height; ++tm1) //vysota 1680 108
            {
                for (int tm2 = 0; tm2 < width; ++tm2)//x shirina 1920 1257
                {
                    Color color = imag.GetPixel(tm2+qq*40, tm1);
                    res[tm1 + height * tm2] = color.R;
                    //  res[tm1 + height * tm2 + 179062] = color.G;//135756 3225600
                    // res[tm1 + height * tm2 + 358124] = color.B;//271512 6451200
                    res[tm1 + height * tm2 + 177642] = color.G;
                    res[tm1 + height * tm2 + 355284] = color.B;
                    // res[0, y, x] = color.R;
                    // res[1, y, x] = color.G;
                    // res[2, y, x] = color.B;
                }
            }
            }
            catch
            {
                label2.Text = "Coordinates error";
            }
            if (M1.Checked == true)
            {
                try
                {
                    rotaf4(res, ext);

                }
                catch
                {
                    label2.Text = "Math5 not working";
                }

            }
            else
            {
                try
                {
                    rotaf4(res, ext);

                }
                catch
                {
                    label2.Text = "Math4 not working";
                }
            }
            if (ii < 9999) { captured2.Save(".\\saved\\" + ii + ".png", ImageFormat.Png); ii++; }//ToInt32(value); 


            int b0,b1,b2,b3;
            b0 = Convert.ToInt32(ext[0]);
            b1 = Convert.ToInt32(ext[1]);
            b2 = Convert.ToInt32(ext[2]);
            b3 = Convert.ToInt32(ext[3]);

            //tmpint.ToString().PadLeft(3, '0')
            label1.Text = "R"+b0.ToString()+"G"+ b1.ToString()+"B"+ b2.ToString()+ "W" + b3.ToString();




            //TextureBrush texture = new TextureBrush(image1);
            //texture.WrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            //Graphics formGraphics = this.CreateGraphics();
            //formGraphics.FillEllipse(texture,
            //    new RectangleF(90.0F, 110.0F, 100, 100));
            //formGraphics.Dispose();




            //int b1 = rnd.Next(1, 30);
            //int b2 = rnd.Next(2);
            if (int.TryParse(portBox.Text, out int temp))
                port = temp;
            else port = 12200;
            try
            {
                transmitter = new Transmitter(ipBox.Text, port);
                //transmitter = new Transmitter("localhost", 12200);

                transmitter.Send4Int(b0, b1, b2, b3);//ConsoleKey.A
                //transmitter.Send4Int(50, 51, 52, 53);
                transmitter.Dispose();
            }
            catch
            {
                label2.Text = "Network not working ...";
            }
            label3.Text =">"+ (DateTime.Now-localDate).ToString("fff")+"[ms]";

        }

      //  private void button2_Click(object sender, EventArgs e)
      //  {
    //int b1 = rnd.Next(1, 30);
    //int b2 = rnd.Next(2);
    //        if (int.TryParse(portBox.Text, out int temp))
    //            port = temp;
    //        try { 
    //        transmitter = new Transmitter(ipBox.Text, port);
    //transmitter.Send4Int(b1, b2, 800, 400);//ConsoleKey.A
    //transmitter.Dispose();
    //        }
    //        catch
    //        {
    //            label2.Text = "Network not working";
    //        }
      //  }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            handle = GetForegroundWindow();

            var rect = new Rect();
            GetWindowRect(handle, ref rect);
            var bounds = new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);

            captured = new Bitmap(bounds.Width, bounds.Height, format);
            Graphics gdi = Graphics.FromImage(captured);
            gdi.Clear(Color.Black);
            gdi.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bounds.Size, CopyPixelOperation.SourceInvert);
            img.BackgroundImageLayout = ImageLayout.Zoom;
            img.BackgroundImage = captured;
            handle = GetForegroundWindow();
            wtaken = true;
            //testcheckBox.Checked = false;



            int period;
            dtClockTime.Start();
            button1.Visible = false;
            if (int.TryParse(periodBox.Text, out int temp))
                period = temp;
            else period = 12200;
            dtClockTime.Interval = new TimeSpan(0, 0, 0, 0, period); //indays Hour, Minutes, Second, ms.
            dtClockTime.Tick += dtClockTime_Tick;


        }

        private void savecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (savecheckBox.Checked == true) {

                ii = 1;
                 }
            else { ii = 100000; }
        }

        private void wtake_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
           handle = GetForegroundWindow();

            var rect = new Rect();
            GetWindowRect(handle, ref rect);
            var bounds = new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);

            captured = new Bitmap(bounds.Width, bounds.Height, format);
            Graphics gdi = Graphics.FromImage(captured);
            gdi.Clear(Color.Black);
            gdi.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bounds.Size, CopyPixelOperation.SourceInvert);
            img.BackgroundImageLayout = ImageLayout.Zoom;
            img.BackgroundImage = captured;
            handle = GetForegroundWindow();
            wtaken = true;
            testcheckBox.Checked = false;

            //if (fs.Checked == true)
            //{
                for (int iii = 1; iii < 9999; iii++)
                {
                    Bitmap captured2 = new Bitmap(1301, 142, format);
                    //

                    Graphics gdi2 = Graphics.FromImage(captured2);

                    GetWindowRect(handle, ref rect);
                    bounds = new Rectangle(rect.Left + 196-40, rect.Top + 958, 1251+50, 142);

                    gdi2.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bounds.Size, CopyPixelOperation.SourceInvert);
                    captured2.Save(".\\saved\\" + iii + ".png", ImageFormat.Png);

                }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Thread.Sleep(1000);
            handle = GetForegroundWindow();

            var rect = new Rect();
            GetWindowRect(handle, ref rect);
            var bounds = new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);

            captured = new Bitmap(bounds.Width, bounds.Height, format);
            Graphics gdi = Graphics.FromImage(captured);
            gdi.Clear(Color.Black);
            gdi.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bounds.Size, CopyPixelOperation.SourceInvert);
            img.BackgroundImageLayout = ImageLayout.Zoom;
            img.BackgroundImage = captured;
            handle = GetForegroundWindow();
            wtaken = true;
            testcheckBox.Checked = false;

            //if (fs.Checked == true)
            //{

            for (int iii = 1; iii < 300; iii++)
            {
                button1.Text = iii.ToString();
                Thread.Sleep(1000);
                Bitmap captured2 = new Bitmap(bounds.Width, bounds.Height, format);
                //

                Graphics gdi2 = Graphics.FromImage(captured2);

                GetWindowRect(handle, ref rect);
                bounds = new Rectangle(rect.Left, rect.Top, rect.Right - rect.Left, rect.Bottom - rect.Top);

                gdi2.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bounds.Size, CopyPixelOperation.SourceInvert);
                captured2.Save(".\\saved\\" + iii + "0.jpg", ImageFormat.Jpeg);

            }
        }
    }
}


    