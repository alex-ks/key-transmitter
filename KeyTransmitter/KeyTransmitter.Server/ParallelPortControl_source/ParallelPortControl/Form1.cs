using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ParallelPortControl
{
    public partial class Form1 : Form
    {
        int decData = 0;
        int decAdd = 888; // 378h Selected Default

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Control dll file once at the start
            try
            {
                PortControl.Output(decAdd, decData); // Initialize
            }
            catch(System.DllNotFoundException)
            {
                MessageBox.Show("inpout32.dll Not Found !!!","Dll Error");
                System.Environment.Exit(-1);
            }

            cboxRegAdd.Items.Add("0x3BCh"); // 956 Decimal 
            cboxRegAdd.Items.Add("0x378h"); // 888 Decimal
            cboxRegAdd.Items.Add("0x278h"); // 632 Decimal

            cboxRegAdd.SelectedIndex = 1;

            convertValue();

            cboxBinInp.Checked = true;

        }

        private void getAdd()
        {
            if (cboxRegAdd.SelectedIndex == 0)
            {
                decAdd = 956;
            }

            if (cboxRegAdd.SelectedIndex == 1)
            {
                decAdd = 888;
            }

            if (cboxRegAdd.SelectedIndex == 2)
            {
                decAdd = 632;
            }
        }

        private void convertValue()
        {
            tboxValDec.Text = Convert.ToString(decData, 10).PadLeft(3, '0');
            tboxValHex.Text = Convert.ToString(decData, 16).PadLeft(2, '0').ToUpper();
            tboxValBin.Text = Convert.ToString(decData, 2).PadLeft(8, '0');
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            getAdd(); // Get the selected register address from combobox

            decData = 255;

            PortControl.Output(decAdd, decData);

            tboxD0.BackColor = Color.Green;
            tboxD1.BackColor = Color.Green;
            tboxD2.BackColor = Color.Green;
            tboxD3.BackColor = Color.Green;
            tboxD4.BackColor = Color.Green;
            tboxD5.BackColor = Color.Green;
            tboxD6.BackColor = Color.Green;
            tboxD7.BackColor = Color.Green;

            convertValue();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            getAdd(); // Get the selected register address from combobox

            decData = 0;

            PortControl.Output(decAdd, decData);

            tboxD0.BackColor = Color.Red;
            tboxD1.BackColor = Color.Red;
            tboxD2.BackColor = Color.Red;
            tboxD3.BackColor = Color.Red;
            tboxD4.BackColor = Color.Red;
            tboxD5.BackColor = Color.Red;
            tboxD6.BackColor = Color.Red;
            tboxD7.BackColor = Color.Red;

            convertValue();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            getAdd();

            try
            {
                decData = int.Parse(tboxSendDec.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter a valid value 128-255 !!!","Format Error");
            }

            if (decData >= 0 && decData <= 255)
            {
                PortControl.Output(decAdd, decData);
                convertValue();
            }
        }

        private void btnD0_Click(object sender, EventArgs e)
        {
            getAdd();

            if (tboxD0.BackColor == Color.Red)
            {
                // Port closed

                decData += 1;
                tboxD0.BackColor = Color.Green;
            }
            else
            {
                // Port opened
                decData -= 1;
                tboxD0.BackColor = Color.Red;
            }

            PortControl.Output(decAdd, decData);

            convertValue();
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            getAdd();

            if (tboxD1.BackColor == Color.Red)
            {
                // Portt closed

                decData += 2;
                tboxD1.BackColor = Color.Green;
            }
            else
            {
                // Port opened
                decData -= 2;
                tboxD1.BackColor = Color.Red;
            }

            PortControl.Output(decAdd, decData);

            convertValue();
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            getAdd();

            if (tboxD2.BackColor == Color.Red)
            {
                // Portt closed

                decData += 4;
                tboxD2.BackColor = Color.Green;
            }
            else
            {
                // Port opened
                decData -= 4;
                tboxD2.BackColor = Color.Red;
            }

            PortControl.Output(decAdd, decData);

            convertValue();
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            getAdd();

            if (tboxD3.BackColor == Color.Red)
            {
                // Portt closed

                decData += 8;
                tboxD3.BackColor = Color.Green;
            }
            else
            {
                // Port opened
                decData -= 8;
                tboxD3.BackColor = Color.Red;
            }

            PortControl.Output(decAdd, decData);

            convertValue();
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            getAdd();

            if (tboxD4.BackColor == Color.Red)
            {
                // Portt closed

                decData += 16;
                tboxD4.BackColor = Color.Green;
            }
            else
            {
                // Port opened
                decData -= 16;
                tboxD4.BackColor = Color.Red;
            }

            PortControl.Output(decAdd, decData);

            convertValue();
        }

        private void btnD5_Click(object sender, EventArgs e)
        {
            getAdd();

            if (tboxD5.BackColor == Color.Red)
            {
                // Portt closed

                decData += 32;
                tboxD5.BackColor = Color.Green;
            }
            else
            {
                // Port opened
                decData -= 32;
                tboxD5.BackColor = Color.Red;
            }

            PortControl.Output(decAdd, decData);

            convertValue();
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            getAdd();

            if (tboxD6.BackColor == Color.Red)
            {
                // Portt closed

                decData += 64;
                tboxD6.BackColor = Color.Green;
            }
            else
            {
                // Port opened
                decData -= 64;
                tboxD6.BackColor = Color.Red;
            }

            PortControl.Output(decAdd, decData);

            convertValue();
        }

        private void btnD7_Click(object sender, EventArgs e)
        {
            getAdd();

            if (tboxD7.BackColor == Color.Red)
            {
                // Portt closed

                decData += 128;
                tboxD7.BackColor = Color.Green;
            }
            else
            {
                // Port opened
                decData -= 128;
                tboxD7.BackColor = Color.Red;
            }

            PortControl.Output(decAdd, decData);

            convertValue();
        }

        private void cboxBinInp_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxBinInp.Checked == true)
            {
                tboxSendDec.Text = "";
                cboxDecInp.Checked = false;
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                btnClose.PerformClick();
            }
        }

        private void cboxDecInp_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxDecInp.Checked == true)
            {
                btnClose.PerformClick();
                cboxBinInp.Checked = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://blog.armanasci.com");
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            PortControl.Output(decAdd, 0);
        }
    }
}