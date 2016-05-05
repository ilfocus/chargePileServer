namespace ChargingPileServer
{
    partial class SetComPara
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
            this.combStopBits = new System.Windows.Forms.ComboBox();
            this.SerialParity = new System.Windows.Forms.ComboBox();
            this.combDataBit = new System.Windows.Forms.ComboBox();
            this.combBaudRate = new System.Windows.Forms.ComboBox();
            this.combSerialPort = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSCP_OK = new System.Windows.Forms.Button();
            this.BtnSCP_Cancel = new System.Windows.Forms.Button();
            this.BtnSCP_Apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combStopBits
            // 
            this.combStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combStopBits.FormattingEnabled = true;
            this.combStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.combStopBits.Location = new System.Drawing.Point(82, 138);
            this.combStopBits.Name = "combStopBits";
            this.combStopBits.Size = new System.Drawing.Size(121, 20);
            this.combStopBits.TabIndex = 21;
            // 
            // SerialParity
            // 
            this.SerialParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SerialParity.FormattingEnabled = true;
            this.SerialParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.SerialParity.Location = new System.Drawing.Point(82, 109);
            this.SerialParity.Name = "SerialParity";
            this.SerialParity.Size = new System.Drawing.Size(121, 20);
            this.SerialParity.TabIndex = 30;
            // 
            // combDataBit
            // 
            this.combDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combDataBit.FormattingEnabled = true;
            this.combDataBit.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.combDataBit.Location = new System.Drawing.Point(82, 80);
            this.combDataBit.Name = "combDataBit";
            this.combDataBit.Size = new System.Drawing.Size(121, 20);
            this.combDataBit.TabIndex = 29;
            // 
            // combBaudRate
            // 
            this.combBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combBaudRate.FormattingEnabled = true;
            this.combBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200"});
            this.combBaudRate.Location = new System.Drawing.Point(82, 51);
            this.combBaudRate.Name = "combBaudRate";
            this.combBaudRate.Size = new System.Drawing.Size(121, 20);
            this.combBaudRate.TabIndex = 28;
            // 
            // combSerialPort
            // 
            this.combSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combSerialPort.FormattingEnabled = true;
            this.combSerialPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.combSerialPort.Location = new System.Drawing.Point(82, 22);
            this.combSerialPort.Name = "combSerialPort";
            this.combSerialPort.Size = new System.Drawing.Size(121, 20);
            this.combSerialPort.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "校验位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "串口号";
            // 
            // BtnSCP_OK
            // 
            this.BtnSCP_OK.Location = new System.Drawing.Point(30, 180);
            this.BtnSCP_OK.Name = "BtnSCP_OK";
            this.BtnSCP_OK.Size = new System.Drawing.Size(63, 27);
            this.BtnSCP_OK.TabIndex = 31;
            this.BtnSCP_OK.Text = "OK";
            this.BtnSCP_OK.UseVisualStyleBackColor = true;
            this.BtnSCP_OK.Click += new System.EventHandler(this.BtnSCP_OK_Click);
            // 
            // BtnSCP_Cancel
            // 
            this.BtnSCP_Cancel.Location = new System.Drawing.Point(106, 180);
            this.BtnSCP_Cancel.Name = "BtnSCP_Cancel";
            this.BtnSCP_Cancel.Size = new System.Drawing.Size(63, 27);
            this.BtnSCP_Cancel.TabIndex = 32;
            this.BtnSCP_Cancel.Text = "Cancel";
            this.BtnSCP_Cancel.UseVisualStyleBackColor = true;
            this.BtnSCP_Cancel.Click += new System.EventHandler(this.BtnSCP_Cancel_Click);
            // 
            // BtnSCP_Apply
            // 
            this.BtnSCP_Apply.Location = new System.Drawing.Point(178, 180);
            this.BtnSCP_Apply.Name = "BtnSCP_Apply";
            this.BtnSCP_Apply.Size = new System.Drawing.Size(63, 27);
            this.BtnSCP_Apply.TabIndex = 33;
            this.BtnSCP_Apply.Text = "Apply";
            this.BtnSCP_Apply.UseVisualStyleBackColor = true;
            this.BtnSCP_Apply.Click += new System.EventHandler(this.BtnSCP_Apply_Click);
            // 
            // SetComPara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 207);
            this.Controls.Add(this.BtnSCP_Apply);
            this.Controls.Add(this.BtnSCP_Cancel);
            this.Controls.Add(this.BtnSCP_OK);
            this.Controls.Add(this.combStopBits);
            this.Controls.Add(this.SerialParity);
            this.Controls.Add(this.combDataBit);
            this.Controls.Add(this.combBaudRate);
            this.Controls.Add(this.combSerialPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SetComPara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetComPara";
            this.Load += new System.EventHandler(this.SetComPara_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox combStopBits;
        internal System.Windows.Forms.ComboBox SerialParity;
        internal System.Windows.Forms.ComboBox combDataBit;
        internal System.Windows.Forms.ComboBox combBaudRate;
        internal System.Windows.Forms.ComboBox combSerialPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSCP_OK;
        private System.Windows.Forms.Button BtnSCP_Cancel;
        private System.Windows.Forms.Button BtnSCP_Apply;
    }
}