namespace 串口通信
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
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
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.TxtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnReceive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 27);
            this.button2.TabIndex = 23;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // combStopBits
            // 
            this.combStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combStopBits.FormattingEnabled = true;
            this.combStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.combStopBits.Location = new System.Drawing.Point(411, 126);
            this.combStopBits.Name = "combStopBits";
            this.combStopBits.Size = new System.Drawing.Size(121, 20);
            this.combStopBits.TabIndex = 4;
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
            this.SerialParity.Location = new System.Drawing.Point(411, 97);
            this.SerialParity.Name = "SerialParity";
            this.SerialParity.Size = new System.Drawing.Size(121, 20);
            this.SerialParity.TabIndex = 20;
            // 
            // combDataBit
            // 
            this.combDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combDataBit.FormattingEnabled = true;
            this.combDataBit.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.combDataBit.Location = new System.Drawing.Point(411, 68);
            this.combDataBit.Name = "combDataBit";
            this.combDataBit.Size = new System.Drawing.Size(121, 20);
            this.combDataBit.TabIndex = 19;
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
            this.combBaudRate.Location = new System.Drawing.Point(411, 39);
            this.combBaudRate.Name = "combBaudRate";
            this.combBaudRate.Size = new System.Drawing.Size(121, 20);
            this.combBaudRate.TabIndex = 18;
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
            this.combSerialPort.Location = new System.Drawing.Point(411, 10);
            this.combSerialPort.Name = "combSerialPort";
            this.combSerialPort.Size = new System.Drawing.Size(121, 20);
            this.combSerialPort.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "校验位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "串口号";
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(12, 12);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(341, 137);
            this.txtReceive.TabIndex = 24;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(309, 222);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 27);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // TxtSend
            // 
            this.TxtSend.Location = new System.Drawing.Point(12, 188);
            this.TxtSend.Name = "TxtSend";
            this.TxtSend.Size = new System.Drawing.Size(337, 21);
            this.TxtSend.TabIndex = 26;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 215);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(104, 27);
            this.btnSend.TabIndex = 27;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(428, 152);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(104, 27);
            this.btnOpenPort.TabIndex = 28;
            this.btnOpenPort.Text = "打开串口";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(12, 155);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(104, 27);
            this.btnReceive.TabIndex = 29;
            this.btnReceive.Text = "接收";
            this.btnReceive.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 256);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnOpenPort);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.TxtSend);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.button2);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox TxtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnOpenPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnReceive;
    }
}

