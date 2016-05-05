using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChargingPileServer
{
    public partial class ParameterSet : Form
    {
        MonitoringInterface frmMonitoringInterface = new MonitoringInterface();
        byte[] bSetCmd = new byte[14];// 上位机对主机的设置命令集合
        public bool bMsgSengFlg = false;
        public ParameterSet()
        {
            InitializeComponent();
            frmMonitoringInterface.updateFrameTimer.Enabled = false;
            // 把主界面更新定时器停止，否则在更新定时器会定位TreeView
            // 使得本界面中无法fouce参数输入框
        }
        public void setSendData() {
            MonitoringInterface frmMonitoringInterface = (MonitoringInterface)this.Owner;
            // 参数设置查空，主机号，从机号，电流，时间
            if (txtMasterNum.Text == "") {
                MessageBox.Show("请输入主机号，有效值范围为0~20！");// 0为所有主机
                txtMasterNum.Focus();
                return;
            }
            if (txtSlaveNum.Text == "") {
                MessageBox.Show("请输入从机号，有效值范围为0~6！");// 0为所有从机
                txtSlaveNum.Focus();
                return;
            }
            if (txtCurrent.Text == "") {
                MessageBox.Show("请输入电流值，有效值范围为100~5000！");
                txtCurrent.Focus();
                return;
            }
            if (txtTime.Text == "") {
                MessageBox.Show("请输入时间值，有效值范围为1~999！");
                txtTime.Focus();
                return;
            }
            // 获得四个参数值
            int hostNum = Convert.ToInt32(txtMasterNum.Text);
            int slaveNum = Convert.ToInt32(txtSlaveNum.Text);
            int current = Convert.ToInt32(txtCurrent.Text);
            int time = Convert.ToInt32(txtTime.Text);
            UInt16 uwCrcResult;
            if (hostNum > 20 || hostNum < 0) {  // 参数检查部分
                MessageBox.Show("主机号输入有误，请重新输入！");
                txtMasterNum.Focus();
                txtMasterNum.SelectAll();//全部选中，以便可以更正输入
                return;
            }
            if (slaveNum > 6 || slaveNum < 0) {
                MessageBox.Show("从机号输入有误，请重新输入！");
                txtSlaveNum.Focus();
                txtSlaveNum.SelectAll();//全部选中，以便可以更正输入
                return;
            }
            if (current > 5000 || current < 100) { // 电流单位是mA
                MessageBox.Show("电流值输入有误，请重新输入！");
                txtCurrent.Focus();
                txtCurrent.SelectAll();//全部选中，以便可以更正输入
                return;
            }
            if (time > 999 || time < 1) { // 时间单位是min
                MessageBox.Show("时间输入有误，请重新输入！");
                txtTime.Focus();
                txtTime.SelectAll();//全部选中，以便可以更正输入
                return;
            }
            for (int i = 0; i < 14; i++) { // 数组初始化
                bSetCmd[i] = 0x00;
            }
            bSetCmd[0] = 0xaa;                  // 起始字符高位
            bSetCmd[1] = 0x55;                  // 起始字符低位
            bSetCmd[2] = 0x0c;                  // 数据长度（以下字符总长度，包括本身）
            bSetCmd[3] = 0xff;                  // 源地址
            bSetCmd[4] = (byte)hostNum;         // 主机号
            bSetCmd[5] = 0x07;                  // 功能码-开机并设置数据

            bSetCmd[6] = (byte)(current >> 8);  // 设置电流高位    
            bSetCmd[7] = (byte)current;         // 设置电流低位
            bSetCmd[8] = (byte)(time >> 8);     // 设置时间高位
            bSetCmd[9] = (byte)time;           // 设置时间低位

            frmMonitoringInterface.CRC_16(bSetCmd, 10, out uwCrcResult);
            bSetCmd[10] = (byte)(uwCrcResult >> 8);    // 校验码高位
            bSetCmd[11] = (byte)uwCrcResult;           // 校验码低位
            if (true == frmMonitoringInterface.serialPort1.IsOpen) {
                frmMonitoringInterface.serialPort1.Write(bSetCmd, 0, 12);
            } else {
                MessageBox.Show("串口未打开，请打开串口");
            }
        }
        private void btnSet_Click(object sender, EventArgs e) {
            if (bMsgSengFlg == false) {
                setSendData();
                bMsgSengFlg = true;
            }
        }

        private void ParameterSet_Load(object sender, EventArgs e)
        {

        }

        private void btnPS_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            MonitoringInterface frmMonitoringInterface = (MonitoringInterface)this.Owner;
            // 参数设置查空，主机号，从机号，电流，时间
            if (txtMasterNum.Text == "") {
                MessageBox.Show("请输入主机号，有效值范围为0~20！");// 0为所有主机
                txtMasterNum.Focus();
                return;
            }
            if (txtSlaveNum.Text == "") {
                MessageBox.Show("请输入从机号，有效值范围为0~6！");// 0为所有从机
                txtSlaveNum.Focus();
                return;
            }
            if (txtCurrent.Text == "") {
                MessageBox.Show("请输入电流值，有效值范围为100~5000！");
                txtCurrent.Focus();
                return;
            }
            if (txtTime.Text == "") {
                MessageBox.Show("请输入时间值，有效值范围为1~999！");
                txtTime.Focus();
                return;
            }
            // 获得四个参数值
            int hostNum = Convert.ToInt32(txtMasterNum.Text);
            int slaveNum = Convert.ToInt32(txtSlaveNum.Text);
            int current = Convert.ToInt32(txtCurrent.Text);
            int time = Convert.ToInt32(txtTime.Text);
            UInt16 uwCrcResult;
            if (hostNum > 20 || hostNum < 0) {  // 参数检查部分
                MessageBox.Show("主机号输入有误，请重新输入！");
                txtMasterNum.Focus();
                txtMasterNum.SelectAll();//全部选中，以便可以更正输入
                return;
            }
            if (slaveNum > 6 || slaveNum < 0) {
                MessageBox.Show("从机号输入有误，请重新输入！");
                txtSlaveNum.Focus();
                txtSlaveNum.SelectAll();//全部选中，以便可以更正输入
                return;
            }
            if (current > 5000 || current < 100) { // 电流单位是mA
                MessageBox.Show("电流值输入有误，请重新输入！");
                txtCurrent.Focus();
                txtCurrent.SelectAll();//全部选中，以便可以更正输入
                return;
            }
            if (time > 999 || time < 1) { // 时间单位是min
                MessageBox.Show("时间输入有误，请重新输入！");
                txtTime.Focus();
                txtTime.SelectAll();//全部选中，以便可以更正输入
                return;
            }
            for (int i = 0; i < 14; i++) { // 数组初始化
                bSetCmd[i] = 0x00;
            }
            bSetCmd[0] = 0xaa;                  // 起始字符高位
            bSetCmd[1] = 0x55;                  // 起始字符低位
            bSetCmd[2] = 0x0c;                  // 数据长度（以下字符总长度，包括本身）
            bSetCmd[3] = 0xff;                  // 源地址
            bSetCmd[4] = (byte)hostNum;         // 主机号
            bSetCmd[5] = 0x04;                  // 功能码-开机并设置数据

            bSetCmd[6] = (byte)(current >> 8);  // 设置电流高位    
            bSetCmd[7] = (byte)current;         // 设置电流低位
            bSetCmd[8] = (byte)(time >> 8);     // 设置时间高位
            bSetCmd[9] = (byte)time;           // 设置时间低位

            frmMonitoringInterface.CRC_16(bSetCmd, 10, out uwCrcResult);
            bSetCmd[10] = (byte)(uwCrcResult >> 8);    // 校验码高位
            bSetCmd[11] = (byte)uwCrcResult;           // 校验码低位
            if (true == frmMonitoringInterface.serialPort1.IsOpen) {
                frmMonitoringInterface.serialPort1.Write(bSetCmd, 0, 12);
            } else {
                MessageBox.Show("串口未打开，请打开串口");
            }
        }
        /*
        MonitoringInterface frmMonitoringInterface = new MonitoringInterface();
        byte[] bSetCmd = new byte[14];// 上位机对主机的设置命令集合
        private void btnSet_Click(object sender, EventArgs e)
        {
            // 参数设置并获得，主机号，从机号，电流，时间
            int hostNum = Convert.ToInt32(txtMasterNum.Text);
            int slaveNum = Convert.ToInt32(txtSlaveNum.Text);
            int current = Convert.ToInt32(txtCurrent.Text);
            int time = Convert.ToInt32(txtTime.Text);
            UInt16 uwCrcResult;
            // 参数检查部分

            if (hostNum > 20 || hostNum < 0)
            {
                MessageBox.Show("主机号输入有误，请重新输入！");
                txtMasterNum.Focus();
                txtMasterNum.SelectAll();//全部选中，以便可以更正输入
                return;
            }
            if (slaveNum > 6 || slaveNum < 0)
            {
                MessageBox.Show("从机号输入有误，请重新输入！");
                txtSlaveNum.Focus();
                txtSlaveNum.SelectAll();//全部选中，以便可以更正输入
                return;
            }
            if (current > 5000 || current < 0)  // 电流单位是mA
            {
                MessageBox.Show("电流值输入有误，请重新输入！");
                txtCurrent.Focus();
                txtCurrent.SelectAll();//全部选中，以便可以更正输入
                return;
            }
            if (time > 999 || time < 0)  // 时间单位是min
            {
                MessageBox.Show("时间输入有误，请重新输入！");
                txtTime.Focus();
                txtTime.SelectAll();//全部选中，以便可以更正输入
                return;
            }

            for (int i = 0; i < 14; i++)
            {
                bSetCmd[i] = 0x00;
            }                       // 数组初始化
            bSetCmd[0] = 0xaa;      // 起始字符
            bSetCmd[1] = 0x0e;      // 数据长度
            bSetCmd[2] = 0xff;      // 源地址

            bSetCmd[3] = (byte)hostNum;     // 主机号
            bSetCmd[4] = (byte)slaveNum;    // 从机号

            bSetCmd[5] = 0x00;     // 操作码---写数据
            bSetCmd[6] = 0x07;     // 操作命令---设置数据并开机

            bSetCmd[7] = (byte)(current >> 8);     // 设置电流高位    
            bSetCmd[8] = (byte)current;     // 设置电流低位
            bSetCmd[9] = (byte)(time >> 8);     // 设置时间高位
            bSetCmd[10] = (byte)time;    // 设置时间低位

            //string str = System.Text.Encoding.Default.GetString ( bSetCmd );

            frmMonitoringInterface.CRC_16(bSetCmd, 11, out uwCrcResult);
            //CRC_16(bSetCmd, 11, out uwCrcResult);
            bSetCmd[11] = (byte)(uwCrcResult >> 8);    // 校验码高位
            bSetCmd[12] = (byte)uwCrcResult;    // 校验码低位

            bSetCmd[13] = 0x55;    // 结尾帧
            frmMonitoringInterface.serialPort1.Write(bSetCmd, 0, 14);
            //serialPort1.Write(bSetCmd, 0, 14);
        }
        */
    }
}
