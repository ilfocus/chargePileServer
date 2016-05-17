using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.OleDb;    // 数据库对象
using System.Collections;
using System.Reflection;    // missing.values
using System.IO;            //File.Exists

using ChargingPileServer.Properties;
using ChargingPileServer.WinForm;

using ZedGraph;

// Socket监听类
using System.Net.Sockets;
using System.Net;
using System.Threading;

using CPServer;

namespace ChargingPileServer
{
    
    public partial class MonitoringInterface : Form
    {
        private const int NUM_OF_MAIN_DEVICE = 20;
        private const int NUM_OF_SUBDEVICE   = 6;
        // 创建标签数组
        private System.Windows.Forms.Label[] subMachineErrorStatus_1 = new System.Windows.Forms.Label[30];
        private System.Windows.Forms.Label[] subMachineErrorStatus_2 = new System.Windows.Forms.Label[30];
        private System.Windows.Forms.Label[] subMachineErrorStatus_3 = new System.Windows.Forms.Label[30];
        private System.Windows.Forms.Label[] subMachineErrorStatus_4 = new System.Windows.Forms.Label[30];
        private System.Windows.Forms.Label[] subMachineErrorStatus_5 = new System.Windows.Forms.Label[30];
        private System.Windows.Forms.Label[] subMachineErrorStatus_6 = new System.Windows.Forms.Label[30];
        // 把标签数组加入泛型队列中
        private List<System.Windows.Forms.Label[]> subMachineErrorStatusList = new List<System.Windows.Forms.Label[]>();

        private List<MainDevice> mainDev = new List<MainDevice>();// 创建主机对象集合
        
        private List<ChargePileDevice> cpDevice = new List<ChargePileDevice>(); // creat charge pile object collection

        private List<chargePileDataPacket>cpDataPacket = new List<chargePileDataPacket>();

        Queue receiveByteQueue = Queue.Synchronized(new Queue());//线程安全的数据队列，用来中转串口来的数据

        PointPairList curAList = new PointPairList();
        PointPairList curBList = new PointPairList();
        LineItem curACurve;
        LineItem curBCurve;

        private int lastScanMainDevNum = 0;
        private int lastScanMainDevCount = 0;
        private bool blDataFlag = false;                        // 数据接收完成标志
        private byte ubNumberTestMachine = 0x00;                // 主机号

        TreeNode node1 = new TreeNode();
        
        SetComPara frmSetComPara = new SetComPara();            // 定义串口参数设置对象
        OnOffSet frmOnOffSet = new OnOffSet();                  // 定义开关机设置对象
        private ParameterSet paraSetForm = null;                // 参数显示对象

        private byte[] byteArray = new byte[62];                // 因为串口接收数据会出现不连续
        private int iDataLenRecrod = 0;                         // 所以用数组把数据连接起来 
        UInt16 uiCheckCnt = 0;                                  // 数据校验错误后，重传计数
        private bool bQueryMsgFlg = false;                      // 查询数据数据包发送标志

        static readonly UInt16[] wCRC16Table = {
         0x0000, 0xC0C1, 0xC181, 0x0140, 0xC301, 0x03C0, 0x0280, 0xC241,
         0xC601, 0x06C0, 0x0780, 0xC741, 0x0500, 0xC5C1, 0xC481, 0x0440,
         0xCC01, 0x0CC0, 0x0D80, 0xCD41, 0x0F00, 0xCFC1, 0xCE81, 0x0E40, 
         0x0A00, 0xCAC1, 0xCB81, 0x0B40, 0xC901, 0x09C0, 0x0880, 0xC841,
         0xD801, 0x18C0, 0x1980, 0xD941, 0x1B00, 0xDBC1, 0xDA81, 0x1A40,  
         0x1E00, 0xDEC1, 0xDF81, 0x1F40, 0xDD01, 0x1DC0, 0x1C80, 0xDC41,
         0x1400, 0xD4C1, 0xD581, 0x1540, 0xD701, 0x17C0, 0x1680, 0xD641,
         0xD201, 0x12C0, 0x1380, 0xD341, 0x1100, 0xD1C1, 0xD081, 0x1040,
         0xF001, 0x30C0, 0x3180, 0xF141, 0x3300, 0xF3C1, 0xF281, 0x3240,
         0x3600, 0xF6C1, 0xF781, 0x3740, 0xF501, 0x35C0, 0x3480, 0xF441,   
         0x3C00, 0xFCC1, 0xFD81, 0x3D40, 0xFF01, 0x3FC0, 0x3E80, 0xFE41,
         0xFA01, 0x3AC0, 0x3B80, 0xFB41, 0x3900, 0xF9C1, 0xF881, 0x3840,
         0x2800, 0xE8C1, 0xE981, 0x2940, 0xEB01, 0x2BC0, 0x2A80, 0xEA41,
         0xEE01, 0x2EC0, 0x2F80, 0xEF41, 0x2D00, 0xEDC1, 0xEC81, 0x2C40,
         0xE401, 0x24C0, 0x2580, 0xE541, 0x2700, 0xE7C1, 0xE681, 0x2640,   
         0x2200, 0xE2C1, 0xE381, 0x2340, 0xE101, 0x21C0, 0x2080, 0xE041,
         0xA001, 0x60C0, 0x6180, 0xA141, 0x6300, 0xA3C1, 0xA281, 0x6240,
         0x6600, 0xA6C1, 0xA781, 0x6740, 0xA501, 0x65C0, 0x6480, 0xA441,
         0x6C00, 0xACC1, 0xAD81, 0x6D40, 0xAF01, 0x6FC0, 0x6E80, 0xAE41,
         0xAA01, 0x6AC0, 0x6B80, 0xAB41, 0x6900, 0xA9C1, 0xA881, 0x6840,   
         0x7800, 0xB8C1, 0xB981, 0x7940, 0xBB01, 0x7BC0, 0x7A80, 0xBA41,
         0xBE01, 0x7EC0, 0x7F80, 0xBF41, 0x7D00, 0xBDC1, 0xBC81, 0x7C40,
         0xB401, 0x74C0, 0x7580, 0xB541, 0x7700, 0xB7C1, 0xB681, 0x7640,
         0x7200, 0xB2C1, 0xB381, 0x7340, 0xB101, 0x71C0, 0x7080, 0xB041,
         0x5000, 0x90C1, 0x9181, 0x5140, 0x9301, 0x53C0, 0x5280, 0x9241,  
         0x9601, 0x56C0, 0x5780, 0x9741, 0x5500, 0x95C1, 0x9481, 0x5440,
         0x9C01, 0x5CC0, 0x5D80, 0x9D41, 0x5F00, 0x9FC1, 0x9E81, 0x5E40,
         0x5A00, 0x9AC1, 0x9B81, 0x5B40, 0x9901, 0x59C0, 0x5880, 0x9841,
         0x8801, 0x48C0, 0x4980, 0x8941, 0x4B00, 0x8BC1, 0x8A81, 0x4A40,
         0x4E00, 0x8EC1, 0x8F81, 0x4F40, 0x8D01, 0x4DC0, 0x4C80, 0x8C41,  
         0x4400, 0x84C1, 0x8581, 0x4540, 0x8701, 0x47C0, 0x4680, 0x8641,
         0x8201, 0x42C0, 0x4380, 0x8341, 0x4100, 0x81C1, 0x8081, 0x4040,
        };
        public MonitoringInterface()
        {
            InitializeComponent();

            skinEngine2.SkinFile = System.Windows.Forms.Application.StartupPath.Replace(@"\bin\Debug", "") + @"\Resources\GlassGreen.ssk";
            skinEngine2.SkinAllForm = true;
        }
        public void CRC_16(byte[] pDataIn, int iLenIn, out  UInt16 pCRCOut)
        {

            UInt16 wResult = 0;
            UInt16 wTableNo = 0;
            UInt16 i = 0;

            for (i = 0; i < iLenIn; i++)
            {
                wTableNo = (UInt16)((wResult & 0xff) ^ (pDataIn[i] & 0xff));
                wResult = (UInt16)(((wResult >> 8) & 0xff) ^ wCRC16Table[(UInt16)wTableNo]);
            }

            pCRCOut = wResult;
        }
        // 设备数据模型初始化，main_device为老化车，subDevice为老化车上的分机
        private void DevicesInit()
        {
            for (int j = 0; j < NUM_OF_MAIN_DEVICE; j++) {   // 20个老化车（主机）
            
                MainDevice m = new MainDevice();            // 创建一个老化车对象
                
                m.Id = j;
                m.Name = "mainDev_" + j;
                m.DevList = new List<SubDevice>();          // 老化车中的分机设备，分机设备泛型表
                
                for (int i = 0; i < NUM_OF_SUBDEVICE; i++) { // 六个分机设备
                
                    SubDevice sub = new SubDevice();        // 创建分机对象
                    
                    sub.Id = i;
                    sub.Name = "subDev_" + i;
                    sub.CurrentAList = new PointPairList(); // ?
                    sub.CurrentBList = new PointPairList();
                    sub.EStatus = 0;                        // 分机参数初始化

                    m.DevList.Add(sub);                     // 把分机添加进分机设备泛型表
                }
                mainDev.Add(m);                             // 添加主机泛型队列
            }
        }
        private void testNode()
        {//测试Model数据的使用
            Queue queue = new Queue();

            for (int j = 0; j < NUM_OF_MAIN_DEVICE; j++)
            {
                MainDevice m = mainDev[j];
                Console.WriteLine("|-i--{0}",m.Name);
                for (int i = 0; i < NUM_OF_SUBDEVICE; i++)
                {
                    SubDevice sub = m.DevList[i];
                    Console.WriteLine("  |-{0}", sub.Name);
                }
            }
            for (int i = 0; i < 6; i++)
            {
                String s = "num_" + i;
                queue.Enqueue(s);
            }
            for (int i = 0; i < 6; i++)
            {
                String s = (String)queue.Dequeue();
                Console.WriteLine(s);
            }

        }
        // 故障信息指示灯阵列初始化 
        private void FaultMessageMatrixInit()
        {
        }
        /// <summary>
        /// 对界面上故障点数据进行更新
        /// </summary>


        private void loadCpServerDll() {
            test test = new test();
            test.showMessage();
        }

        /*************************************************************************/
        /*  
        *   功能描述：各个窗体对象，用于父子窗体间资源共享
        *   修改日期：无
        *   修改内容：无
        */
        /*************************************************************************/
        private void Form1_Load(object sender, EventArgs e)
        {
            //加载皮肤 
            skinEngine2.SkinFile = System.Windows.Forms.Application.StartupPath.Replace(@"\bin\Debug", "") + @"\skins\SteelBlue.ssk";
            skinEngine2.SkinAllForm = true;

            ////////////////////////串口端口初始化////////////////////////////////////
            try
            {
                string[] szPorts = SerialPort.GetPortNames(); //获取当前可用的串口列表
                //这里得到的可用的串口，是指电脑里面可用的串口。
                frmSetComPara.combSerialPort.Items.AddRange(szPorts);
                frmSetComPara.combSerialPort.SelectedIndex = 0;
            }
            catch (Win32Exception win32ex) // 获取串口出错
            {
                MessageBox.Show(win32ex.ToString());
            }
            ////////////////////////////////////////////////////////////////////////
            //故障信息阵列显示界面初始化
            FaultMessageMatrixInit();
            //设备数据模型初始化
            DevicesInit();

            //testNode();

            frmSetComPara.combBaudRate.Text     = "9600";
            frmSetComPara.combDataBit.Text      = "8";
            frmSetComPara.combStopBits.Text     = "1";
            frmSetComPara.SerialParity.Text     = "None";
            frmSetComPara.combSerialPort.Text   = "COM1";

            // N1-N6,分机1-6,故障信息界面初始化
            for (int i = 0; i < subMachineErrorStatus_1.Length; i++)
            {
                /*
                subMachineErrorStatus_1[i].ForeColor = Color.Green;
                subMachineErrorStatus_2[i].ForeColor = Color.Green;
                subMachineErrorStatus_3[i].ForeColor = Color.Green;
                subMachineErrorStatus_4[i].ForeColor = Color.Green;
                subMachineErrorStatus_5[i].ForeColor = Color.Green;
                subMachineErrorStatus_6[i].ForeColor = Color.Green;
                 */
            }
            Console.WriteLine("this is a message!!");

            // 以上部分为故障点初始化

            serialPort1.Encoding = Encoding.GetEncoding("gb2312");//接收发送转换编码

            Console.WriteLine("buff size:{0}", serialPort1.ReadBufferSize);

            // 测试模块
            for (int j = 0; j < 20; j++)
            {
                //TreeNode node2 = new TreeNode((j + 1).ToString()+"号老化车");
                TreeNode node2 = new TreeNode((j + 1).ToString() + "号老化车");
                node1.Nodes.Add(node2);
            }

            //zedGraph 初始化
            zedGraphControl1.GraphPane.Title.Text = "A/B路电流实时曲线";
            zedGraphControl1.GraphPane.XAxis.Title.Text = "时间";
            zedGraphControl1.GraphPane.YAxis.Title.Text = "电流";
            zedGraphControl1.GraphPane.XAxis.Type = ZedGraph.AxisType.DateAsOrdinal;
            zedGraphControl1.GraphPane.XAxis.Scale.MaxAuto = true;

            curACurve = zedGraphControl1.GraphPane.AddCurve("电流A路", curAList, Color.DarkGreen, SymbolType.None);
            curBCurve = zedGraphControl1.GraphPane.AddCurve("电流A路", curBList, Color.DarkRed, SymbolType.None);
           // zedGraphControl1.
            this.zedGraphControl1.AxisChange();
            this.zedGraphControl1.Refresh();

           // ZedGraphTest();
            TimSysTime.Enabled = true;

            picBox1.Image = Resources.green;

            // 加载dll文件
            loadCpServerDll();

            //Button btn = new Button();
            //btn.Text = "控钮测试";
            //btn.Width = 40;
            //btn.Location = new Point(100, 100);
            //this.Controls.Add(btn);

            // 加入这行,容许跨线程访问控件
            Control.CheckForIllegalCrossThreadCalls = false;

            string name = "测试充电桩";
            foreach (TreeNode node in tvChargePile.Nodes) {
                if (node.Name != name) {
                    node.Nodes.Add(new TreeNode(name));
                    tvChargePile.ExpandAll();
                }
            }

            // 库测试
            CPGetState state = new CPGetState();
            state.cpFaultH = 0x02;
            state.cpFaultL = 0xaa;

            Console.WriteLine("voltage fault" + state.cpInOverVol);


        }
        
        // 接收到的数据格式如下---PC机一次性收一台老化车的整个数据。数据的整合在数据采集器中做
        //0xaa	起始字符高位
        //0x55  起始字符低位
        //Xx	数据长度（总长度）
        //Xx	源地址_主机号---指第几号老化车
        //xx    目标地址_PC机
        //xx    功能码

        //Xx	分机号---指老化车上第几号分机-总共六台分机
        //Xx	A路采样电流高位
        //Xx	A路采样电流低位
        //Xx	B路采样电流高位
        //Xx	B路采样电流低位
        //Xx	故障状态0
        //Xx	故障状态1
        //Xx	故障状态2
        //Xx	故障状态3---中间部分重复六次

        //Xx	校验和，高位。
        //Xx	校验和，低位。---8+9*6=62个数据     
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] byteArray = new byte[serialPort1.ReadBufferSize];        // 创建串口接收数据数组

            int len = serialPort1.Read(byteArray, 0, byteArray.Length);

            CPDataCheck dataCheck = new CPDataCheck();

            // 对接收到的数据进行预处理
            if (dataCheck.dataFirstCheck(byteArray,byteArray.Length))
            { //快速初步校验

                byte[] ubReceDataBuff = new byte[len];
                for (int i = 0; i < len; i++)
                {
                    ubReceDataBuff[i] = byteArray[i];
                }   // 把一帧数据暂存在ubReceiveDataBuffer数组中
                receiveByteQueue.Enqueue(ubReceDataBuff);//把数据放入队列中，先进先出
                blDataFlag = true;
            }
        }
       
        private void btnOpenPort_Click(object sender, EventArgs e) {
            /* 代码测试 */
            
            //int a =  10;
            //picBox1.Image = Properties.Resources.red;
            //txtCurrent.Text = a.ToString();
 
            if (btnOpenPort.Text == "打开串口") {
                //this.serialPort1.Open();//打开串口，用的是控件！

                this.btnOpenPort.Text = "关闭串口";
                //serialPort1.PortName = frmSetComPara.combSerialPort.Text;               //给出串口号，字符型

                serialPort1.PortName = "COM2";
                serialPort1.BaudRate = int.Parse(frmSetComPara.combBaudRate.Text);
                serialPort1.DataBits = int.Parse(frmSetComPara.combDataBit.Text);
                string szStopBits = frmSetComPara.combStopBits.SelectedItem.ToString();

                switch (szStopBits) {
                    case "1":
                        serialPort1.StopBits = StopBits.One;
                        break;
                    case "1.5":
                        serialPort1.StopBits = StopBits.OnePointFive;
                        break;
                    case "2":
                        serialPort1.StopBits = StopBits.Two;
                        break;
                    default:
                        serialPort1.StopBits = StopBits.One;
                        break;
                }
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), frmSetComPara.SerialParity.SelectedItem.ToString());
                //此句要好好理解。Enum  提供一个指向枚举器（该枚举器可枚举复合名字对象的组件）的指针。
                serialPort1.Open();
                return;
            }
            if (btnOpenPort.Text == "关闭串口") {
                serialPort1.Close();
                btnAutoCheck.Text = "自动查看";
                btnCheckChargeInfo.Text = "自动查看";
                this.btnOpenPort.Text = "打开串口";
            }
            if (serialPort1.IsOpen == true) {
                MessageBox.Show("串口已打开");
            } else {
                MessageBox.Show("串口已关闭");
            }
        }
        private void TS_BtnSetComPara_Click(object sender, EventArgs e)
        {
            SetComPara frmSetComParaDisply = new SetComPara();          //定义串口参数设置对象
            frmSetComParaDisply.Show();
        }
        private void TS_BtnOnOffSet_Click(object sender, EventArgs e)
        {
            OnOffSet frmOnOffSetDisply = new OnOffSet();

            frmOnOffSetDisply.Show();

        }
        private void TS_BtnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void TS_BtnOpenPort_Click(object sender, EventArgs e)
        {
            if (paraSetForm == null || paraSetForm.IsDisposed)    //对象为空或对象没有被占用
            {
                paraSetForm = new ParameterSet();
            }
            paraSetForm.Owner = this;
            paraSetForm.Show();
        }
        
        private void SendQueryMsg() {
            int mainId = lastScanMainDevNum;
            const int QUERY_MSG_NUM = 12;
            byte[] cScanCmd = new byte[QUERY_MSG_NUM];     // 设置数组，并进行初始化，保存发送数据数组
            MainDevice m = mainDev[mainId];     // 老化车泛型集合
            UInt16 uwCrcResult;                 // CRC校验
            if (m.isActive == false && lastScanMainDevCount < 2) {  // 这里设置每个老化车查询次数，当前3次，如果3次内成功，则不会重试
                lastScanMainDevCount++;
            } else {
                mainId++;                                           // 老化车查询计数变量
                if (mainId >= 4) {                                  // 设置轮询台数，这里假设只有4台，应该换成 NUM_OF_MAIN_DEVICE
                    mainId = 0;                                     // 清空状态，准备下一轮查询
                    for (int i = 0; i < NUM_OF_MAIN_DEVICE; i++) { // 20台老化车设备，在线状态清空
                        MainDevice md = mainDev[i];
                        md.isActive = false;                        // isActive---每一台老化车设备的状态，true则为设备在线
                    }
                }
                lastScanMainDevCount = 0;                           // 老化车查询计数清零
                lastScanMainDevNum = mainId;                        // 老化车号自加后再把值送给当前要查询的设备号
            }
            for (int i = 0; i < QUERY_MSG_NUM; i++) {
                cScanCmd[i] = 0x00;
            }   // 要发送的数据初始化                      
            cScanCmd[0] = 0xaa;             // 起始字符高位
            cScanCmd[1] = 0x55;             // 起始字符低位
            cScanCmd[2] = QUERY_MSG_NUM;    // 数据长度
            cScanCmd[3] = 0xff;             // 源地址(PC主机地址)
            cScanCmd[4] = (byte)(mainId+0x01);     // 目标地址-主机号，发送主机号到数据采样器，数据采集器由根据主机号去查询相应的主机。

            cScanCmd[5] = 0x01;             // 功能码
            cScanCmd[6] = 0x00;
            cScanCmd[7] = 0x00;
            cScanCmd[8] = 0x00;
            cScanCmd[9] = 0x00;
            CRC_16(cScanCmd, QUERY_MSG_NUM - 2, out uwCrcResult);   // 对前10个数作校验
            cScanCmd[10] = (byte)(uwCrcResult >> 8); ;               // 校验码高位
            cScanCmd[11] = (byte)uwCrcResult;                        // 校验码低位
            serialPort1.Write(cScanCmd, 0, QUERY_MSG_NUM);
        }
        private void TimeSendData_Tick(object sender, EventArgs e)// 轮询向分机请求数据定时器任务
        {
            if (bQueryMsgFlg == false) {
                SendQueryMsg();
                bQueryMsgFlg = true;
            }
            
        }        
        private void btnGetData_Click(object sender, EventArgs e)//轮询任务启动
        {
            if (btnGetData.Text == "扫描查询") {
                if (btnOpenPort.Text == "打开串口") {
                    MessageBox.Show("串口未打开，请打开串口");
                    return;
                }
                btnGetData.Text = "停止扫描";
                TimeSendData.Enabled = true;            // 打开定时器作扫描功能，向数据采集器发送扫描指令
            } else {
                btnGetData.Text = "扫描查询";
                TimeSendData.Enabled = false;           // 关闭定时器扫描功能，停止向数据采集器发送扫描指令 
            }
        }
        private void DealDisplayMsg(byte[] arr, int length)
        {
            int mainId = arr[3];            // 主机号
            MainDevice m = mainDev[mainId]; // 主机号对应的设备类
            m.isActive = true;              // 主机激活
            // 1、如果主机是第一次激活，要记录下此时的时间，作为开始工作时间
            // 2、用开始加上需要运行的时间，得到工作结束时间
            // 3、用系统此时时间减去开始工作时间得到已经工作时间
            // 4、用工作结束时间减去此时时间得到工作剩余时间

            //Console.WriteLine("MainID: {1}, len:{0}aa 55", length,mainId);
            
            double xTimeAxis = (double)new XDate(DateTime.Now);//使用当前时间作为X轴坐标

            for (int i = 0; i < 6; i++) {
                int subId = arr[6 + 9 * i + 0];
                int curA  = arr[6 + 9 * i + 1] << 8 | arr[6 + 9 * i + 2];
                int curB  = arr[6 + 9 * i + 3] << 8 | arr[6 + 9 * i + 4];
                int error = arr[6 + 9 * i + 8] << 24 | arr[6 + 9 * i + 7] << 16 | arr[6 + 9 * i + 6] << 8 | arr[6 + 9 * i + 5];
                SubDevice sub = m.DevList[subId];
                sub.CurrentAList.Add(xTimeAxis, curA);//A路电流值
                sub.CurrentBList.Add(xTimeAxis, curB);//B路电流值
                sub.EStatus = error;                  //故障点信息
                //txtCurrent.Text = curA.ToString();
            }
            m.iWorkCurrent = 1000;
            //m.iWorkCurrent = 1000;
            //txtBeginTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
        
        private int  packageParser(byte[] arr, int length)
        {
            if (arr == null) return -1;

            CPDataCheck dataCheck = new CPDataCheck();
            bool addressCheck = dataCheck.AddressCheck(arr);
            if (!addressCheck) return -1;
            bool lenCheck = dataCheck.DataLengthCheck(arr, 10);
            if (!lenCheck) return -1;

            byte bccCheckData = dataCheck.GetBCC_Check(arr, 10, arr.Length - 2);
            if ((bccCheckData == arr[length - 2])
               && (0xED == arr[length - 1])) {   // 参数校验正确
                switch (arr[11]) {
                    case 0x20: {
                        if (arr[13] == 0x00) {
                            Console.WriteLine("receive Charging pile heart frame command success.\n");
                            //heartStateLed.ForeColor = Color.Green;
                            heartLedTime.Enabled = true;
                        } else {
                            Console.WriteLine("receive Charging pile heart frame command fail.\n");
                            heartStateLed.ForeColor = Color.Red;
                            picBox1.Image = Resources.red;
                            heartLedTime.Enabled = false;
                        }
                        break;
                    }
                    case 0x21: {
                        if (arr[13] == 0x00) {
                            Console.WriteLine("receive set time command success.\n");
                            setTimeLed.ForeColor = Color.Green;
                        } else {
                            Console.WriteLine("receive set time command fail.\n");
                            setTimeLed.ForeColor = Color.Red;
                        }
                        break;
                    } 
                    case 0x22: {
                        if (arr[13] == 0x00) {
                            Console.WriteLine("receive set rate command success.\n");
                            setRateLed.ForeColor = Color.Green;
                        } else {
                            Console.WriteLine("receive set rate command fail.\n");
                            setRateLed.ForeColor = Color.Red;
                        }
                        break;
                    }
                    case 0x23: {
                        if (arr[13] == 0x00) {
                            Console.WriteLine("receive charging pile state command success.\n");
                            
                            cpStateLed.ForeColor = Color.Green;
                            // deal parameter message


                        } else {
                            Console.WriteLine("receive charging pile state command fail.\n");
                            cpStateLed.ForeColor = Color.Red;
                        }
                        break;
                    }
                    case 0x24: {
                        if (arr[13] == 0x00) {
                            Console.WriteLine("receive charging pile start and stop command success.\n");
                            cpStartLed.ForeColor = Color.Gray;
                            cpPauseLed.ForeColor = Color.Gray;
                            cpRecoverLed.ForeColor = Color.Gray;
                            cpStopLed.ForeColor = Color.Gray;
                            if (arr[14] == 0x01) {
                                cpStartLed.ForeColor = Color.Green;
                            } else if (arr[14] == 0x02) {
                                cpPauseLed.ForeColor = Color.Green;
                            } else if (arr[14] == 0x03) {
                                cpStopLed.ForeColor = Color.Green;
                            } else if (arr[14] == 0x22) {
                                cpRecoverLed.ForeColor = Color.Green;
                            }
                            
                        } else {
                            Console.WriteLine("receive charging pile start and stop command fail.\n");
                            cpStartLed.ForeColor = Color.Gray;
                            cpPauseLed.ForeColor = Color.Gray;
                            cpRecoverLed.ForeColor = Color.Gray;
                            cpStopLed.ForeColor = Color.Gray;
                            if (arr[14] == 0x01) {
                                cpStartLed.ForeColor = Color.Red;
                            } else if (arr[14] == 0x02) {
                                cpPauseLed.ForeColor = Color.Red;
                            } else if (arr[14] == 0x03) {
                                cpStopLed.ForeColor = Color.Red;
                            } else if (arr[14] == 0x22) {
                                cpRecoverLed.ForeColor = Color.Red;
                            }
                        }
                        break;
                    }
                    case 0x25: {
                        if (arr[13] == 0x00) {
                            Console.WriteLine("receive current charging info command success.\n");
                            
                            curChargeInfoLed.ForeColor = Color.Green;
                            
                            // deal parameter
                        } else {
                            Console.WriteLine("receive current charging info command fail.\n");

                            curChargeInfoLed.ForeColor = Color.Red;
                        }
                        break;    
                    }
                    default: {
                        break;
                    }
                }
                return 1;
            } else {
                return -1; 
            }
        }

        private bool checkStateFlg = true;
        private bool chargeInfoFlg = true;
        

        private void timeDealRevData_Tick(object sender, EventArgs e)   // 处理接收到的数据
        {
            if (true == blDataFlag) {   // 数据处理标志
                blDataFlag = false;

                int count = receiveByteQueue.Count;
                byte[] arr = (byte[])receiveByteQueue.Dequeue();//通过队列收到数据
                CPBackDataParse dataParser = new CPBackDataParse();
                dataParser = dataParser.packageParser(arr, arr.Length);

                if (dataParser.classType == CPBackDataParse.BackDataType.HeartFrameType) {
                    Console.WriteLine("class type is heartFrame!");
                    if (dataParser.cpGetHeartData.cpHeartFrameExecuteResult == true) {
                        Console.WriteLine("receive Charging pile heart frame command success.\n");
                        //heartStateLed.ForeColor = Color.Green;
                        heartLedTime.Enabled = true;
                    } else {
                        Console.WriteLine("receive Charging pile heart frame command fail.\n");
                        heartStateLed.ForeColor = Color.Red;
                        picBox1.Image = Resources.red;
                        heartLedTime.Enabled = false;
                    }
                }

                if (dataParser.classType == CPBackDataParse.BackDataType.SetTimeType) {
                    if (dataParser.cpGetTimeData.cpSetTimeExecuteResult == true) {
                        Console.WriteLine("receive set time command success.\n");
                        setTimeLed.ForeColor = Color.Green;
                    } else {
                        Console.WriteLine("receive set time command fail.\n");
                        setTimeLed.ForeColor = Color.Red;
                    }
                }

                if (dataParser.classType == CPBackDataParse.BackDataType.SetRateType) {
                    if (dataParser.cpGetRateData.cpSetRateExecuteResult == true) {
                        Console.WriteLine("receive set rate command success.\n");
                        setRateLed.ForeColor = Color.Green;
                    } else {
                        Console.WriteLine("receive set rate command fail.\n");
                        setRateLed.ForeColor = Color.Red;
                    }
                }

                if (dataParser.classType == CPBackDataParse.BackDataType.StateType) {

                    if (dataParser.cpGetStateData.cpGetStateExecuteResult == true) {
                        Console.WriteLine("receive charging pile state command success.\n");
                        cpStateLed.ForeColor = Color.Green;
                        // deal parameter message
                        txtValtage.Text = dataParser.dealParaChange(dataParser.cpGetStateData.cpVoltage);
                        txtCurrent.Text = dataParser.dealParaChange(dataParser.cpGetStateData.cpCurrent);

                        txtTotalElect.Text = dataParser.dealParaChange(dataParser.cpGetStateData.cpTotalElect);
                        txtPointElect.Text = dataParser.dealParaChange(dataParser.cpGetStateData.cpPointElect);
                        txtPeakElect.Text = dataParser.dealParaChange(dataParser.cpGetStateData.cpPeakElect);
                        txtFlatElect.Text = dataParser.dealParaChange(dataParser.cpGetStateData.cpFlatElect);
                        txtValleyElect.Text = dataParser.dealParaChange(dataParser.cpGetStateData.cpValleyElect);

                        txtChargeSoc.Text = dataParser.cpGetStateData.cpSpace1.ToString();
                        txtChargeTime.Text = dataParser.cpGetStateData.cpSpace2.ToString();
                        txtLeftTime.Text = dataParser.cpGetStateData.cpSpace3.ToString();

                        if (dataParser.cpGetStateData.cpEmergencyBtn == 0x00) {
                            lblStopLed.ForeColor = Color.Green;
                            lblStopState.Text = "正常";
                        } else {
                            lblStopLed.ForeColor = Color.Red;
                            lblStopState.Text = "按下";
                        }

                        if (dataParser.cpGetStateData.cpMeterState == 0x00) {
                            lblElectLed.ForeColor = Color.Green;
                            lblElectState.Text = "通信正常";
                        } else {
                            lblElectLed.ForeColor = Color.Red;
                            lblElectState.Text = "通信异常";
                        }

                        if (dataParser.cpGetStateData.cpChargePlug == 0x00) {
                            lblPlugLed.ForeColor = Color.Green;
                            lblPlugState.Text = "插好";
                        } else {
                            lblPlugLed.ForeColor = Color.Red;
                            lblPlugState.Text = "没准备好";
                        }

                        if (dataParser.cpGetStateData.cpOutState == 0x00) {
                            lblCurLed.ForeColor = Color.Green;
                            lblCurState.Text = "有输出";
                        } else {
                            lblCurLed.ForeColor = Color.Red;
                            lblCurState.Text = "无输出";
                        }

                        checkStateFlg = true;
                        

                    } else {
                        Console.WriteLine("receive charging pile state command fail.\n");
                        cpStateLed.ForeColor = Color.Red;
                    }
                }


                if (dataParser.classType == CPBackDataParse.BackDataType.StartupType) {

                    if (dataParser.cpGetStartupData.cpControlExecuteResult == true) {
                        Console.WriteLine("receive charging pile start and stop command success.\n");
                        cpStartLed.ForeColor = Color.Gray;
                        cpPauseLed.ForeColor = Color.Gray;
                        cpRecoverLed.ForeColor = Color.Gray;
                        cpStopLed.ForeColor = Color.Gray;
                        if (dataParser.cpGetStartupData.cpWorkState == CPGetStartup.CP_WORK_STATE.cpStartWork) {
                            cpStartLed.ForeColor = Color.Green;
                        } else if (dataParser.cpGetStartupData.cpWorkState == CPGetStartup.CP_WORK_STATE.cpPauseWork) {
                            cpPauseLed.ForeColor = Color.Green;
                        } else if (dataParser.cpGetStartupData.cpWorkState == CPGetStartup.CP_WORK_STATE.cpStopWork) {
                            cpStopLed.ForeColor = Color.Green;
                        } else if (dataParser.cpGetStartupData.cpWorkState == CPGetStartup.CP_WORK_STATE.cpRecoverWork) {
                            cpRecoverLed.ForeColor = Color.Green;
                        }

                    } else {
                        Console.WriteLine("receive charging pile start and stop command fail.\n");
                        cpStartLed.ForeColor = Color.Gray;
                        cpPauseLed.ForeColor = Color.Gray;
                        cpRecoverLed.ForeColor = Color.Gray;
                        cpStopLed.ForeColor = Color.Gray;
                        if (dataParser.cpGetStartupData.cpWorkState == CPGetStartup.CP_WORK_STATE.cpStartWork) {
                            cpStartLed.ForeColor = Color.Red;
                        } else if (dataParser.cpGetStartupData.cpWorkState == CPGetStartup.CP_WORK_STATE.cpPauseWork) {
                            cpPauseLed.ForeColor = Color.Red;
                        } else if (dataParser.cpGetStartupData.cpWorkState == CPGetStartup.CP_WORK_STATE.cpStopWork) {
                            cpStopLed.ForeColor = Color.Red;
                        } else if (dataParser.cpGetStartupData.cpWorkState == CPGetStartup.CP_WORK_STATE.cpRecoverWork) {
                            cpRecoverLed.ForeColor = Color.Red;
                        }
                    }
                }

                if (dataParser.classType == CPBackDataParse.BackDataType.CurInfoType) {

                    if (dataParser.cpGetCurInfoData.cpGetCurInfoExecuteResult) {
                        Console.WriteLine("receive current charging info command success.\n");

                        curChargeInfoLed.ForeColor = Color.Green;

                        // deal parameter

                        txtCurTotalElect.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpChargeTotalElect);
                        txtCurTotalCost.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpChargeTotalPrice);

                        txtCurPointElect.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpChargePointElect);
                        txtCurPeakElect.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpChargePeakElect);
                        txtCurFlatElect.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpChargeFlatElect);
                        txtCurValleyElect.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpChargeValleyElect);

                        txtCurPointPrice.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpPointElectPrice);
                        txtCurPeakPrice.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpPeakElectPrice);
                        txtCurFlatPrice.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpFlatElectPrice);
                        txtCurValleyPrice.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpValleyElectPrice);

                        txtCurPointCost.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpPointCost);
                        txtCurPeakCost.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpPeakCost);
                        txtCurFlatCost.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpFlatCost);
                        txtCurValleyCost.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpValleyCost);

                        chargeInfoFlg = true;

                        if (btnCheckChargeInfo.Text == "停止查看") {
                            //chargeInfoTime.Enabled = true;
                        }
                        
                    } else {
                        Console.WriteLine("receive current charging info command fail.\n");

                        curChargeInfoLed.ForeColor = Color.Red;
                    }
                }
                //int status = packageParser(arr, arr.Length);
            }
        }
        private void sendHeartFrameData(byte cmdCode)
        {

            //CPSendDataPackage sendDataPack = new CPSendDataPackage();

            if (txtChargingPileAddress.Text != "") {
                //UInt64 temp = Convert.ToUInt64(txtChargingPileAddress.Text);

                //byte[] sendData = sendDataPack.sendDataPackage(cmdCode,temp);
                //serverSocket.Send(sendData, sendData.Length, 0);
                if (true == serialPort1.IsOpen) {
                    //serialPort1.Write(sendData, 0, sendData.Length);
                }
                if (btnListen.Text == "关闭监听") {
                    // 打开了监听
                   // UInt64 address = Convert.ToUInt64(txtChargingPileAddress.Text);
                    /*
                    for (int i = 0; i < cpDevice.Count; i++) {
                        if (cpDevice[i].chargePileMachineAddress == address) {
                            cpDevice[i].clientSocket.Send(sendData,sendData.Length,0);
                        }
                    }*/
                    UInt64 address = Convert.ToUInt64(txtChargingPileAddress.Text);
                    chargePileDataList.sendDataToChargePile(cmdCode, address);
                    /*
                    for (int i = 0; i < chargePileData.cpDataPacket.Count; i++) {
                        Console.WriteLine("连接成功的机器地址为" + chargePileData.cpDataPacket[i].chargePileData.cpAddress);
                        if (chargePileData.cpDataPacket[i].chargePileData.cpAddress == address) {
                            chargePileData.cpDataPacket[i].clientSocket.Send(sendData, sendData.Length, 0);

                            IPAddress ip = ((System.Net.IPEndPoint)chargePileData.cpDataPacket[i].clientSocket.RemoteEndPoint).Address;
                            int port = ((System.Net.IPEndPoint)chargePileData.cpDataPacket[i].clientSocket.RemoteEndPoint).Port;
                            Console.WriteLine("我是服务器，检测到的客户端ip是：" + ip);
                            Console.WriteLine("端口号是：" + port);
                            Console.WriteLine("服务器发送数据成功---机器地址为" + address);
                        }
                    }*/
                }
            } else {

                //byte[] sendData = sendDataPack.sendDataPackage(cmdCode);
                //Socket clientSocket = serverSocket.Accept();
                //clientSocket.Send(sendData, sendData.Length, 0);
                if (true == serialPort1.IsOpen) {
                    //serialPort1.Write(sendData, 0, sendData.Length);
                }
                if (btnListen.Text == "关闭监听") {
                    // 打开了监听
                    UInt64 address = 0x1122334455667788;
                    /*
                    for (int i = 0; i < cpDevice.Count; i++) {
                        if (cpDevice[i].chargePileMachineAddress == address) {
                            cpDevice[i].clientSocket.Send(sendData,sendData.Length,0);
                        }
                    }*/
                    for (int i = 0; i < cpDataPacket.Count; i++) {
                        if (cpDataPacket[i].chargePileData.cpAddress == address) {
                            //cpDataPacket[i].clientSocket.Send(sendData, sendData.Length, 0);
                        }
                    }
                }
            }
            
        }
         
        
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView tv = (TreeView)sender;
            int num = tv.SelectedNode.Index + 1;
        }
        
        private void zedGraphControl1_Load(object sender, EventArgs e) 
        {

        }
        /// <summary>
        /// ZedGraph动态曲线初始化函数1，定时器此时默认使能状态，调试用
        /// </summary>
        private void ZedGraphTest()
        {
            double y = 5;
            double k = 5;
            for (int i = 0; i <= 1000; i++) {
                double x = (double)new XDate(DateTime.Now.AddSeconds(-(1000 - i)));
                // double y = ran.NextDouble();
                curAList.Add(x, (y++)%10);
                curBList.Add(x, (k++)%15); 
            }
            DateTime dt = DateTime.Now;
        }

        private void TimSysTime_Tick(object sender, EventArgs e) {
            DateTime dt = DateTime.Now;
            TS_LableSystemTime.Text = dt.ToString();
        }

        private void heartTime_Tick(object sender, EventArgs e)
        {
            if (btnOpenPort.Text == "打开串口") {
                return;
            }
            // send heart frame
            sendHeartFrameData(0x20);
        }
        
        private void btnHeartFrame_Click(object sender, EventArgs e)
        {
            sendHeartFrameData(0x20);
        }
        /* set charging pile time
         * this command cannot be sent when charging pile are charging
         */
        private byte ConvertBCD(string str) {
            return Convert.ToByte(str);
        } 
        private void sendSetTimeData(byte cmdCode)
        {

            //CPSendDataPackage sendDataPack = new CPSendDataPackage();

            CPSetSendDataTime sendTimeData = new CPSetSendDataTime();
            if (cbSystemTime.Checked) {
                sendTimeData.year = DateTime.Now.Year.ToString();
                sendTimeData.month = DateTime.Now.Month.ToString();
                sendTimeData.day = DateTime.Now.Day.ToString();
                sendTimeData.hour = DateTime.Now.Hour.ToString();
                sendTimeData.minute = DateTime.Now.Minute.ToString();
                sendTimeData.second = DateTime.Now.Second.ToString();
            } else {
                if (txtHour.Text == "") {
                    MessageBox.Show("请输入小时数!");
                    return;
                }
                if (txtMinute.Text == "") {
                    MessageBox.Show("请输入分钟数!");
                    return;
                }
                if (txtSecond.Text == "") {
                    MessageBox.Show("请输入秒数!");
                    return;
                }
                sendTimeData.year = dateTimeSet.Value.Year.ToString();
                sendTimeData.month = dateTimeSet.Value.Month.ToString();
                sendTimeData.day = dateTimeSet.Value.Day.ToString();

                Console.WriteLine(dateTimeSet.Value.Year.ToString());
                Console.WriteLine(dateTimeSet.Value.Month.ToString());
                Console.WriteLine(dateTimeSet.Value.Day.ToString());
                sendTimeData.hour = txtHour.Text;
                sendTimeData.minute = txtMinute.Text;
                sendTimeData.second = txtSecond.Text;
            }

            UInt64 address = Convert.ToUInt64(txtChargingPileAddress.Text);

            chargePileDataList.sendDataToChargePile(cmdCode, address, sendTimeData);

            if (txtChargingPileAddress.Text != "") {
                UInt64 temp = Convert.ToUInt64(txtChargingPileAddress.Text);
               // byte[] sendData = sendDataPack.sendTimeDataPackage(cmdCode, sendTimeData,temp);

                if (true == serialPort1.IsOpen) {
                   // serialPort1.Write(sendData, 0, sendData.Length);
                }

                if (btnListen.Text == "关闭监听") {
                    // 打开了监听
                   /* UInt64 address = Convert.ToUInt64(txtChargingPileAddress.Text);
                    
                    for (int i = 0; i < cpDevice.Count; i++) {
                        if (cpDevice[i].chargePileMachineAddress == address) {
                            cpDevice[i].clientSocket.Send(sendData,sendData.Length,0);
                        }
                    }
                    for (int i = 0; i < cpDevice.Count; i++) {
                        if (cpDataPacket[i].chargePileData.cpAddress == address) {
                            cpDataPacket[i].clientSocket.Send(sendData, sendData.Length, 0);
                        }
                    }*/
                    
                }


            } else {
               // byte[] sendData = sendDataPack.sendTimeDataPackage(cmdCode, sendTimeData);
                if (true == serialPort1.IsOpen) {
                    //serialPort1.Write(sendData, 0, sendData.Length);
                }
                if (btnListen.Text == "关闭监听") {
                    // 打开了监听
                    /* UInt64 address = 0x1122334455667788;
                   
                    for (int i = 0; i < cpDevice.Count; i++) {
                        if (cpDevice[i].chargePileMachineAddress == address) {
                            cpDevice[i].clientSocket.Send(sendData,sendData.Length,0);
                        }
                    }
                    for (int i = 0; i < cpDevice.Count; i++) {
                        if (cpDataPacket[i].chargePileData.cpAddress == address) {
                            cpDataPacket[i].clientSocket.Send(sendData, sendData.Length, 0);
                        }
                    }*/
                }
            }

            
        }
        private void btnSetTime_Click(object sender, EventArgs e)
        {
            sendSetTimeData(0x21);
        }
        /* set rate
         * this command cannot be sent when charging pile are charging
         */
        private void sendRateData(byte cmdCode)
        {

            if (txtRatePointPrice.Text == "") {
                MessageBox.Show("请输入尖电价!");
                return;
            }
            if (txtRatePeakPrice.Text == "") {
                MessageBox.Show("请输入峰电价!");
                return;
            }
            if (txtRateFlatPrice.Text == "") {
                MessageBox.Show("请输入平电价!");
                return;
            }
            if (txtRateValleyPrice.Text == "") {
                MessageBox.Show("请输入谷电价!");
                return;
            }
            
            
            
            CPSendDataPackage sendDataPack = new CPSendDataPackage();

            CPSetSendDataRate sendRataData = new CPSetSendDataRate();

//             sendRataData.cpPointPrice = Convert.ToUInt32(txtRatePointPrice.Text);
//             sendRataData.cpPeakPrice = Convert.ToUInt32(txtRatePeakPrice.Text);
//             sendRataData.cpFlatPrice = Convert.ToUInt32(txtRateFlatPrice.Text);
//             sendRataData.cpVallPrice = Convert.ToUInt32(txtRateValleyPrice.Text);


            UInt64 address = Convert.ToUInt64(txtChargingPileAddress.Text);
            chargePileDataList.sendDataToChargePile(cmdCode, address, sendRataData);
            
            if (txtChargingPileAddress.Text != "") {
                UInt64 temp = Convert.ToUInt64(txtChargingPileAddress.Text);

                byte[] sendData = sendDataPack.sendRateDataPackage(cmdCode, sendRataData,temp);

                if (true == serialPort1.IsOpen) {

                    serialPort1.Write(sendData, 0, sendData.Length);
                }
                if (btnListen.Text == "关闭监听") {
                    // 打开了监听
                    //UInt64 address = Convert.ToUInt64(txtChargingPileAddress.Text);
                    /*
                    for (int i = 0; i < cpDevice.Count; i++) {
                        if (cpDevice[i].chargePileMachineAddress == address) {
                            cpDevice[i].clientSocket.Send(sendData,sendData.Length,0);
                        }
                    }
                    for (int i = 0; i < cpDevice.Count; i++) {
                        if (cpDataPacket[i].chargePileData.cpAddress == address) {
                            cpDataPacket[i].clientSocket.Send(sendData, sendData.Length, 0);
                        }
                    }*/
                }
            } else {
                byte[] sendData = sendDataPack.sendRateDataPackage(cmdCode, sendRataData);
                if (true == serialPort1.IsOpen) {
                    serialPort1.Write(sendData, 0, sendData.Length);
                }
                if (btnListen.Text == "关闭监听") {
                    // 打开了监听
                   /* UInt64 address = 0x1122334455667788;
                    
                    for (int i = 0; i < cpDevice.Count; i++) {
                        if (cpDevice[i].chargePileMachineAddress == address) {
                            cpDevice[i].clientSocket.Send(sendData,sendData.Length,0);
                        }
                    }
                    for (int i = 0; i < cpDevice.Count; i++) {
                        if (cpDataPacket[i].chargePileData.cpAddress == address) {
                            cpDataPacket[i].clientSocket.Send(sendData, sendData.Length, 0);
                        }
                    }*/
                }

            }

            

            

            
        }
        private void btnSetPrice_Click(object sender, EventArgs e)
        {
            //sendRateData(0x22);
            if (txtRatePointPrice.Text == "") {
                MessageBox.Show("请输入尖电价!");
                return;
            }
            if (txtRatePeakPrice.Text == "") {
                MessageBox.Show("请输入峰电价!");
                return;
            }
            if (txtRateFlatPrice.Text == "") {
                MessageBox.Show("请输入平电价!");
                return;
            }
            if (txtRateValleyPrice.Text == "") {
                MessageBox.Show("请输入谷电价!");
                return;
            }
            //CPSendDataPackage sendDataPack = new CPSendDataPackage();

            CPSetSendDataRate sendRataData = new CPSetSendDataRate();
            try {
                sendRataData.cpPointPriceD = Convert.ToDouble(txtRatePointPrice.Text);
                sendRataData.cpPeakPriceD = Convert.ToDouble(txtRatePeakPrice.Text);
                sendRataData.cpFlatPriceD = Convert.ToDouble(txtRateFlatPrice.Text);
                sendRataData.cpVallPriceD = Convert.ToDouble(txtRateValleyPrice.Text);
            } catch (Exception ex) {
                MessageBox.Show("输入数据有误！{0}",ex.Message);
            }
            

            if (txtChargingPileAddress.Text == "") {
                return;
            }
            UInt64 temp = Convert.ToUInt64(txtChargingPileAddress.Text);

            chargePileDataList.sendDataToChargePile(0x22, temp,sendRataData);
            
            
        }
        private void sendCPStateData(byte cmdCode)
        {
            sendHeartFrameData(cmdCode);
        }
        private void btnCPState_Click(object sender, EventArgs e)
        {
            //sendCPStateData(0x23);
            UInt64 address = Convert.ToUInt64(txtChargingPileAddress.Text);
            chargePileDataList.sendDataToChargePile(0x23, address);
        }
        private void sendCPStartAndStopData(byte cmdCode,byte para)
        {
            //const int QUERY_MSG_NUM = 15;
            //byte[] bRequestCmd = new byte[QUERY_MSG_NUM];     // 设置数组，并进行初始化，保存发送数据数组

            //CPDataCheck dataCheck = new CPDataCheck();
            //UInt64 cpAddress = dataCheck.CHARGING_PILE_ADDRESS;

            //for (int i = 0; i < QUERY_MSG_NUM; i++)
            //{
            //    bRequestCmd[i] = 0x00;
            //}   // 要发送的数据初始化                      
            //bRequestCmd[0] = 0xff;             // 起始字符高位
            //bRequestCmd[1] = 0x5a;             // 起始字符低位
            //// 充电桩地址
            //bRequestCmd[2] = (byte)(cpAddress >> 56);
            //bRequestCmd[3] = (byte)(cpAddress >> 48);
            //bRequestCmd[4] = (byte)(cpAddress >> 40);
            //bRequestCmd[5] = (byte)(cpAddress >> 32);
            //bRequestCmd[6] = (byte)(cpAddress >> 24); ;
            //bRequestCmd[7] = (byte)(cpAddress >> 16); ;
            //bRequestCmd[8] = (byte)(cpAddress >> 8); ;
            //bRequestCmd[9] = (byte)(cpAddress); ;
            
            //bRequestCmd[10] = 0x04;               // frame length
            //bRequestCmd[11] = cmdCode;            // commade code--heart frame commade

            //// parameter
            //bRequestCmd[12] = para; 
            //// frame tail
            //bRequestCmd[13] = dataCheck.GetBCC_Check(bRequestCmd, 10, bRequestCmd.Length - 2); // bcc校验
            //bRequestCmd[14] = 0xed;

            CPSendDataPackage sendDataPack = new CPSendDataPackage();

            if (txtChargingPileAddress.Text != "") {
                UInt64 temp = Convert.ToUInt64(txtChargingPileAddress.Text);
                byte[] sendData = sendDataPack.sendCPStartupPackage(cmdCode, para, temp);
                if (true == serialPort1.IsOpen) {
                    serialPort1.Write(sendData, 0, sendData.Length);
                } else {
                    MessageBox.Show("串口未打开，请打开串口");
                }
            } else {
                byte[] sendData = sendDataPack.sendCPStartupPackage(cmdCode, para);
                if (true == serialPort1.IsOpen) {
                    serialPort1.Write(sendData, 0, sendData.Length);
                } else {
                    MessageBox.Show("串口未打开，请打开串口");
                }
            }
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            // 0x01,start charge
            // 0x02,pause charge
            // 0x03,stop charge
            // 0x22,recover charge
            sendCPStartAndStopData(0x24,0x01);
        }
        private void sendCurChargeData(byte cmdCode)
        {
            sendHeartFrameData(cmdCode);
        }
        private void btnCurCharge_Click(object sender, EventArgs e)
        {
            //sendCurChargeData(0x25);
            UInt64 address = Convert.ToUInt64(txtChargingPileAddress.Text);
            chargePileDataList.sendDataToChargePile(0x25, address);
        }

        private void btnPause_Click(object sender, EventArgs e) {
            // 0x01,start charge
            // 0x02,pause charge
            // 0x03,stop charge
            // 0x22,recover charge
            sendCPStartAndStopData(0x24, 0x02);
        }

        private void btnRecover_Click(object sender, EventArgs e) {
            // 0x01,start charge
            // 0x02,pause charge
            // 0x03,stop charge
            // 0x22,recover charge
            sendCPStartAndStopData(0x24, 0x22);
        }

        private void btnStop_Click(object sender, EventArgs e) {
            // 0x01,start charge
            // 0x02,pause charge
            // 0x03,stop charge
            // 0x22,recover charge
            sendCPStartAndStopData(0x24, 0x03);
        }

        private void 串口设置ToolStripMenuItem_Click(object sender, EventArgs e) {
            SetComPara frmSetComParaDisply = new SetComPara();          //定义串口参数设置对象
            frmSetComParaDisply.Show();
        }

        private void TSBtnExist_Click(object sender, EventArgs e) {
            System.Windows.Forms.Application.Exit();
            //Application.Exit();
        }

        private bool checkStateThreadFlg = false;

        private void autoCheckState() {
            while (checkStateThreadFlg) {
                if (false == serialPort1.IsOpen) {
                    checkStateThreadFlg = false;
                    //btnAutoCheck.Text = "自动查看";
                    return;
                }
                sendCPStateData(0x23);
                Thread.Sleep(1000);
            }
        }
        private void btnAutoCheck_Click(object sender, EventArgs e) {

            if (btnAutoCheck.Text == "自动查看") {
                btnAutoCheck.Text = "停止查看";
                checkStateThreadFlg = true;
                Thread myThread = new Thread(autoCheckState);
                myThread.Start();

                return;
            }
            if (btnAutoCheck.Text == "停止查看") {
                btnAutoCheck.Text = "自动查看";
                checkStateThreadFlg = false;
            }
        }
        
        private uint checkErrorCnt = 0;
        private void checkStateTime_Tick(object sender, EventArgs e) {

            //if (false == serialPort1.IsOpen) {
            //    checkStateTime.Enabled = false;
            //    btnAutoCheck.Text = "自动查看";
            //    return;
            //}

            //if (false == checkStateFlg) {
            //    checkErrorCnt++;
            //    if (checkErrorCnt > 2) {
            //        checkStateFlg = true;
            //        checkErrorCnt = 0;
            //    }
            //} else {
            //    checkErrorCnt = 0;
            //}

            //if (checkStateFlg) {
            //    sendCPStateData(0x23);
            //    checkStateFlg = false;
            //}
        }
        private bool checkChargeInfoThreadFlg = false;

        private void autoCheckChargeInfo() {
            while (checkChargeInfoThreadFlg) {
                if (false == serialPort1.IsOpen) {
                    checkChargeInfoThreadFlg = false;
                    //btnCheckChargeInfo.Text = "自动查看";
                    return;
                }
                sendCurChargeData(0x25);
                Thread.Sleep(1000);
            }
        }
        private void btnCheckChargeInfo_Click(object sender, EventArgs e) {
            if (btnCheckChargeInfo.Text == "自动查看") {
                btnCheckChargeInfo.Text = "停止查看";
                Thread myThread = new Thread(autoCheckChargeInfo);
                myThread.Start();
                checkChargeInfoThreadFlg = true;
                //chargeInfoTime.Enabled = true;
                return;
            }
            if (btnCheckChargeInfo.Text == "停止查看") {
                btnCheckChargeInfo.Text = "自动查看";
                checkChargeInfoThreadFlg = false;
                //chargeInfoTime.Enabled = false;
            }

        }
        private uint chargeInfoErrorCnt = 0;
 
        static bool ledStateFlg = true;
        private void heartLedTime_Tick(object sender, EventArgs e) {

            if (ledStateFlg) {
                heartStateLed.ForeColor = Color.Green;
                picBox1.Image = Resources.green32;
                ledStateFlg = false;
            } else {
                heartStateLed.ForeColor = Color.Gray;
                picBox1.Image = Resources.grey32;
                ledStateFlg = true;
            }

            
        }

        #region scoket listen
        private static byte[] result = new byte[1024];
        private static int myProt = 8885;   //端口
        static Socket serverSocket;
        static Socket clientSocket;
        //ChargePileDevice chargePile = null;
        chargePileDataPacketList chargePileDataList = null;
        private void btnListen_Click(object sender, EventArgs e) {
            if (btnListen.Text == "打开监听") {
                btnListen.Text = "关闭监听";
                //ChargePileDevice chargePile = new ChargePileDevice();
                //CPGetHeartFrame heart = new CPGetHeartFrame();
                //chargePileDataPacket chargePileData = new chargePileDataPacket();
                if (chargePileDataList == null) {
                    chargePileDataList = new chargePileDataPacketList();
                }
                //Thread myThread = new Thread(dealData);
                //myThread.Start(chargePileData);
                /*
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(ip, myProt));  //绑定IP地址：端口
                serverSocket.Listen(100);    //设定最多100个排队连接请求
                // 通过Clientsoket发送数据
                //clientSocket = serverSocket.Accept();
                Thread myThread = new Thread(ListenClientConnect);
                myThread.Start();
                */
                return;
            } else {
                btnListen.Text = "打开监听";
                chargePileDataList = null;
            }
            
        }
        private void dealData(object chargePileData) {
            chargePileDataPacket myData = (chargePileDataPacket)chargePileData;
            while (true) {
                if (myData.isActive) {
                    // 接收数据成功
                    // 
                    Console.WriteLine("dealData接收数据成功---myData" + myData.chargePileData.cpAddress);
                    // 处理成功cpDataPacket
                    if (false == updataDeviceList(myData)) {
                        cpDataPacket.Add(myData);
                        for (int i = 0; i < cpDataPacket.Count; i++) {
                            
                        }
                    } 
                    myData.isActive = false;
                }
                Thread.Sleep(500);

            }

        }
        private bool updataDeviceList(chargePileDataPacket newDevice) {
            for (int i = 0; i < cpDataPacket.Count; i++) {
                if (newDevice.chargePileData.cpAddress == cpDataPacket[i].chargePileData.cpAddress) {
                    cpDataPacket[i] = newDevice;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 监听客户端连接
        /// </summary>
        private void ListenClientConnect() {
            while (true) {
                clientSocket = serverSocket.Accept();
                IPAddress ip = ((System.Net.IPEndPoint)clientSocket.RemoteEndPoint).Address;
                int port = ((System.Net.IPEndPoint)clientSocket.RemoteEndPoint).Port;
                Console.WriteLine("我是服务器，检测到的客户端ip是：" + ip);
                Console.WriteLine("端口号是：" + port);
                Thread receiveThread = new Thread(ReceiveMessage);
                receiveThread.Start(clientSocket);
            }
        }
        
        private void updateFrameTimer_Tick(object sender, EventArgs e) {

            if (chargePileDataList != null) {
                //Console.WriteLine("接收到了数据！");
                for (int i = 0; i < chargePileDataList.cpDataPacket.Count; i++) {
                    chargePileDataPacket data = chargePileDataList.cpDataPacket[i];
 
                    CPGetState.CPCurrentState CurrentState = data.CurrentState;
                    byte CommState = data.CommState;
                    float CurrentSOC = data.CurrentSOC;
                    int ChargeTime = data.ChargeTime;
                    int RemainTime = data.RemainTime;

                    float CurrentVOL = data.CurrentVOL;
                    float CurrentCur = data.CurrentCur;
                    float OutPower = data.OutPower;
                    float OutQuantity = data.OutQuantity;
                    int ACCTime = data.ACCTime;
                    bool[] CurrentAlarmInfo = data.CurrentAlarmInfo;

                    float TotalQuantity = data.TotalQuantity;
                    float TotalFee = data.TotalFee;
                    //Console.WriteLine("--------------TotalFee----------" + TotalFee);
                    float JianQ = data.JianQ;
                    float JianPrice = data.JianPrice;
                    float JianFee = data.JianFee;
                    float fengQ = data.fengQ;
                    float fengPrice = data.fengPrice;
                    float fengFee = data.fengFee;

                    float PingQ = data.PingQ;
                    float PingPrice = data.PingPrice;
                    float PingFee = data.PingFee;

                    float GUQ = data.GUQ;
                    float GUPrice = data.GUPrice;
                    float GUFee = data.GUFee;

                    // 以下数据采用默认值
                    float BatterySoc = data.BatterySoc;
                    bool BMSState = data.BMSState;
                    float PortVol = data.PortVol;
                    int CellNum = data.CellNum;
                    int TempNum = data.TempNum;
                    float MaxVol = data.MaxVol;
                    float MaxCTemp = data.MaxCTemp;
                    float CellMaxVol = data.CellMaxVol;
                    int CellPos = data.CellPos;
                    float CellMinVol = data.CellMinVol;
                    int CellMinVolPos = data.CellMinVolPos;
                    float MaxTemp = data.MaxTemp;
                    float MinTemp = data.MinTemp;
                    bool VolDataAlarm = data.VolDataAlarm;
                    bool SampleVolFault = data.SampleVolFault;
                    bool UvorOvAlarm = data.UvorOvAlarm;
                    bool SystemParaAlarm = data.SystemParaAlarm;
                    bool FanFailFault = data.FanFailFault;
                    bool SampleTempFault = data.SampleTempFault;/**/
                }

            }
        }
        /// <summary>
        /// 接收消息
        /// </summary>
        /// <param name="clientSocket"></param>
        /// 
#region 接收数据

        private void ReceiveMessage(object clientSocket) {
            Socket myClientSocket = (Socket)clientSocket;
            while (true) {
                try {
                    // 通过clientSocket接收数据
                    int receiveNumber = myClientSocket.Receive(result);

                    byte[] tempArray = new byte[receiveNumber];
                    for (int i = 0; i < receiveNumber; i++) {
                        tempArray[i] = result[i];
                    }

                    CPBackDataParse dataParser = new CPBackDataParse();

                    dataParser = dataParser.packageParser(tempArray, receiveNumber);

                    if (dataParser != null) {
                        ChargePileDevice device = new ChargePileDevice();

                        device.chargePileData = dataParser;
                        device.isActive = true;
                        device.chargePileIPAddress = ((System.Net.IPEndPoint)myClientSocket.RemoteEndPoint).Address;
                        device.chargePilePort = ((System.Net.IPEndPoint)myClientSocket.RemoteEndPoint).Port;
                        device.chargePileMachineAddress = dataParser.cpAddress;
                        device.clientSocket = myClientSocket;
                        //if (false == updataDeviceList(device)) {
                       //     cpDevice.Add(device);
                        //}
                        


                    }
                    if (dataParser.classType == CPBackDataParse.BackDataType.HeartFrameType) {
                        Console.WriteLine("class type is heartFrame!");
                        if (dataParser.cpGetHeartData.cpHeartFrameExecuteResult == true) {
                            Console.WriteLine("receive Charging pile heart frame command success.\n");
                            //heartStateLed.ForeColor = Color.Green;
                            heartLedTime.Enabled = true;
                        } else {
                            Console.WriteLine("receive Charging pile heart frame command fail.\n");
                            heartStateLed.ForeColor = Color.Red;
                            picBox1.Image = Resources.red;
                            heartLedTime.Enabled = false;
                        }
                    }

                    if (dataParser.classType == CPBackDataParse.BackDataType.SetTimeType) {
                        if (dataParser.cpGetTimeData.cpSetTimeExecuteResult == true) {
                            Console.WriteLine("receive set time command success.\n");
                            setTimeLed.ForeColor = Color.Green;
                        } else {
                            Console.WriteLine("receive set time command fail.\n");
                            setTimeLed.ForeColor = Color.Red;
                        }
                    }

                    if (dataParser.classType == CPBackDataParse.BackDataType.SetRateType) {
                        if (dataParser.cpGetRateData.cpSetRateExecuteResult == true) {
                            Console.WriteLine("receive set rate command success.\n");
                            setRateLed.ForeColor = Color.Green;
                        } else {
                            Console.WriteLine("receive set rate command fail.\n");
                            setRateLed.ForeColor = Color.Red;
                        }
                    }
                    if (dataParser.classType == CPBackDataParse.BackDataType.StateType) {

                        if (dataParser.cpGetStateData.cpGetStateExecuteResult == true) {
                            Console.WriteLine("receive charging pile state command success.\n");
                            cpStateLed.ForeColor = Color.Green;
                            // deal parameter message
                            txtValtage.Text = dataParser.dealParaChange(dataParser.cpGetStateData.cpVoltage);
                            txtCurrent.Text = dataParser.dealParaChange(dataParser.cpGetStateData.cpCurrent);

                            txtTotalElect.Text = dataParser.dealParaChange(dataParser.cpGetStateData.cpTotalElect);
                            txtPointElect.Text = dataParser.dealParaChange(dataParser.cpGetStateData.cpPointElect);
                            txtPeakElect.Text = dataParser.dealParaChange(dataParser.cpGetStateData.cpPeakElect);
                            txtFlatElect.Text = dataParser.dealParaChange(dataParser.cpGetStateData.cpFlatElect);
                            txtValleyElect.Text = dataParser.dealParaChange(dataParser.cpGetStateData.cpValleyElect);

                            txtChargeSoc.Text = dataParser.cpGetStateData.cpSpace1.ToString();
                            txtChargeTime.Text = dataParser.cpGetStateData.cpSpace2.ToString();
                            txtLeftTime.Text = dataParser.cpGetStateData.cpSpace3.ToString();

                            if (dataParser.cpGetStateData.cpEmergencyBtn == 0x00) {
                                lblStopLed.ForeColor = Color.Green;
                                lblStopState.Text = "正常";
                            } else {
                                lblStopLed.ForeColor = Color.Red;
                                lblStopState.Text = "按下";
                            }

                            if (dataParser.cpGetStateData.cpMeterState == 0x00) {
                                lblElectLed.ForeColor = Color.Green;
                                lblElectState.Text = "通信正常";
                            } else {
                                lblElectLed.ForeColor = Color.Red;
                                lblElectState.Text = "通信异常";
                            }

                            if (dataParser.cpGetStateData.cpChargePlug == 0x00) {
                                lblPlugLed.ForeColor = Color.Green;
                                lblPlugState.Text = "插好";
                            } else {
                                lblPlugLed.ForeColor = Color.Red;
                                lblPlugState.Text = "没准备好";
                            }

                            if (dataParser.cpGetStateData.cpOutState == 0x00) {
                                lblCurLed.ForeColor = Color.Green;
                                lblCurState.Text = "有输出";
                            } else {
                                lblCurLed.ForeColor = Color.Red;
                                lblCurState.Text = "无输出";
                            }
                        } else {
                            Console.WriteLine("receive charging pile state command fail.\n");
                            cpStateLed.ForeColor = Color.Red;
                        }
                    }
                    if (dataParser.classType == CPBackDataParse.BackDataType.StartupType) {

                        if (dataParser.cpGetStartupData.cpControlExecuteResult == true) {
                            Console.WriteLine("receive charging pile start and stop command success.\n");
                            cpStartLed.ForeColor = Color.Gray;
                            cpPauseLed.ForeColor = Color.Gray;
                            cpRecoverLed.ForeColor = Color.Gray;
                            cpStopLed.ForeColor = Color.Gray;
                            if (dataParser.cpGetStartupData.cpWorkState == CPGetStartup.CP_WORK_STATE.cpStartWork) {
                                cpStartLed.ForeColor = Color.Green;
                            } else if (dataParser.cpGetStartupData.cpWorkState == CPGetStartup.CP_WORK_STATE.cpPauseWork) {
                                cpPauseLed.ForeColor = Color.Green;
                            } else if (dataParser.cpGetStartupData.cpWorkState == CPGetStartup.CP_WORK_STATE.cpStopWork) {
                                cpStopLed.ForeColor = Color.Green;
                            } else if (dataParser.cpGetStartupData.cpWorkState == CPGetStartup.CP_WORK_STATE.cpRecoverWork) {
                                cpRecoverLed.ForeColor = Color.Green;
                            }

                        } else {
                            Console.WriteLine("receive charging pile start and stop command fail.\n");
                            cpStartLed.ForeColor = Color.Gray;
                            cpPauseLed.ForeColor = Color.Gray;
                            cpRecoverLed.ForeColor = Color.Gray;
                            cpStopLed.ForeColor = Color.Gray;
                            if (dataParser.cpGetStartupData.cpWorkState == CPGetStartup.CP_WORK_STATE.cpStartWork) {
                                cpStartLed.ForeColor = Color.Red;
                            } else if (dataParser.cpGetStartupData.cpWorkState == CPGetStartup.CP_WORK_STATE.cpPauseWork) {
                                cpPauseLed.ForeColor = Color.Red;
                            } else if (dataParser.cpGetStartupData.cpWorkState == CPGetStartup.CP_WORK_STATE.cpStopWork) {
                                cpStopLed.ForeColor = Color.Red;
                            } else if (dataParser.cpGetStartupData.cpWorkState == CPGetStartup.CP_WORK_STATE.cpRecoverWork) {
                                cpRecoverLed.ForeColor = Color.Red;
                            }
                        }
                    }
                    if (dataParser.classType == CPBackDataParse.BackDataType.CurInfoType) {

                        if (dataParser.cpGetCurInfoData.cpGetCurInfoExecuteResult) {
                            Console.WriteLine("receive current charging info command success.\n");

                            curChargeInfoLed.ForeColor = Color.Green;

                            // deal parameter

                            txtCurTotalElect.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpChargeTotalElect);
                            txtCurTotalCost.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpChargeTotalPrice);

                            txtCurPointElect.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpChargePointElect);
                            txtCurPeakElect.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpChargePeakElect);
                            txtCurFlatElect.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpChargeFlatElect);
                            txtCurValleyElect.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpChargeValleyElect);

                            txtCurPointPrice.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpPointElectPrice);
                            txtCurPeakPrice.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpPeakElectPrice);
                            txtCurFlatPrice.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpFlatElectPrice);
                            txtCurValleyPrice.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpValleyElectPrice);

                            txtCurPointCost.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpPointCost);
                            txtCurPeakCost.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpPeakCost);
                            txtCurFlatCost.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpFlatCost);
                            txtCurValleyCost.Text = dataParser.dealParaChange(dataParser.cpGetCurInfoData.cpValleyCost);

                            chargeInfoFlg = true;

                            if (btnCheckChargeInfo.Text == "停止查看") {
                                //chargeInfoTime.Enabled = true;
                            }

                        } else {
                            Console.WriteLine("receive current charging info command fail.\n");

                            curChargeInfoLed.ForeColor = Color.Red;
                        }
                    }
                    //Console.WriteLine("接收客户端{0}消息{1}", myClientSocket.RemoteEndPoint.ToString(), Encoding.ASCII.GetString(result, 0, receiveNumber));
                    
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                    myClientSocket.Shutdown(SocketShutdown.Both);
                    myClientSocket.Close();
                    break;
                }
            }
        }
#endregion
        #endregion
    }
}
