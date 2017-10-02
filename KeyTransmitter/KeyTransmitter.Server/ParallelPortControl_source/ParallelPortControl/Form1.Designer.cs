namespace ParallelPortControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxRegAdd = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnD0 = new System.Windows.Forms.Button();
            this.btnD1 = new System.Windows.Forms.Button();
            this.btnD2 = new System.Windows.Forms.Button();
            this.btnD3 = new System.Windows.Forms.Button();
            this.btnD4 = new System.Windows.Forms.Button();
            this.btnD5 = new System.Windows.Forms.Button();
            this.btnD6 = new System.Windows.Forms.Button();
            this.btnD7 = new System.Windows.Forms.Button();
            this.tboxD0 = new System.Windows.Forms.TextBox();
            this.tboxD1 = new System.Windows.Forms.TextBox();
            this.tboxD2 = new System.Windows.Forms.TextBox();
            this.tboxD3 = new System.Windows.Forms.TextBox();
            this.tboxD4 = new System.Windows.Forms.TextBox();
            this.tboxD5 = new System.Windows.Forms.TextBox();
            this.tboxD6 = new System.Windows.Forms.TextBox();
            this.tboxD7 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxValDec = new System.Windows.Forms.TextBox();
            this.tboxValHex = new System.Windows.Forms.TextBox();
            this.tboxValBin = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tboxSendDec = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cboxBinInp = new System.Windows.Forms.CheckBox();
            this.cboxDecInp = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parallel Port Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address of Data Register : ";
            // 
            // cboxRegAdd
            // 
            this.cboxRegAdd.Enabled = false;
            this.cboxRegAdd.FormattingEnabled = true;
            this.cboxRegAdd.Location = new System.Drawing.Point(156, 42);
            this.cboxRegAdd.Name = "cboxRegAdd";
            this.cboxRegAdd.Size = new System.Drawing.Size(121, 21);
            this.cboxRegAdd.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 144);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.btnD0);
            this.groupBox1.Controls.Add(this.btnD1);
            this.groupBox1.Controls.Add(this.btnD2);
            this.groupBox1.Controls.Add(this.btnD3);
            this.groupBox1.Controls.Add(this.btnD4);
            this.groupBox1.Controls.Add(this.btnD5);
            this.groupBox1.Controls.Add(this.btnD6);
            this.groupBox1.Controls.Add(this.btnD7);
            this.groupBox1.Controls.Add(this.tboxD0);
            this.groupBox1.Controls.Add(this.tboxD1);
            this.groupBox1.Controls.Add(this.tboxD2);
            this.groupBox1.Controls.Add(this.tboxD3);
            this.groupBox1.Controls.Add(this.tboxD4);
            this.groupBox1.Controls.Add(this.tboxD5);
            this.groupBox1.Controls.Add(this.tboxD6);
            this.groupBox1.Controls.Add(this.tboxD7);
            this.groupBox1.Location = new System.Drawing.Point(16, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 132);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(137, 90);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Cloase All";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(7, 90);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(123, 23);
            this.btnOpen.TabIndex = 21;
            this.btnOpen.Text = "Open All";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnD0
            // 
            this.btnD0.Location = new System.Drawing.Point(463, 57);
            this.btnD0.Name = "btnD0";
            this.btnD0.Size = new System.Drawing.Size(58, 23);
            this.btnD0.TabIndex = 20;
            this.btnD0.Text = "D0";
            this.btnD0.UseVisualStyleBackColor = true;
            this.btnD0.Click += new System.EventHandler(this.btnD0_Click);
            // 
            // btnD1
            // 
            this.btnD1.Location = new System.Drawing.Point(398, 57);
            this.btnD1.Name = "btnD1";
            this.btnD1.Size = new System.Drawing.Size(58, 23);
            this.btnD1.TabIndex = 19;
            this.btnD1.Text = "D1";
            this.btnD1.UseVisualStyleBackColor = true;
            this.btnD1.Click += new System.EventHandler(this.btnD1_Click);
            // 
            // btnD2
            // 
            this.btnD2.Location = new System.Drawing.Point(333, 56);
            this.btnD2.Name = "btnD2";
            this.btnD2.Size = new System.Drawing.Size(58, 23);
            this.btnD2.TabIndex = 18;
            this.btnD2.Text = "D2";
            this.btnD2.UseVisualStyleBackColor = true;
            this.btnD2.Click += new System.EventHandler(this.btnD2_Click);
            // 
            // btnD3
            // 
            this.btnD3.Location = new System.Drawing.Point(268, 56);
            this.btnD3.Name = "btnD3";
            this.btnD3.Size = new System.Drawing.Size(58, 23);
            this.btnD3.TabIndex = 17;
            this.btnD3.Text = "D3";
            this.btnD3.UseVisualStyleBackColor = true;
            this.btnD3.Click += new System.EventHandler(this.btnD3_Click);
            // 
            // btnD4
            // 
            this.btnD4.Location = new System.Drawing.Point(203, 57);
            this.btnD4.Name = "btnD4";
            this.btnD4.Size = new System.Drawing.Size(58, 23);
            this.btnD4.TabIndex = 16;
            this.btnD4.Text = "D4";
            this.btnD4.UseVisualStyleBackColor = true;
            this.btnD4.Click += new System.EventHandler(this.btnD4_Click);
            // 
            // btnD5
            // 
            this.btnD5.Location = new System.Drawing.Point(137, 57);
            this.btnD5.Name = "btnD5";
            this.btnD5.Size = new System.Drawing.Size(58, 23);
            this.btnD5.TabIndex = 15;
            this.btnD5.Text = "D5";
            this.btnD5.UseVisualStyleBackColor = true;
            this.btnD5.Click += new System.EventHandler(this.btnD5_Click);
            // 
            // btnD6
            // 
            this.btnD6.Location = new System.Drawing.Point(73, 57);
            this.btnD6.Name = "btnD6";
            this.btnD6.Size = new System.Drawing.Size(58, 23);
            this.btnD6.TabIndex = 14;
            this.btnD6.Text = "D6";
            this.btnD6.UseVisualStyleBackColor = true;
            this.btnD6.Click += new System.EventHandler(this.btnD6_Click);
            // 
            // btnD7
            // 
            this.btnD7.Location = new System.Drawing.Point(7, 57);
            this.btnD7.Name = "btnD7";
            this.btnD7.Size = new System.Drawing.Size(58, 23);
            this.btnD7.TabIndex = 13;
            this.btnD7.Text = "D7";
            this.btnD7.UseVisualStyleBackColor = true;
            this.btnD7.Click += new System.EventHandler(this.btnD7_Click);
            // 
            // tboxD0
            // 
            this.tboxD0.BackColor = System.Drawing.Color.Red;
            this.tboxD0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxD0.Enabled = false;
            this.tboxD0.Location = new System.Drawing.Point(462, 30);
            this.tboxD0.Name = "tboxD0";
            this.tboxD0.Size = new System.Drawing.Size(59, 20);
            this.tboxD0.TabIndex = 12;
            // 
            // tboxD1
            // 
            this.tboxD1.BackColor = System.Drawing.Color.Red;
            this.tboxD1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxD1.Enabled = false;
            this.tboxD1.Location = new System.Drawing.Point(397, 30);
            this.tboxD1.Name = "tboxD1";
            this.tboxD1.Size = new System.Drawing.Size(59, 20);
            this.tboxD1.TabIndex = 11;
            // 
            // tboxD2
            // 
            this.tboxD2.BackColor = System.Drawing.Color.Red;
            this.tboxD2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxD2.Enabled = false;
            this.tboxD2.Location = new System.Drawing.Point(332, 30);
            this.tboxD2.Name = "tboxD2";
            this.tboxD2.Size = new System.Drawing.Size(59, 20);
            this.tboxD2.TabIndex = 10;
            // 
            // tboxD3
            // 
            this.tboxD3.BackColor = System.Drawing.Color.Red;
            this.tboxD3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxD3.Enabled = false;
            this.tboxD3.Location = new System.Drawing.Point(267, 30);
            this.tboxD3.Name = "tboxD3";
            this.tboxD3.Size = new System.Drawing.Size(59, 20);
            this.tboxD3.TabIndex = 9;
            // 
            // tboxD4
            // 
            this.tboxD4.BackColor = System.Drawing.Color.Red;
            this.tboxD4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxD4.Enabled = false;
            this.tboxD4.Location = new System.Drawing.Point(202, 30);
            this.tboxD4.Name = "tboxD4";
            this.tboxD4.Size = new System.Drawing.Size(59, 20);
            this.tboxD4.TabIndex = 8;
            // 
            // tboxD5
            // 
            this.tboxD5.BackColor = System.Drawing.Color.Red;
            this.tboxD5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxD5.Enabled = false;
            this.tboxD5.Location = new System.Drawing.Point(137, 30);
            this.tboxD5.Name = "tboxD5";
            this.tboxD5.Size = new System.Drawing.Size(59, 20);
            this.tboxD5.TabIndex = 7;
            // 
            // tboxD6
            // 
            this.tboxD6.BackColor = System.Drawing.Color.Red;
            this.tboxD6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxD6.Enabled = false;
            this.tboxD6.Location = new System.Drawing.Point(71, 30);
            this.tboxD6.Name = "tboxD6";
            this.tboxD6.Size = new System.Drawing.Size(59, 20);
            this.tboxD6.TabIndex = 6;
            // 
            // tboxD7
            // 
            this.tboxD7.BackColor = System.Drawing.Color.Red;
            this.tboxD7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxD7.Enabled = false;
            this.tboxD7.ForeColor = System.Drawing.Color.White;
            this.tboxD7.Location = new System.Drawing.Point(6, 30);
            this.tboxD7.Name = "tboxD7";
            this.tboxD7.Size = new System.Drawing.Size(59, 20);
            this.tboxD7.TabIndex = 5;
            this.tboxD7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Decimal :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hexadecimal :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Binary :";
            // 
            // tboxValDec
            // 
            this.tboxValDec.Enabled = false;
            this.tboxValDec.Location = new System.Drawing.Point(482, 85);
            this.tboxValDec.Name = "tboxValDec";
            this.tboxValDec.Size = new System.Drawing.Size(100, 20);
            this.tboxValDec.TabIndex = 9;
            // 
            // tboxValHex
            // 
            this.tboxValHex.Enabled = false;
            this.tboxValHex.Location = new System.Drawing.Point(482, 136);
            this.tboxValHex.Name = "tboxValHex";
            this.tboxValHex.Size = new System.Drawing.Size(100, 20);
            this.tboxValHex.TabIndex = 10;
            // 
            // tboxValBin
            // 
            this.tboxValBin.Enabled = false;
            this.tboxValBin.Location = new System.Drawing.Point(481, 188);
            this.tboxValBin.Name = "tboxValBin";
            this.tboxValBin.Size = new System.Drawing.Size(100, 20);
            this.tboxValBin.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tboxSendDec);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(16, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 83);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // tboxSendDec
            // 
            this.tboxSendDec.Location = new System.Drawing.Point(253, 44);
            this.tboxSendDec.Name = "tboxSendDec";
            this.tboxSendDec.Size = new System.Drawing.Size(100, 20);
            this.tboxSendDec.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(359, 42);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "D7   |   D6   |   D5   |   D4   |  D3  |  D2  |  D1  |  D0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "128   |   64    |   32   |   16   |    8   |    4   |    2   |    1   ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(19, 465);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(187, 16);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://blog.armanasci.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cboxBinInp
            // 
            this.cboxBinInp.AutoSize = true;
            this.cboxBinInp.Location = new System.Drawing.Point(19, 215);
            this.cboxBinInp.Name = "cboxBinInp";
            this.cboxBinInp.Size = new System.Drawing.Size(82, 17);
            this.cboxBinInp.TabIndex = 23;
            this.cboxBinInp.Text = "Binary Input";
            this.cboxBinInp.UseVisualStyleBackColor = true;
            this.cboxBinInp.CheckedChanged += new System.EventHandler(this.cboxBinInp_CheckedChanged);
            // 
            // cboxDecInp
            // 
            this.cboxDecInp.AutoSize = true;
            this.cboxDecInp.Location = new System.Drawing.Point(19, 367);
            this.cboxDecInp.Name = "cboxDecInp";
            this.cboxDecInp.Size = new System.Drawing.Size(91, 17);
            this.cboxDecInp.TabIndex = 4;
            this.cboxDecInp.Text = "Decimal Input";
            this.cboxDecInp.UseVisualStyleBackColor = true;
            this.cboxDecInp.CheckedChanged += new System.EventHandler(this.cboxDecInp_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 486);
            this.Controls.Add(this.cboxDecInp);
            this.Controls.Add(this.cboxBinInp);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tboxValBin);
            this.Controls.Add(this.tboxValHex);
            this.Controls.Add(this.tboxValDec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboxRegAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Parallel Port Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxRegAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboxD0;
        private System.Windows.Forms.TextBox tboxD1;
        private System.Windows.Forms.TextBox tboxD2;
        private System.Windows.Forms.TextBox tboxD3;
        private System.Windows.Forms.TextBox tboxD4;
        private System.Windows.Forms.TextBox tboxD5;
        private System.Windows.Forms.TextBox tboxD6;
        private System.Windows.Forms.TextBox tboxD7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnD0;
        private System.Windows.Forms.Button btnD1;
        private System.Windows.Forms.Button btnD2;
        private System.Windows.Forms.Button btnD3;
        private System.Windows.Forms.Button btnD4;
        private System.Windows.Forms.Button btnD5;
        private System.Windows.Forms.Button btnD6;
        private System.Windows.Forms.Button btnD7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxValDec;
        private System.Windows.Forms.TextBox tboxValHex;
        private System.Windows.Forms.TextBox tboxValBin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxSendDec;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox cboxBinInp;
        private System.Windows.Forms.CheckBox cboxDecInp;
    }
}

