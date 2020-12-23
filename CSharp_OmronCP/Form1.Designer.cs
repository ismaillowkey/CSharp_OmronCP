
namespace CSharp_OmronCP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.GBReadDM = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NUPD = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtResultD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GBReadBit = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtResultBit = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtWBit = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.GBWriteBit = new System.Windows.Forms.GroupBox();
            this.TxtWriteBit = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.CmbValueBool = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.GBReadDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPD)).BeginInit();
            this.GBReadBit.SuspendLayout();
            this.GBWriteBit.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDisconnect);
            this.groupBox1.Controls.Add(this.BtnConnect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnRefresh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBaudRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbPort);
            this.groupBox1.Location = new System.Drawing.Point(44, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Communication";
            // 
            // cmbPort
            // 
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(79, 24);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 21);
            this.cmbPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port COM";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(79, 51);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(158, 21);
            this.cmbBaudRate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baudrate";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(206, 24);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(31, 23);
            this.BtnRefresh.TabIndex = 4;
            this.BtnRefresh.Text = "R";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Format : 7E2";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(243, 24);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(110, 23);
            this.BtnConnect.TabIndex = 6;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Enabled = false;
            this.BtnDisconnect.Location = new System.Drawing.Point(243, 51);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(110, 23);
            this.BtnDisconnect.TabIndex = 7;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // GBReadDM
            // 
            this.GBReadDM.Controls.Add(this.button3);
            this.GBReadDM.Controls.Add(this.button2);
            this.GBReadDM.Controls.Add(this.label5);
            this.GBReadDM.Controls.Add(this.TxtResultD);
            this.GBReadDM.Controls.Add(this.button1);
            this.GBReadDM.Controls.Add(this.NUPD);
            this.GBReadDM.Controls.Add(this.label4);
            this.GBReadDM.Enabled = false;
            this.GBReadDM.Location = new System.Drawing.Point(44, 147);
            this.GBReadDM.Name = "GBReadDM";
            this.GBReadDM.Size = new System.Drawing.Size(395, 180);
            this.GBReadDM.TabIndex = 1;
            this.GBReadDM.TabStop = false;
            this.GBReadDM.Text = "Read DM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Read D";
            // 
            // NUPD
            // 
            this.NUPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUPD.Location = new System.Drawing.Point(87, 31);
            this.NUPD.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NUPD.Name = "NUPD";
            this.NUPD.Size = new System.Drawing.Size(68, 27);
            this.NUPD.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(161, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Read Ushort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtResultD
            // 
            this.TxtResultD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResultD.Location = new System.Drawing.Point(87, 133);
            this.TxtResultD.Name = "TxtResultD";
            this.TxtResultD.Size = new System.Drawing.Size(290, 27);
            this.TxtResultD.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Result";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(272, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Read Short";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(161, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Read Float";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GBReadBit
            // 
            this.GBReadBit.Controls.Add(this.textBox1);
            this.GBReadBit.Controls.Add(this.button4);
            this.GBReadBit.Controls.Add(this.label8);
            this.GBReadBit.Controls.Add(this.TxtWBit);
            this.GBReadBit.Controls.Add(this.label6);
            this.GBReadBit.Controls.Add(this.TxtResultBit);
            this.GBReadBit.Controls.Add(this.button6);
            this.GBReadBit.Controls.Add(this.label7);
            this.GBReadBit.Enabled = false;
            this.GBReadBit.Location = new System.Drawing.Point(445, 147);
            this.GBReadBit.Name = "GBReadBit";
            this.GBReadBit.Size = new System.Drawing.Size(395, 180);
            this.GBReadBit.TabIndex = 2;
            this.GBReadBit.TabStop = false;
            this.GBReadBit.Text = "Read Bit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Result";
            // 
            // TxtResultBit
            // 
            this.TxtResultBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResultBit.Location = new System.Drawing.Point(87, 147);
            this.TxtResultBit.Name = "TxtResultBit";
            this.TxtResultBit.Size = new System.Drawing.Size(290, 27);
            this.TxtResultBit.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(165, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 29);
            this.button6.TabIndex = 2;
            this.button6.Text = "Read Bit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Read Bit";
            // 
            // TxtWBit
            // 
            this.TxtWBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWBit.Location = new System.Drawing.Point(83, 35);
            this.TxtWBit.Name = "TxtWBit";
            this.TxtWBit.Size = new System.Drawing.Size(76, 27);
            this.TxtWBit.TabIndex = 7;
            this.TxtWBit.Text = "W0.0";
            this.TxtWBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(83, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 27);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "C100.00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(165, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 29);
            this.button4.TabIndex = 9;
            this.button4.Text = "Read Bit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Read I/O";
            // 
            // GBWriteBit
            // 
            this.GBWriteBit.Controls.Add(this.CmbValueBool);
            this.GBWriteBit.Controls.Add(this.TxtWriteBit);
            this.GBWriteBit.Controls.Add(this.button7);
            this.GBWriteBit.Controls.Add(this.label11);
            this.GBWriteBit.Enabled = false;
            this.GBWriteBit.Location = new System.Drawing.Point(445, 348);
            this.GBWriteBit.Name = "GBWriteBit";
            this.GBWriteBit.Size = new System.Drawing.Size(395, 84);
            this.GBWriteBit.TabIndex = 3;
            this.GBWriteBit.TabStop = false;
            this.GBWriteBit.Text = "Write Bit";
            // 
            // TxtWriteBit
            // 
            this.TxtWriteBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWriteBit.Location = new System.Drawing.Point(64, 35);
            this.TxtWriteBit.Name = "TxtWriteBit";
            this.TxtWriteBit.Size = new System.Drawing.Size(95, 27);
            this.TxtWriteBit.TabIndex = 7;
            this.TxtWriteBit.Text = "W0.0";
            this.TxtWriteBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(291, 34);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 29);
            this.button7.TabIndex = 2;
            this.button7.Text = "Write Bit";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Write";
            // 
            // CmbValueBool
            // 
            this.CmbValueBool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbValueBool.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbValueBool.FormattingEnabled = true;
            this.CmbValueBool.Items.AddRange(new object[] {
            "True",
            "False"});
            this.CmbValueBool.Location = new System.Drawing.Point(165, 35);
            this.CmbValueBool.Name = "CmbValueBool";
            this.CmbValueBool.Size = new System.Drawing.Size(121, 28);
            this.CmbValueBool.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 468);
            this.Controls.Add(this.GBWriteBit);
            this.Controls.Add(this.GBReadBit);
            this.Controls.Add(this.GBReadDM);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBReadDM.ResumeLayout(false);
            this.GBReadDM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPD)).EndInit();
            this.GBReadBit.ResumeLayout(false);
            this.GBReadBit.PerformLayout();
            this.GBWriteBit.ResumeLayout(false);
            this.GBWriteBit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GBReadDM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown NUPD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtResultD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox GBReadBit;
        private System.Windows.Forms.TextBox TxtWBit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtResultBit;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox GBWriteBit;
        private System.Windows.Forms.ComboBox CmbValueBool;
        private System.Windows.Forms.TextBox TxtWriteBit;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label11;
    }
}

