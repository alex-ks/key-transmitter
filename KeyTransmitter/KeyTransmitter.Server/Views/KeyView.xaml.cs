using KeyTransmitter.Server.ViewModels;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace KeyTransmitter.Server.Views
{
    /// <summary>
    /// Interaction logic for KeyView.xaml
    /// </summary>
    public partial class KeyView : Window
    {
        
        public KeyView()
        {
            InitializeComponent();
        }
        

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            this.Hide();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
            this.WindowStyle = WindowStyle.None;
        }
    }
}
