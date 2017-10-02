namespace WindowsFormsApp1
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
            this.ipBox = new System.Windows.Forms.TextBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.periodBox = new System.Windows.Forms.TextBox();
            this.savecheckBox = new System.Windows.Forms.CheckBox();
            this.testcheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wtake = new System.Windows.Forms.Button();
            this.M1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(12, 12);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(104, 20);
            this.ipBox.TabIndex = 0;
            this.ipBox.Text = "192.168.2.190";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(12, 38);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(104, 20);
            this.portBox.TabIndex = 1;
            this.portBox.Text = "12200";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Take window and start math";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Math";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "NoError";
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(13, 121);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(509, 126);
            this.img.TabIndex = 6;
            this.img.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "[ms]";
            // 
            // periodBox
            // 
            this.periodBox.Location = new System.Drawing.Point(12, 64);
            this.periodBox.Name = "periodBox";
            this.periodBox.Size = new System.Drawing.Size(103, 20);
            this.periodBox.TabIndex = 8;
            this.periodBox.Text = "500";
            // 
            // savecheckBox
            // 
            this.savecheckBox.AutoSize = true;
            this.savecheckBox.Location = new System.Drawing.Point(167, 14);
            this.savecheckBox.Name = "savecheckBox";
            this.savecheckBox.Size = new System.Drawing.Size(86, 17);
            this.savecheckBox.TabIndex = 9;
            this.savecheckBox.Text = "save Images";
            this.savecheckBox.UseVisualStyleBackColor = true;
            this.savecheckBox.CheckedChanged += new System.EventHandler(this.savecheckBox_CheckedChanged);
            // 
            // testcheckBox
            // 
            this.testcheckBox.AutoSize = true;
            this.testcheckBox.Checked = true;
            this.testcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.testcheckBox.Location = new System.Drawing.Point(167, 38);
            this.testcheckBox.Name = "testcheckBox";
            this.testcheckBox.Size = new System.Drawing.Size(79, 17);
            this.testcheckBox.TabIndex = 10;
            this.testcheckBox.Text = "test images";
            this.testcheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // wtake
            // 
            this.wtake.Location = new System.Drawing.Point(401, 89);
            this.wtake.Name = "wtake";
            this.wtake.Size = new System.Drawing.Size(121, 23);
            this.wtake.TabIndex = 12;
            this.wtake.Text = "Take and fastsave";
            this.wtake.UseVisualStyleBackColor = true;
            this.wtake.Click += new System.EventHandler(this.wtake_Click);
            // 
            // M1
            // 
            this.M1.AutoSize = true;
            this.M1.Location = new System.Drawing.Point(167, 66);
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(56, 17);
            this.M1.TabIndex = 13;
            this.M1.Text = "Math5";
            this.M1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "take 300 im/1s";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 273);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.M1);
            this.Controls.Add(this.wtake);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.testcheckBox);
            this.Controls.Add(this.savecheckBox);
            this.Controls.Add(this.periodBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.img);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.ipBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox periodBox;
        private System.Windows.Forms.CheckBox savecheckBox;
        private System.Windows.Forms.CheckBox testcheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button wtake;
        private System.Windows.Forms.CheckBox M1;
        private System.Windows.Forms.Button button2;
    }
}

