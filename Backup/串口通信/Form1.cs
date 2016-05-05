using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;


namespace 串口通信
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] szPorts = SerialPort.GetPortNames(); //获取当前可用的串口列表
                //这里得到的可用的串口，是指电脑里面可用的串口。
                combSerialPort.Items.AddRange(szPorts);
                combSerialPort.SelectedIndex = 0;
            }
            catch (Win32Exception win32ex) //获取串口出错
            {
                MessageBox.Show(win32ex.ToString());
            }
            
            combBaudRate.Text = "9600";
            combDataBit.Text = "8";
            combStopBits.Text = "1";
            SerialParity.Text = "None";
            combSerialPort.Text = "COM1";
            serialPort1.Encoding = Encoding.GetEncoding("gb2312");//接收发送转换编码
        }
        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            if (btnOpenPort.Text == "打开串口")
            {
                //this.serialPort1.Open();//打开串口，用的是控件！
                
                this.btnOpenPort.Text = "关闭串口";
                serialPort1.PortName = combSerialPort.Text;//给出串口号，字符型
                serialPort1.BaudRate = int.Parse(combBaudRate.Text);
                serialPort1.DataBits = int.Parse(combDataBit.Text);
                string szStopBits = combStopBits.SelectedItem.ToString();
                switch (szStopBits)
                {
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
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), SerialParity.SelectedItem.ToString());
                //此句要好好理解。Enum  提供一个指向枚举器（该枚举器可枚举复合名字对象的组件）的指针。
                serialPort1.Open();
                return;
            }
            if (btnOpenPort.Text == "关闭串口")
            {
                serialPort1.Close();

                this.btnOpenPort.Text = "打开串口";
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write(TxtSend.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(this.serialPort1.PortName.ToString() + "未打开");
            }//进行数据发送
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String szRecv;
            szRecv = serialPort1.ReadExisting();
            //在编码的基础上，读取 SerialPort 对象的流和输入缓冲区中所有立即可用的字节。
            //editRecvData.Text += szRecv; //显示到编辑框
            Control.CheckForIllegalCrossThreadCalls = false;//此地方为什么会出错呢！
            txtReceive.Text += szRecv;
            txtReceive.SelectionStart = txtReceive.Text.Length;
            txtReceive.SelectionLength = 0;
            txtReceive.ScrollToCaret(); //把滚动条滚动到末尾
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReceive.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

