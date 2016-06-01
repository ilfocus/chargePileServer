namespace ChargingPileServer
{
    partial class MonitoringInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitoringInterface));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("充电桩");
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Config = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.串口设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton_Look = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Alarm = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_UpDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_SHTV = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_User = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_FileMng = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Card = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Report = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi_ChargeRecordReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton_Curve = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_About = new System.Windows.Forms.ToolStripButton();
            this.TSBtnExist = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.TS_LableSystemTime = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labeltx = new System.Windows.Forms.Label();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.TimeSendData = new System.Windows.Forms.Timer(this.components);
            this.timeDealRevData = new System.Windows.Forms.Timer(this.components);
            this.updateFrameTimer = new System.Windows.Forms.Timer(this.components);
            this.skinEngine2 = new Sunisoft.IrisSkin.SkinEngine();
            this.TimSysTime = new System.Windows.Forms.Timer(this.components);
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChargingPileAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.heartStateLed = new System.Windows.Forms.Label();
            this.setTimeLed = new System.Windows.Forms.Label();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.setRateLed = new System.Windows.Forms.Label();
            this.btnSetPrice = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cpStartLed = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cpStateLed = new System.Windows.Forms.Label();
            this.btnCPState = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.curChargeInfoLed = new System.Windows.Forms.Label();
            this.btnCurCharge = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.heartTime = new System.Windows.Forms.Timer(this.components);
            this.btnHeartFrame = new System.Windows.Forms.Button();
            this.cpPauseLed = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.cpStopLed = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.cpRecoverLed = new System.Windows.Forms.Label();
            this.btnRecover = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.tsmi_CDZParaSet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AlarmLimitSet = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSetTime = new System.Windows.Forms.Panel();
            this.cbSystemTime = new System.Windows.Forms.CheckBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeSet = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtRateValleyPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRateFlatPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRatePeakPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRatePointPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnListen = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtLeftTime = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtChargeTime = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtChargeSoc = new System.Windows.Forms.TextBox();
            this.lblCurState = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblPlugState = new System.Windows.Forms.Label();
            this.btnAutoCheck = new System.Windows.Forms.Button();
            this.txtValleyElect = new System.Windows.Forms.TextBox();
            this.lblCurLed = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtFlatElect = new System.Windows.Forms.TextBox();
            this.lblPlugLed = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblElectState = new System.Windows.Forms.Label();
            this.txtPeakElect = new System.Windows.Forms.TextBox();
            this.lblElectLed = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtPointElect = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblStopState = new System.Windows.Forms.Label();
            this.txtTotalElect = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblStopLed = new System.Windows.Forms.Label();
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtValtage = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCheckChargeInfo = new System.Windows.Forms.Button();
            this.txtCurValleyCost = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtCurFlatCost = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtCurPeakCost = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtCurPointCost = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtCurValleyPrice = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtCurFlatPrice = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtCurPeakPrice = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.txtCurPointPrice = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtCurValleyElect = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txtCurFlatElect = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.txtCurPeakElect = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.txtCurPointElect = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.txtCurTotalCost = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.txtCurTotalElect = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.checkStateTime = new System.Windows.Forms.Timer(this.components);
            this.heartLedTime = new System.Windows.Forms.Timer(this.components);
            this.tvChargePile = new System.Windows.Forms.TreeView();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.panelSetTime.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(577, 7);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(104, 27);
            this.btnOpenPort.TabIndex = 28;
            this.btnOpenPort.Text = "打开串口";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.ReadBufferSize = 100;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Config,
            this.toolStripButton_Look,
            this.toolStripButton_Alarm,
            this.toolStripButton_UpDown,
            this.toolStripButton_SHTV,
            this.toolStripSeparator1,
            this.toolStripButton_User,
            this.toolStripButton_FileMng,
            this.toolStripButton_Card,
            this.toolStripSeparator2,
            this.toolStripButton_Report,
            this.toolStripButton_Curve,
            this.toolStripSeparator3,
            this.toolStripButton_About,
            this.TSBtnExist,
            this.toolStripButton7,
            this.TS_LableSystemTime});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(642, 72);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Config
            // 
            this.toolStripButton_Config.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.串口设置ToolStripMenuItem});
            this.toolStripButton_Config.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Config.Image")));
            this.toolStripButton_Config.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Config.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Config.Name = "toolStripButton_Config";
            this.toolStripButton_Config.Size = new System.Drawing.Size(69, 69);
            this.toolStripButton_Config.Text = "参数配置";
            this.toolStripButton_Config.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem1.Text = "充电桩配置";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem2.Text = "告警阈值配置";
            // 
            // 串口设置ToolStripMenuItem
            // 
            this.串口设置ToolStripMenuItem.Name = "串口设置ToolStripMenuItem";
            this.串口设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.串口设置ToolStripMenuItem.Text = "串口设置";
            this.串口设置ToolStripMenuItem.Click += new System.EventHandler(this.串口设置ToolStripMenuItem_Click);
            // 
            // toolStripButton_Look
            // 
            this.toolStripButton_Look.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Look.Image")));
            this.toolStripButton_Look.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Look.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Look.Name = "toolStripButton_Look";
            this.toolStripButton_Look.Size = new System.Drawing.Size(60, 69);
            this.toolStripButton_Look.Text = "查看事件";
            this.toolStripButton_Look.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton_Alarm
            // 
            this.toolStripButton_Alarm.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Alarm.Image")));
            this.toolStripButton_Alarm.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Alarm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Alarm.Name = "toolStripButton_Alarm";
            this.toolStripButton_Alarm.Size = new System.Drawing.Size(60, 69);
            this.toolStripButton_Alarm.Text = "音效告警";
            this.toolStripButton_Alarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton_UpDown
            // 
            this.toolStripButton_UpDown.Image = global::ChargingPileServer.Properties.Resources.hideup;
            this.toolStripButton_UpDown.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_UpDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_UpDown.Name = "toolStripButton_UpDown";
            this.toolStripButton_UpDown.Size = new System.Drawing.Size(60, 69);
            this.toolStripButton_UpDown.Text = "隐藏总览";
            this.toolStripButton_UpDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton_SHTV
            // 
            this.toolStripButton_SHTV.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_SHTV.Image")));
            this.toolStripButton_SHTV.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_SHTV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_SHTV.Name = "toolStripButton_SHTV";
            this.toolStripButton_SHTV.Size = new System.Drawing.Size(72, 69);
            this.toolStripButton_SHTV.Text = "隐藏树视图";
            this.toolStripButton_SHTV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_SHTV.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStripButton_User
            // 
            this.toolStripButton_User.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_User.Image")));
            this.toolStripButton_User.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_User.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_User.Name = "toolStripButton_User";
            this.toolStripButton_User.Size = new System.Drawing.Size(60, 69);
            this.toolStripButton_User.Text = "用户管理";
            this.toolStripButton_User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton_FileMng
            // 
            this.toolStripButton_FileMng.Image = global::ChargingPileServer.Properties.Resources.files481;
            this.toolStripButton_FileMng.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_FileMng.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_FileMng.Name = "toolStripButton_FileMng";
            this.toolStripButton_FileMng.Size = new System.Drawing.Size(60, 69);
            this.toolStripButton_FileMng.Text = "档案管理";
            this.toolStripButton_FileMng.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton_Card
            // 
            this.toolStripButton_Card.Image = global::ChargingPileServer.Properties.Resources.card;
            this.toolStripButton_Card.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Card.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Card.Name = "toolStripButton_Card";
            this.toolStripButton_Card.Size = new System.Drawing.Size(60, 69);
            this.toolStripButton_Card.Text = "开卡充值";
            this.toolStripButton_Card.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStripButton_Report
            // 
            this.toolStripButton_Report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_ChargeRecordReport});
            this.toolStripButton_Report.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Report.Image")));
            this.toolStripButton_Report.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Report.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Report.Name = "toolStripButton_Report";
            this.toolStripButton_Report.Size = new System.Drawing.Size(69, 69);
            this.toolStripButton_Report.Text = "报表浏览";
            this.toolStripButton_Report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmi_ChargeRecordReport
            // 
            this.tsmi_ChargeRecordReport.Name = "tsmi_ChargeRecordReport";
            this.tsmi_ChargeRecordReport.Size = new System.Drawing.Size(148, 22);
            this.tsmi_ChargeRecordReport.Text = "充电记录报表";
            // 
            // toolStripButton_Curve
            // 
            this.toolStripButton_Curve.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Curve.Image")));
            this.toolStripButton_Curve.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Curve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Curve.Name = "toolStripButton_Curve";
            this.toolStripButton_Curve.Size = new System.Drawing.Size(60, 69);
            this.toolStripButton_Curve.Text = "曲线查看";
            this.toolStripButton_Curve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStripButton_About
            // 
            this.toolStripButton_About.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_About.Image")));
            this.toolStripButton_About.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_About.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_About.Name = "toolStripButton_About";
            this.toolStripButton_About.Size = new System.Drawing.Size(60, 69);
            this.toolStripButton_About.Text = "关于系统";
            this.toolStripButton_About.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TSBtnExist
            // 
            this.TSBtnExist.Image = ((System.Drawing.Image)(resources.GetObject("TSBtnExist.Image")));
            this.TSBtnExist.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBtnExist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnExist.Name = "TSBtnExist";
            this.TSBtnExist.Size = new System.Drawing.Size(60, 69);
            this.TSBtnExist.Text = "退出系统";
            this.TSBtnExist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBtnExist.Click += new System.EventHandler(this.TSBtnExist_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 4);
            // 
            // TS_LableSystemTime
            // 
            this.TS_LableSystemTime.AutoSize = false;
            this.TS_LableSystemTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TS_LableSystemTime.Name = "TS_LableSystemTime";
            this.TS_LableSystemTime.Size = new System.Drawing.Size(230, 56);
            this.TS_LableSystemTime.Text = "toolStripLabel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.labeltx);
            this.panel1.Controls.Add(this.picBox1);
            this.panel1.Location = new System.Drawing.Point(177, 564);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 38);
            this.panel1.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(323, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(460, 21);
            this.textBox2.TabIndex = 469;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 468;
            // 
            // labeltx
            // 
            this.labeltx.AutoSize = true;
            this.labeltx.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltx.Location = new System.Drawing.Point(11, 8);
            this.labeltx.Name = "labeltx";
            this.labeltx.Size = new System.Drawing.Size(109, 20);
            this.labeltx.TabIndex = 467;
            this.labeltx.Text = "桩心跳指示";
            // 
            // picBox1
            // 
            this.picBox1.Image = ((System.Drawing.Image)(resources.GetObject("picBox1.Image")));
            this.picBox1.Location = new System.Drawing.Point(126, 4);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(41, 31);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 3;
            this.picBox1.TabStop = false;
            // 
            // TimeSendData
            // 
            this.TimeSendData.Interval = 500;
            this.TimeSendData.Tick += new System.EventHandler(this.TimeSendData_Tick);
            // 
            // timeDealRevData
            // 
            this.timeDealRevData.Enabled = true;
            this.timeDealRevData.Tick += new System.EventHandler(this.timeDealRevData_Tick);
            // 
            // updateFrameTimer
            // 
            this.updateFrameTimer.Enabled = true;
            this.updateFrameTimer.Interval = 3000;
            this.updateFrameTimer.Tick += new System.EventHandler(this.updateFrameTimer_Tick);
            // 
            // skinEngine2
            // 
            this.skinEngine2.@__DrawButtonFocusRectangle = true;
            this.skinEngine2.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine2.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine2.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine2.SerialNumber = "";
            this.skinEngine2.SkinFile = null;
            // 
            // TimSysTime
            // 
            this.TimSysTime.Interval = 1000;
            this.TimSysTime.Tick += new System.EventHandler(this.TimSysTime_Tick);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(177, 334);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(6);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(783, 228);
            this.zedGraphControl1.TabIndex = 30;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 469;
            this.label2.Text = "充电桩地址:";
            // 
            // txtChargingPileAddress
            // 
            this.txtChargingPileAddress.Location = new System.Drawing.Point(74, 10);
            this.txtChargingPileAddress.Name = "txtChargingPileAddress";
            this.txtChargingPileAddress.Size = new System.Drawing.Size(153, 21);
            this.txtChargingPileAddress.TabIndex = 470;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(262, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 471;
            this.label11.Text = "桩心跳帧";
            // 
            // heartStateLed
            // 
            this.heartStateLed.AutoSize = true;
            this.heartStateLed.ForeColor = System.Drawing.Color.DarkGray;
            this.heartStateLed.Location = new System.Drawing.Point(423, 13);
            this.heartStateLed.Name = "heartStateLed";
            this.heartStateLed.Size = new System.Drawing.Size(17, 12);
            this.heartStateLed.TabIndex = 473;
            this.heartStateLed.Text = "●";
            // 
            // setTimeLed
            // 
            this.setTimeLed.AutoSize = true;
            this.setTimeLed.ForeColor = System.Drawing.Color.DarkGray;
            this.setTimeLed.Location = new System.Drawing.Point(160, 13);
            this.setTimeLed.Name = "setTimeLed";
            this.setTimeLed.Size = new System.Drawing.Size(17, 12);
            this.setTimeLed.TabIndex = 476;
            this.setTimeLed.Text = "●";
            // 
            // btnSetTime
            // 
            this.btnSetTime.Location = new System.Drawing.Point(62, 6);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(86, 27);
            this.btnSetTime.TabIndex = 475;
            this.btnSetTime.Text = "设置时间";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 474;
            this.label13.Text = "设置时间:";
            // 
            // setRateLed
            // 
            this.setRateLed.AutoSize = true;
            this.setRateLed.ForeColor = System.Drawing.Color.DarkGray;
            this.setRateLed.Location = new System.Drawing.Point(164, 13);
            this.setRateLed.Name = "setRateLed";
            this.setRateLed.Size = new System.Drawing.Size(17, 12);
            this.setRateLed.TabIndex = 479;
            this.setRateLed.Text = "●";
            // 
            // btnSetPrice
            // 
            this.btnSetPrice.Location = new System.Drawing.Point(67, 6);
            this.btnSetPrice.Name = "btnSetPrice";
            this.btnSetPrice.Size = new System.Drawing.Size(86, 27);
            this.btnSetPrice.TabIndex = 478;
            this.btnSetPrice.Text = "设置费率";
            this.btnSetPrice.UseVisualStyleBackColor = true;
            this.btnSetPrice.Click += new System.EventHandler(this.btnSetPrice_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 477;
            this.label15.Text = "设置费率:";
            // 
            // cpStartLed
            // 
            this.cpStartLed.AutoSize = true;
            this.cpStartLed.ForeColor = System.Drawing.Color.DarkGray;
            this.cpStartLed.Location = new System.Drawing.Point(131, 46);
            this.cpStartLed.Name = "cpStartLed";
            this.cpStartLed.Size = new System.Drawing.Size(17, 12);
            this.cpStartLed.TabIndex = 482;
            this.cpStartLed.Text = "●";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(39, 39);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(86, 27);
            this.btnRun.TabIndex = 481;
            this.btnRun.Text = "充电桩启动";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 12);
            this.label17.TabIndex = 480;
            this.label17.Text = "控制充电桩启停";
            // 
            // cpStateLed
            // 
            this.cpStateLed.AutoSize = true;
            this.cpStateLed.ForeColor = System.Drawing.Color.DarkGray;
            this.cpStateLed.Location = new System.Drawing.Point(146, 11);
            this.cpStateLed.Name = "cpStateLed";
            this.cpStateLed.Size = new System.Drawing.Size(17, 12);
            this.cpStateLed.TabIndex = 485;
            this.cpStateLed.Text = "●";
            // 
            // btnCPState
            // 
            this.btnCPState.Location = new System.Drawing.Point(74, 1);
            this.btnCPState.Name = "btnCPState";
            this.btnCPState.Size = new System.Drawing.Size(69, 27);
            this.btnCPState.TabIndex = 484;
            this.btnCPState.Text = "查看状态";
            this.btnCPState.UseVisualStyleBackColor = true;
            this.btnCPState.Click += new System.EventHandler(this.btnCPState_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 12);
            this.label19.TabIndex = 483;
            this.label19.Text = "充电桩状态:";
            // 
            // curChargeInfoLed
            // 
            this.curChargeInfoLed.AutoSize = true;
            this.curChargeInfoLed.ForeColor = System.Drawing.Color.DarkGray;
            this.curChargeInfoLed.Location = new System.Drawing.Point(136, 9);
            this.curChargeInfoLed.Name = "curChargeInfoLed";
            this.curChargeInfoLed.Size = new System.Drawing.Size(17, 12);
            this.curChargeInfoLed.TabIndex = 488;
            this.curChargeInfoLed.Text = "●";
            // 
            // btnCurCharge
            // 
            this.btnCurCharge.Location = new System.Drawing.Point(61, 2);
            this.btnCurCharge.Name = "btnCurCharge";
            this.btnCurCharge.Size = new System.Drawing.Size(69, 27);
            this.btnCurCharge.TabIndex = 487;
            this.btnCurCharge.Text = "充电信息";
            this.btnCurCharge.UseVisualStyleBackColor = true;
            this.btnCurCharge.Click += new System.EventHandler(this.btnCurCharge_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 12);
            this.label21.TabIndex = 486;
            this.label21.Text = "充电信息:";
            // 
            // heartTime
            // 
            this.heartTime.Enabled = true;
            this.heartTime.Interval = 10000;
            this.heartTime.Tick += new System.EventHandler(this.heartTime_Tick);
            // 
            // btnHeartFrame
            // 
            this.btnHeartFrame.Location = new System.Drawing.Point(322, 6);
            this.btnHeartFrame.Name = "btnHeartFrame";
            this.btnHeartFrame.Size = new System.Drawing.Size(86, 27);
            this.btnHeartFrame.TabIndex = 489;
            this.btnHeartFrame.Text = "桩心跳帧";
            this.btnHeartFrame.UseVisualStyleBackColor = true;
            this.btnHeartFrame.Click += new System.EventHandler(this.btnHeartFrame_Click);
            // 
            // cpPauseLed
            // 
            this.cpPauseLed.AutoSize = true;
            this.cpPauseLed.ForeColor = System.Drawing.Color.DarkGray;
            this.cpPauseLed.Location = new System.Drawing.Point(132, 82);
            this.cpPauseLed.Name = "cpPauseLed";
            this.cpPauseLed.Size = new System.Drawing.Size(17, 12);
            this.cpPauseLed.TabIndex = 491;
            this.cpPauseLed.Text = "●";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(40, 75);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(86, 27);
            this.btnPause.TabIndex = 490;
            this.btnPause.Text = "充电桩暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // cpStopLed
            // 
            this.cpStopLed.AutoSize = true;
            this.cpStopLed.ForeColor = System.Drawing.Color.DarkGray;
            this.cpStopLed.Location = new System.Drawing.Point(132, 154);
            this.cpStopLed.Name = "cpStopLed";
            this.cpStopLed.Size = new System.Drawing.Size(17, 12);
            this.cpStopLed.TabIndex = 493;
            this.cpStopLed.Text = "●";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(40, 147);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(86, 27);
            this.btnStop.TabIndex = 492;
            this.btnStop.Text = "充电桩停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cpRecoverLed
            // 
            this.cpRecoverLed.AutoSize = true;
            this.cpRecoverLed.ForeColor = System.Drawing.Color.DarkGray;
            this.cpRecoverLed.Location = new System.Drawing.Point(132, 118);
            this.cpRecoverLed.Name = "cpRecoverLed";
            this.cpRecoverLed.Size = new System.Drawing.Size(17, 12);
            this.cpRecoverLed.TabIndex = 495;
            this.cpRecoverLed.Text = "●";
            // 
            // btnRecover
            // 
            this.btnRecover.Location = new System.Drawing.Point(40, 111);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(86, 27);
            this.btnRecover.TabIndex = 494;
            this.btnRecover.Text = "充电桩恢复";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(458, 7);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(104, 27);
            this.btnGetData.TabIndex = 457;
            this.btnGetData.Text = "扫描查询";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // tsmi_CDZParaSet
            // 
            this.tsmi_CDZParaSet.Name = "tsmi_CDZParaSet";
            this.tsmi_CDZParaSet.Size = new System.Drawing.Size(152, 22);
            this.tsmi_CDZParaSet.Text = "充电桩配置";
            // 
            // tsmi_AlarmLimitSet
            // 
            this.tsmi_AlarmLimitSet.Name = "tsmi_AlarmLimitSet";
            this.tsmi_AlarmLimitSet.Size = new System.Drawing.Size(152, 22);
            this.tsmi_AlarmLimitSet.Text = "告警阈值配置";
            // 
            // panelSetTime
            // 
            this.panelSetTime.BackColor = System.Drawing.Color.White;
            this.panelSetTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSetTime.Controls.Add(this.cbSystemTime);
            this.panelSetTime.Controls.Add(this.txtSecond);
            this.panelSetTime.Controls.Add(this.label5);
            this.panelSetTime.Controls.Add(this.txtMinute);
            this.panelSetTime.Controls.Add(this.label4);
            this.panelSetTime.Controls.Add(this.txtHour);
            this.panelSetTime.Controls.Add(this.label3);
            this.panelSetTime.Controls.Add(this.dateTimeSet);
            this.panelSetTime.Controls.Add(this.label1);
            this.panelSetTime.Controls.Add(this.label13);
            this.panelSetTime.Controls.Add(this.btnSetTime);
            this.panelSetTime.Controls.Add(this.setTimeLed);
            this.panelSetTime.Location = new System.Drawing.Point(177, 126);
            this.panelSetTime.Name = "panelSetTime";
            this.panelSetTime.Size = new System.Drawing.Size(190, 202);
            this.panelSetTime.TabIndex = 466;
            this.panelSetTime.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSetTime_Paint);
            // 
            // cbSystemTime
            // 
            this.cbSystemTime.AutoSize = true;
            this.cbSystemTime.Location = new System.Drawing.Point(42, 171);
            this.cbSystemTime.Name = "cbSystemTime";
            this.cbSystemTime.Size = new System.Drawing.Size(96, 16);
            this.cbSystemTime.TabIndex = 485;
            this.cbSystemTime.Text = "采用系统时间";
            this.cbSystemTime.UseVisualStyleBackColor = true;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(61, 139);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 21);
            this.txtSecond.TabIndex = 484;
            this.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 483;
            this.label5.Text = "秒:";
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(62, 112);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(100, 21);
            this.txtMinute.TabIndex = 482;
            this.txtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 481;
            this.label4.Text = "分:";
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(62, 84);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(100, 21);
            this.txtHour.TabIndex = 480;
            this.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 479;
            this.label3.Text = "时:";
            // 
            // dateTimeSet
            // 
            this.dateTimeSet.Location = new System.Drawing.Point(61, 52);
            this.dateTimeSet.Name = "dateTimeSet";
            this.dateTimeSet.Size = new System.Drawing.Size(120, 21);
            this.dateTimeSet.TabIndex = 478;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 477;
            this.label1.Text = "年月日:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.txtRateValleyPrice);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtRateFlatPrice);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtRatePeakPrice);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtRatePointPrice);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnSetPrice);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.setRateLed);
            this.panel2.Location = new System.Drawing.Point(367, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 202);
            this.panel2.TabIndex = 496;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(198, 146);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(288, 55);
            this.panel7.TabIndex = 526;
            // 
            // txtRateValleyPrice
            // 
            this.txtRateValleyPrice.Location = new System.Drawing.Point(67, 140);
            this.txtRateValleyPrice.Name = "txtRateValleyPrice";
            this.txtRateValleyPrice.Size = new System.Drawing.Size(100, 21);
            this.txtRateValleyPrice.TabIndex = 492;
            this.txtRateValleyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 491;
            this.label9.Text = "谷电价:";
            // 
            // txtRateFlatPrice
            // 
            this.txtRateFlatPrice.Location = new System.Drawing.Point(67, 110);
            this.txtRateFlatPrice.Name = "txtRateFlatPrice";
            this.txtRateFlatPrice.Size = new System.Drawing.Size(100, 21);
            this.txtRateFlatPrice.TabIndex = 490;
            this.txtRateFlatPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 489;
            this.label6.Text = "平电价:";
            // 
            // txtRatePeakPrice
            // 
            this.txtRatePeakPrice.Location = new System.Drawing.Point(67, 80);
            this.txtRatePeakPrice.Name = "txtRatePeakPrice";
            this.txtRatePeakPrice.Size = new System.Drawing.Size(100, 21);
            this.txtRatePeakPrice.TabIndex = 488;
            this.txtRatePeakPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 487;
            this.label7.Text = "峰电价:";
            // 
            // txtRatePointPrice
            // 
            this.txtRatePointPrice.Location = new System.Drawing.Point(67, 50);
            this.txtRatePointPrice.Name = "txtRatePointPrice";
            this.txtRatePointPrice.Size = new System.Drawing.Size(100, 21);
            this.txtRatePointPrice.TabIndex = 486;
            this.txtRatePointPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 485;
            this.label8.Text = "尖电价:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.cpStopLed);
            this.panel3.Controls.Add(this.cpRecoverLed);
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Controls.Add(this.btnRun);
            this.panel3.Controls.Add(this.btnRecover);
            this.panel3.Controls.Add(this.cpStartLed);
            this.panel3.Controls.Add(this.btnPause);
            this.panel3.Controls.Add(this.cpPauseLed);
            this.panel3.Location = new System.Drawing.Point(966, 334);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 228);
            this.panel3.TabIndex = 497;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnListen);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnHeartFrame);
            this.panel4.Controls.Add(this.txtChargingPileAddress);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.heartStateLed);
            this.panel4.Controls.Add(this.btnGetData);
            this.panel4.Controls.Add(this.btnOpenPort);
            this.panel4.Location = new System.Drawing.Point(177, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(973, 42);
            this.panel4.TabIndex = 498;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(691, 7);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(104, 27);
            this.btnListen.TabIndex = 490;
            this.btnListen.Text = "打开监听";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtLeftTime);
            this.panel5.Controls.Add(this.label29);
            this.panel5.Controls.Add(this.txtChargeTime);
            this.panel5.Controls.Add(this.label28);
            this.panel5.Controls.Add(this.txtChargeSoc);
            this.panel5.Controls.Add(this.lblCurState);
            this.panel5.Controls.Add(this.label27);
            this.panel5.Controls.Add(this.lblPlugState);
            this.panel5.Controls.Add(this.btnAutoCheck);
            this.panel5.Controls.Add(this.txtValleyElect);
            this.panel5.Controls.Add(this.lblCurLed);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.txtFlatElect);
            this.panel5.Controls.Add(this.lblPlugLed);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.lblElectState);
            this.panel5.Controls.Add(this.txtPeakElect);
            this.panel5.Controls.Add(this.lblElectLed);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.txtPointElect);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.lblStopState);
            this.panel5.Controls.Add(this.txtTotalElect);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.lblStopLed);
            this.panel5.Controls.Add(this.txtCurrent);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.txtValtage);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.btnCPState);
            this.panel5.Controls.Add(this.cpStateLed);
            this.panel5.Location = new System.Drawing.Point(566, 126);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(288, 202);
            this.panel5.TabIndex = 499;
            // 
            // txtLeftTime
            // 
            this.txtLeftTime.Location = new System.Drawing.Point(208, 120);
            this.txtLeftTime.Name = "txtLeftTime";
            this.txtLeftTime.Size = new System.Drawing.Size(74, 21);
            this.txtLeftTime.TabIndex = 525;
            this.txtLeftTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(147, 127);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 12);
            this.label29.TabIndex = 524;
            this.label29.Text = "剩余时间:";
            // 
            // txtChargeTime
            // 
            this.txtChargeTime.Location = new System.Drawing.Point(69, 121);
            this.txtChargeTime.Name = "txtChargeTime";
            this.txtChargeTime.Size = new System.Drawing.Size(74, 21);
            this.txtChargeTime.TabIndex = 523;
            this.txtChargeTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 125);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(59, 12);
            this.label28.TabIndex = 522;
            this.label28.Text = "充电时间:";
            // 
            // txtChargeSoc
            // 
            this.txtChargeSoc.Location = new System.Drawing.Point(69, 98);
            this.txtChargeSoc.Name = "txtChargeSoc";
            this.txtChargeSoc.Size = new System.Drawing.Size(74, 21);
            this.txtChargeSoc.TabIndex = 521;
            this.txtChargeSoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCurState
            // 
            this.lblCurState.AutoSize = true;
            this.lblCurState.Location = new System.Drawing.Point(229, 177);
            this.lblCurState.Name = "lblCurState";
            this.lblCurState.Size = new System.Drawing.Size(41, 12);
            this.lblCurState.TabIndex = 517;
            this.lblCurState.Text = "有输出";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 102);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 12);
            this.label27.TabIndex = 520;
            this.label27.Text = "当前SOC:";
            // 
            // lblPlugState
            // 
            this.lblPlugState.AutoSize = true;
            this.lblPlugState.Location = new System.Drawing.Point(229, 153);
            this.lblPlugState.Name = "lblPlugState";
            this.lblPlugState.Size = new System.Drawing.Size(29, 12);
            this.lblPlugState.TabIndex = 517;
            this.lblPlugState.Text = "插好";
            // 
            // btnAutoCheck
            // 
            this.btnAutoCheck.Location = new System.Drawing.Point(212, 1);
            this.btnAutoCheck.Name = "btnAutoCheck";
            this.btnAutoCheck.Size = new System.Drawing.Size(69, 27);
            this.btnAutoCheck.TabIndex = 519;
            this.btnAutoCheck.Text = "自动查看";
            this.btnAutoCheck.UseVisualStyleBackColor = true;
            this.btnAutoCheck.Click += new System.EventHandler(this.btnAutoCheck_Click);
            // 
            // txtValleyElect
            // 
            this.txtValleyElect.Location = new System.Drawing.Point(208, 97);
            this.txtValleyElect.Name = "txtValleyElect";
            this.txtValleyElect.Size = new System.Drawing.Size(74, 21);
            this.txtValleyElect.TabIndex = 506;
            this.txtValleyElect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCurLed
            // 
            this.lblCurLed.AutoSize = true;
            this.lblCurLed.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCurLed.Location = new System.Drawing.Point(206, 177);
            this.lblCurLed.Name = "lblCurLed";
            this.lblCurLed.Size = new System.Drawing.Size(17, 12);
            this.lblCurLed.TabIndex = 516;
            this.lblCurLed.Text = "●";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(159, 101);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 12);
            this.label25.TabIndex = 505;
            this.label25.Text = "谷电量:";
            // 
            // txtFlatElect
            // 
            this.txtFlatElect.Location = new System.Drawing.Point(208, 74);
            this.txtFlatElect.Name = "txtFlatElect";
            this.txtFlatElect.Size = new System.Drawing.Size(74, 21);
            this.txtFlatElect.TabIndex = 504;
            this.txtFlatElect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlugLed
            // 
            this.lblPlugLed.AutoSize = true;
            this.lblPlugLed.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPlugLed.Location = new System.Drawing.Point(206, 153);
            this.lblPlugLed.Name = "lblPlugLed";
            this.lblPlugLed.Size = new System.Drawing.Size(17, 12);
            this.lblPlugLed.TabIndex = 516;
            this.lblPlugLed.Text = "●";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(159, 78);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 12);
            this.label26.TabIndex = 503;
            this.label26.Text = "平电量:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(147, 153);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 12);
            this.label22.TabIndex = 511;
            this.label22.Text = "充电插头:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(141, 177);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 513;
            this.label16.Text = "当前状态:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 178);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 12);
            this.label23.TabIndex = 509;
            this.label23.Text = "电表状态:";
            // 
            // lblElectState
            // 
            this.lblElectState.AutoSize = true;
            this.lblElectState.Location = new System.Drawing.Point(88, 177);
            this.lblElectState.Name = "lblElectState";
            this.lblElectState.Size = new System.Drawing.Size(53, 12);
            this.lblElectState.TabIndex = 517;
            this.lblElectState.Text = "通信正常";
            // 
            // txtPeakElect
            // 
            this.txtPeakElect.Location = new System.Drawing.Point(208, 52);
            this.txtPeakElect.Name = "txtPeakElect";
            this.txtPeakElect.Size = new System.Drawing.Size(74, 21);
            this.txtPeakElect.TabIndex = 500;
            this.txtPeakElect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblElectLed
            // 
            this.lblElectLed.AutoSize = true;
            this.lblElectLed.ForeColor = System.Drawing.Color.DarkGray;
            this.lblElectLed.Location = new System.Drawing.Point(65, 177);
            this.lblElectLed.Name = "lblElectLed";
            this.lblElectLed.Size = new System.Drawing.Size(17, 12);
            this.lblElectLed.TabIndex = 516;
            this.lblElectLed.Text = "●";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(159, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 12);
            this.label18.TabIndex = 499;
            this.label18.Text = "峰电量:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 153);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(59, 12);
            this.label24.TabIndex = 507;
            this.label24.Text = "急停控钮:";
            // 
            // txtPointElect
            // 
            this.txtPointElect.Location = new System.Drawing.Point(208, 29);
            this.txtPointElect.Name = "txtPointElect";
            this.txtPointElect.Size = new System.Drawing.Size(74, 21);
            this.txtPointElect.TabIndex = 498;
            this.txtPointElect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(159, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 12);
            this.label20.TabIndex = 497;
            this.label20.Text = "尖电量:";
            // 
            // lblStopState
            // 
            this.lblStopState.AutoSize = true;
            this.lblStopState.Location = new System.Drawing.Point(88, 152);
            this.lblStopState.Name = "lblStopState";
            this.lblStopState.Size = new System.Drawing.Size(29, 12);
            this.lblStopState.TabIndex = 515;
            this.lblStopState.Text = "正常";
            // 
            // txtTotalElect
            // 
            this.txtTotalElect.Location = new System.Drawing.Point(69, 74);
            this.txtTotalElect.Name = "txtTotalElect";
            this.txtTotalElect.Size = new System.Drawing.Size(74, 21);
            this.txtTotalElect.TabIndex = 496;
            this.txtTotalElect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 495;
            this.label14.Text = "总电量:";
            // 
            // lblStopLed
            // 
            this.lblStopLed.AutoSize = true;
            this.lblStopLed.ForeColor = System.Drawing.Color.DarkGray;
            this.lblStopLed.Location = new System.Drawing.Point(65, 152);
            this.lblStopLed.Name = "lblStopLed";
            this.lblStopLed.Size = new System.Drawing.Size(17, 12);
            this.lblStopLed.TabIndex = 514;
            this.lblStopLed.Text = "●";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(69, 52);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(74, 21);
            this.txtCurrent.TabIndex = 494;
            this.txtCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 493;
            this.label12.Text = "电流:";
            // 
            // txtValtage
            // 
            this.txtValtage.Location = new System.Drawing.Point(69, 29);
            this.txtValtage.Name = "txtValtage";
            this.txtValtage.Size = new System.Drawing.Size(74, 21);
            this.txtValtage.TabIndex = 492;
            this.txtValtage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 491;
            this.label10.Text = "电压:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnCheckChargeInfo);
            this.panel6.Controls.Add(this.txtCurValleyCost);
            this.panel6.Controls.Add(this.label37);
            this.panel6.Controls.Add(this.txtCurFlatCost);
            this.panel6.Controls.Add(this.label38);
            this.panel6.Controls.Add(this.txtCurPeakCost);
            this.panel6.Controls.Add(this.label39);
            this.panel6.Controls.Add(this.txtCurPointCost);
            this.panel6.Controls.Add(this.label40);
            this.panel6.Controls.Add(this.txtCurValleyPrice);
            this.panel6.Controls.Add(this.label41);
            this.panel6.Controls.Add(this.txtCurFlatPrice);
            this.panel6.Controls.Add(this.label42);
            this.panel6.Controls.Add(this.txtCurPeakPrice);
            this.panel6.Controls.Add(this.label43);
            this.panel6.Controls.Add(this.txtCurPointPrice);
            this.panel6.Controls.Add(this.label35);
            this.panel6.Controls.Add(this.txtCurValleyElect);
            this.panel6.Controls.Add(this.label36);
            this.panel6.Controls.Add(this.curChargeInfoLed);
            this.panel6.Controls.Add(this.btnCurCharge);
            this.panel6.Controls.Add(this.label21);
            this.panel6.Controls.Add(this.txtCurFlatElect);
            this.panel6.Controls.Add(this.label49);
            this.panel6.Controls.Add(this.txtCurPeakElect);
            this.panel6.Controls.Add(this.label50);
            this.panel6.Controls.Add(this.txtCurPointElect);
            this.panel6.Controls.Add(this.label51);
            this.panel6.Controls.Add(this.txtCurTotalCost);
            this.panel6.Controls.Add(this.label52);
            this.panel6.Controls.Add(this.txtCurTotalElect);
            this.panel6.Controls.Add(this.label53);
            this.panel6.Location = new System.Drawing.Point(855, 126);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(295, 202);
            this.panel6.TabIndex = 500;
            // 
            // btnCheckChargeInfo
            // 
            this.btnCheckChargeInfo.Location = new System.Drawing.Point(221, 2);
            this.btnCheckChargeInfo.Name = "btnCheckChargeInfo";
            this.btnCheckChargeInfo.Size = new System.Drawing.Size(69, 27);
            this.btnCheckChargeInfo.TabIndex = 525;
            this.btnCheckChargeInfo.Text = "自动查看";
            this.btnCheckChargeInfo.UseVisualStyleBackColor = true;
            this.btnCheckChargeInfo.Click += new System.EventHandler(this.btnCheckChargeInfo_Click);
            // 
            // txtCurValleyCost
            // 
            this.txtCurValleyCost.Location = new System.Drawing.Point(208, 174);
            this.txtCurValleyCost.Name = "txtCurValleyCost";
            this.txtCurValleyCost.Size = new System.Drawing.Size(82, 21);
            this.txtCurValleyCost.TabIndex = 524;
            this.txtCurValleyCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(158, 178);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(47, 12);
            this.label37.TabIndex = 523;
            this.label37.Text = "谷费用:";
            // 
            // txtCurFlatCost
            // 
            this.txtCurFlatCost.Location = new System.Drawing.Point(208, 149);
            this.txtCurFlatCost.Name = "txtCurFlatCost";
            this.txtCurFlatCost.Size = new System.Drawing.Size(82, 21);
            this.txtCurFlatCost.TabIndex = 522;
            this.txtCurFlatCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(158, 153);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(47, 12);
            this.label38.TabIndex = 521;
            this.label38.Text = "平费用:";
            // 
            // txtCurPeakCost
            // 
            this.txtCurPeakCost.Location = new System.Drawing.Point(208, 125);
            this.txtCurPeakCost.Name = "txtCurPeakCost";
            this.txtCurPeakCost.Size = new System.Drawing.Size(82, 21);
            this.txtCurPeakCost.TabIndex = 520;
            this.txtCurPeakCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(158, 129);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(47, 12);
            this.label39.TabIndex = 519;
            this.label39.Text = "峰费用:";
            // 
            // txtCurPointCost
            // 
            this.txtCurPointCost.Location = new System.Drawing.Point(208, 101);
            this.txtCurPointCost.Name = "txtCurPointCost";
            this.txtCurPointCost.Size = new System.Drawing.Size(82, 21);
            this.txtCurPointCost.TabIndex = 518;
            this.txtCurPointCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(158, 105);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(47, 12);
            this.label40.TabIndex = 517;
            this.label40.Text = "尖费用:";
            // 
            // txtCurValleyPrice
            // 
            this.txtCurValleyPrice.Location = new System.Drawing.Point(208, 77);
            this.txtCurValleyPrice.Name = "txtCurValleyPrice";
            this.txtCurValleyPrice.Size = new System.Drawing.Size(82, 21);
            this.txtCurValleyPrice.TabIndex = 516;
            this.txtCurValleyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(158, 81);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(47, 12);
            this.label41.TabIndex = 515;
            this.label41.Text = "谷电价:";
            // 
            // txtCurFlatPrice
            // 
            this.txtCurFlatPrice.Location = new System.Drawing.Point(208, 54);
            this.txtCurFlatPrice.Name = "txtCurFlatPrice";
            this.txtCurFlatPrice.Size = new System.Drawing.Size(82, 21);
            this.txtCurFlatPrice.TabIndex = 514;
            this.txtCurFlatPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(158, 58);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(47, 12);
            this.label42.TabIndex = 513;
            this.label42.Text = "平电价:";
            // 
            // txtCurPeakPrice
            // 
            this.txtCurPeakPrice.Location = new System.Drawing.Point(208, 30);
            this.txtCurPeakPrice.Name = "txtCurPeakPrice";
            this.txtCurPeakPrice.Size = new System.Drawing.Size(82, 21);
            this.txtCurPeakPrice.TabIndex = 512;
            this.txtCurPeakPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(158, 34);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(47, 12);
            this.label43.TabIndex = 511;
            this.label43.Text = "峰电价:";
            // 
            // txtCurPointPrice
            // 
            this.txtCurPointPrice.Location = new System.Drawing.Point(61, 174);
            this.txtCurPointPrice.Name = "txtCurPointPrice";
            this.txtCurPointPrice.Size = new System.Drawing.Size(82, 21);
            this.txtCurPointPrice.TabIndex = 510;
            this.txtCurPointPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(11, 178);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(47, 12);
            this.label35.TabIndex = 509;
            this.label35.Text = "尖电价:";
            // 
            // txtCurValleyElect
            // 
            this.txtCurValleyElect.Location = new System.Drawing.Point(61, 149);
            this.txtCurValleyElect.Name = "txtCurValleyElect";
            this.txtCurValleyElect.Size = new System.Drawing.Size(82, 21);
            this.txtCurValleyElect.TabIndex = 508;
            this.txtCurValleyElect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(11, 153);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(47, 12);
            this.label36.TabIndex = 507;
            this.label36.Text = "谷电量:";
            // 
            // txtCurFlatElect
            // 
            this.txtCurFlatElect.Location = new System.Drawing.Point(61, 125);
            this.txtCurFlatElect.Name = "txtCurFlatElect";
            this.txtCurFlatElect.Size = new System.Drawing.Size(82, 21);
            this.txtCurFlatElect.TabIndex = 500;
            this.txtCurFlatElect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(11, 129);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(47, 12);
            this.label49.TabIndex = 499;
            this.label49.Text = "平电量:";
            // 
            // txtCurPeakElect
            // 
            this.txtCurPeakElect.Location = new System.Drawing.Point(61, 101);
            this.txtCurPeakElect.Name = "txtCurPeakElect";
            this.txtCurPeakElect.Size = new System.Drawing.Size(82, 21);
            this.txtCurPeakElect.TabIndex = 498;
            this.txtCurPeakElect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(11, 105);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(47, 12);
            this.label50.TabIndex = 497;
            this.label50.Text = "峰电量:";
            // 
            // txtCurPointElect
            // 
            this.txtCurPointElect.Location = new System.Drawing.Point(61, 77);
            this.txtCurPointElect.Name = "txtCurPointElect";
            this.txtCurPointElect.Size = new System.Drawing.Size(82, 21);
            this.txtCurPointElect.TabIndex = 496;
            this.txtCurPointElect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(11, 81);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(47, 12);
            this.label51.TabIndex = 495;
            this.label51.Text = "尖电量:";
            // 
            // txtCurTotalCost
            // 
            this.txtCurTotalCost.Location = new System.Drawing.Point(61, 54);
            this.txtCurTotalCost.Name = "txtCurTotalCost";
            this.txtCurTotalCost.Size = new System.Drawing.Size(82, 21);
            this.txtCurTotalCost.TabIndex = 494;
            this.txtCurTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(11, 58);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(47, 12);
            this.label52.TabIndex = 493;
            this.label52.Text = "总费用:";
            // 
            // txtCurTotalElect
            // 
            this.txtCurTotalElect.Location = new System.Drawing.Point(61, 30);
            this.txtCurTotalElect.Name = "txtCurTotalElect";
            this.txtCurTotalElect.Size = new System.Drawing.Size(82, 21);
            this.txtCurTotalElect.TabIndex = 492;
            this.txtCurTotalElect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(11, 34);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(47, 12);
            this.label53.TabIndex = 491;
            this.label53.Text = "总电量:";
            // 
            // checkStateTime
            // 
            this.checkStateTime.Interval = 1000;
            this.checkStateTime.Tick += new System.EventHandler(this.checkStateTime_Tick);
            // 
            // heartLedTime
            // 
            this.heartLedTime.Interval = 1000;
            this.heartLedTime.Tick += new System.EventHandler(this.heartLedTime_Tick);
            // 
            // tvChargePile
            // 
            this.tvChargePile.Location = new System.Drawing.Point(0, 79);
            this.tvChargePile.Name = "tvChargePile";
            treeNode1.Name = "节点0";
            treeNode1.Text = "充电桩";
            this.tvChargePile.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvChargePile.Size = new System.Drawing.Size(177, 523);
            this.tvChargePile.TabIndex = 501;
            // 
            // MonitoringInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(642, 391);
            this.Controls.Add(this.tvChargePile);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelSetTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.panel5);
            this.Name = "MonitoringInterface";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "充电桩服务器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.panelSetTime.ResumeLayout(false);
            this.panelSetTime.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer TimeSendData;
        private System.Windows.Forms.Timer timeDealRevData;
        private Sunisoft.IrisSkin.SkinEngine skinEngine2;
        public System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.Timer updateFrameTimer;
        private System.Windows.Forms.Label labeltx;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Timer TimSysTime;
        private System.Windows.Forms.ToolStripLabel TS_LableSystemTime;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChargingPileAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label heartStateLed;
        private System.Windows.Forms.Label setTimeLed;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label setRateLed;
        private System.Windows.Forms.Button btnSetPrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label cpStartLed;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label cpStateLed;
        private System.Windows.Forms.Button btnCPState;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label curChargeInfoLed;
        private System.Windows.Forms.Button btnCurCharge;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Timer heartTime;
        private System.Windows.Forms.Button btnHeartFrame;
        private System.Windows.Forms.Label cpPauseLed;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label cpStopLed;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label cpRecoverLed;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.ToolStripMenuItem tsmi_CDZParaSet;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AlarmLimitSet;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton_Config;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Panel panelSetTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Look;
        private System.Windows.Forms.ToolStripButton toolStripButton_Alarm;
        private System.Windows.Forms.ToolStripButton toolStripButton_User;
        private System.Windows.Forms.ToolStripButton toolStripButton_FileMng;
        private System.Windows.Forms.ToolStripButton toolStripButton_Card;
        private System.Windows.Forms.ToolStripMenuItem 串口设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton_Report;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ChargeRecordReport;
        private System.Windows.Forms.ToolStripButton toolStripButton_Curve;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton_About;
        private System.Windows.Forms.ToolStripButton TSBtnExist;
        private System.Windows.Forms.ToolStripButton toolStripButton_UpDown;
        private System.Windows.Forms.ToolStripButton toolStripButton_SHTV;
        private System.Windows.Forms.DateTimePicker dateTimeSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.CheckBox cbSystemTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtRateValleyPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRateFlatPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRatePeakPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRatePointPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtValtage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtValleyElect;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtFlatElect;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtPeakElect;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPointElect;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTotalElect;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCurState;
        private System.Windows.Forms.Label lblPlugState;
        private System.Windows.Forms.Label lblCurLed;
        private System.Windows.Forms.Label lblPlugLed;
        private System.Windows.Forms.Label lblElectState;
        private System.Windows.Forms.Label lblElectLed;
        private System.Windows.Forms.Label lblStopState;
        private System.Windows.Forms.Label lblStopLed;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCurFlatElect;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox txtCurPeakElect;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox txtCurPointElect;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox txtCurTotalCost;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtCurTotalElect;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox txtCurPointPrice;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtCurValleyElect;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtCurValleyCost;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtCurFlatCost;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtCurPeakCost;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtCurPointCost;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtCurValleyPrice;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtCurFlatPrice;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtCurPeakPrice;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button btnAutoCheck;
        private System.Windows.Forms.Timer checkStateTime;
        private System.Windows.Forms.Button btnCheckChargeInfo;
        private System.Windows.Forms.Timer heartLedTime;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtLeftTime;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtChargeTime;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtChargeSoc;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TreeView tvChargePile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

