namespace ChargingPileServer
{
    partial class ParameterSet
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.txtSlaveNum = new System.Windows.Forms.TextBox();
            this.lblSlaveNum = new System.Windows.Forms.Label();
            this.txtMasterNum = new System.Windows.Forms.TextBox();
            this.lblMasterNum = new System.Windows.Forms.Label();
            this.btnPS_Exit = new System.Windows.Forms.Button();
            this.btnTurnOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 508;
            this.label3.Text = "mA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 507;
            this.label1.Text = "min";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(12, 167);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(82, 29);
            this.btnSet.TabIndex = 506;
            this.btnSet.Text = "设置";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(185, 118);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(59, 21);
            this.txtTime.TabIndex = 505;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(151, 127);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(29, 12);
            this.lblTime.TabIndex = 504;
            this.lblTime.Text = "时间";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(61, 118);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(59, 21);
            this.txtCurrent.TabIndex = 503;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(25, 127);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(29, 12);
            this.lblCurrent.TabIndex = 502;
            this.lblCurrent.Text = "电流";
            // 
            // txtSlaveNum
            // 
            this.txtSlaveNum.Location = new System.Drawing.Point(185, 58);
            this.txtSlaveNum.Name = "txtSlaveNum";
            this.txtSlaveNum.Size = new System.Drawing.Size(59, 21);
            this.txtSlaveNum.TabIndex = 501;
            // 
            // lblSlaveNum
            // 
            this.lblSlaveNum.AutoSize = true;
            this.lblSlaveNum.Location = new System.Drawing.Point(145, 67);
            this.lblSlaveNum.Name = "lblSlaveNum";
            this.lblSlaveNum.Size = new System.Drawing.Size(41, 12);
            this.lblSlaveNum.TabIndex = 500;
            this.lblSlaveNum.Text = "从机号";
            // 
            // txtMasterNum
            // 
            this.txtMasterNum.Location = new System.Drawing.Point(61, 59);
            this.txtMasterNum.Name = "txtMasterNum";
            this.txtMasterNum.Size = new System.Drawing.Size(59, 21);
            this.txtMasterNum.TabIndex = 499;
            // 
            // lblMasterNum
            // 
            this.lblMasterNum.AutoSize = true;
            this.lblMasterNum.Location = new System.Drawing.Point(13, 68);
            this.lblMasterNum.Name = "lblMasterNum";
            this.lblMasterNum.Size = new System.Drawing.Size(41, 12);
            this.lblMasterNum.TabIndex = 498;
            this.lblMasterNum.Text = "主机号";
            // 
            // btnPS_Exit
            // 
            this.btnPS_Exit.Location = new System.Drawing.Point(191, 221);
            this.btnPS_Exit.Name = "btnPS_Exit";
            this.btnPS_Exit.Size = new System.Drawing.Size(82, 29);
            this.btnPS_Exit.TabIndex = 509;
            this.btnPS_Exit.Text = "退出";
            this.btnPS_Exit.UseVisualStyleBackColor = true;
            this.btnPS_Exit.Click += new System.EventHandler(this.btnPS_Exit_Click);
            // 
            // btnTurnOff
            // 
            this.btnTurnOff.Location = new System.Drawing.Point(162, 167);
            this.btnTurnOff.Name = "btnTurnOff";
            this.btnTurnOff.Size = new System.Drawing.Size(82, 29);
            this.btnTurnOff.TabIndex = 510;
            this.btnTurnOff.Text = "关机";
            this.btnTurnOff.UseVisualStyleBackColor = true;
            this.btnTurnOff.Click += new System.EventHandler(this.btnTurnOff_Click);
            // 
            // ParameterSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnTurnOff);
            this.Controls.Add(this.btnPS_Exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.txtSlaveNum);
            this.Controls.Add(this.lblSlaveNum);
            this.Controls.Add(this.txtMasterNum);
            this.Controls.Add(this.lblMasterNum);
            this.Name = "ParameterSet";
            this.Text = "ParameterSet";
            this.Load += new System.EventHandler(this.ParameterSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.TextBox txtSlaveNum;
        private System.Windows.Forms.Label lblSlaveNum;
        private System.Windows.Forms.TextBox txtMasterNum;
        private System.Windows.Forms.Label lblMasterNum;
        private System.Windows.Forms.Button btnPS_Exit;
        private System.Windows.Forms.Button btnTurnOff;

    }
}