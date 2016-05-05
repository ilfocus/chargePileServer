namespace ChargingPileServer.WinForm
{
    partial class OnOffSet
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnTurnOn = new System.Windows.Forms.Button();
            this.txtSlaveNum = new System.Windows.Forms.TextBox();
            this.lblSlaveNum = new System.Windows.Forms.Label();
            this.txtMasterNum = new System.Windows.Forms.TextBox();
            this.lblMasterNum = new System.Windows.Forms.Label();
            this.btnTurnOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 29);
            this.button1.TabIndex = 521;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnTurnOn
            // 
            this.btnTurnOn.Location = new System.Drawing.Point(37, 112);
            this.btnTurnOn.Name = "btnTurnOn";
            this.btnTurnOn.Size = new System.Drawing.Size(82, 29);
            this.btnTurnOn.TabIndex = 518;
            this.btnTurnOn.Text = "开机";
            this.btnTurnOn.UseVisualStyleBackColor = true;
            this.btnTurnOn.Click += new System.EventHandler(this.btnTurnOn_Click);
            // 
            // txtSlaveNum
            // 
            this.txtSlaveNum.Location = new System.Drawing.Point(184, 56);
            this.txtSlaveNum.Name = "txtSlaveNum";
            this.txtSlaveNum.Size = new System.Drawing.Size(59, 21);
            this.txtSlaveNum.TabIndex = 513;
            // 
            // lblSlaveNum
            // 
            this.lblSlaveNum.AutoSize = true;
            this.lblSlaveNum.Location = new System.Drawing.Point(144, 65);
            this.lblSlaveNum.Name = "lblSlaveNum";
            this.lblSlaveNum.Size = new System.Drawing.Size(41, 12);
            this.lblSlaveNum.TabIndex = 512;
            this.lblSlaveNum.Text = "从机号";
            // 
            // txtMasterNum
            // 
            this.txtMasterNum.Location = new System.Drawing.Point(60, 57);
            this.txtMasterNum.Name = "txtMasterNum";
            this.txtMasterNum.Size = new System.Drawing.Size(59, 21);
            this.txtMasterNum.TabIndex = 511;
            // 
            // lblMasterNum
            // 
            this.lblMasterNum.AutoSize = true;
            this.lblMasterNum.Location = new System.Drawing.Point(12, 66);
            this.lblMasterNum.Name = "lblMasterNum";
            this.lblMasterNum.Size = new System.Drawing.Size(41, 12);
            this.lblMasterNum.TabIndex = 510;
            this.lblMasterNum.Text = "主机号";
            // 
            // btnTurnOff
            // 
            this.btnTurnOff.Location = new System.Drawing.Point(161, 112);
            this.btnTurnOff.Name = "btnTurnOff";
            this.btnTurnOff.Size = new System.Drawing.Size(82, 29);
            this.btnTurnOff.TabIndex = 522;
            this.btnTurnOff.Text = "关机";
            this.btnTurnOff.UseVisualStyleBackColor = true;
            this.btnTurnOff.Click += new System.EventHandler(this.btnTurnOff_Click);
            // 
            // OnOffSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 262);
            this.Controls.Add(this.btnTurnOff);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTurnOn);
            this.Controls.Add(this.txtSlaveNum);
            this.Controls.Add(this.lblSlaveNum);
            this.Controls.Add(this.txtMasterNum);
            this.Controls.Add(this.lblMasterNum);
            this.Name = "OnOffSet";
            this.Text = "OnOffSet";
            this.Load += new System.EventHandler(this.OnOffSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTurnOn;
        private System.Windows.Forms.TextBox txtSlaveNum;
        private System.Windows.Forms.Label lblSlaveNum;
        private System.Windows.Forms.TextBox txtMasterNum;
        private System.Windows.Forms.Label lblMasterNum;
        private System.Windows.Forms.Button btnTurnOff;
    }
}