using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ChargingPileServer.WinForm {
    public partial class UserLoin : Form {
        public UserLoin() {
            InitializeComponent();
            skinEngine2.SkinFile = System.Windows.Forms.Application.StartupPath.Replace(@"\bin\Debug", "") + @"\Resources\GlassGreen.ssk";
            skinEngine2.SkinAllForm = true;
        }
        private MonitoringInterface MoniIntFaceForm = null;
        public string user_name     = null;
        public string password      = null;
        public string strStatues    = null;

        public string Number = "2";
        private bool checkflag = false;

        private string strAddress()
        {
            string path = System.Environment.CurrentDirectory + "\\" + "用户挡案.mdb;";
            string openMathed = @"Password=;Jet OLEDB:Database Password=lide2015;Mode=Share Deny Read|Share Deny Write";
            string ConStr = @"Provider=Microsoft.Jet.OLEDB.4.0;data source=" + path + openMathed;
            return ConStr;
        }

        private void btnEnter_Click(object sender, EventArgs e) {

            OleDbConnection con = new OleDbConnection(strAddress());
            con.Open(); 
            
            OleDbCommand cmd = new OleDbCommand("Select * From 用户名和密码", con);
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                user_name = reader[1].ToString();
                password  = reader[2].ToString();
                if (cobUserName.Text == user_name) {
                    if (txtPassword.Text == password) {

                        if (MoniIntFaceForm == null || MoniIntFaceForm.IsDisposed) {
                            MoniIntFaceForm = new MonitoringInterface();
                        }
                        MoniIntFaceForm.Owner = this;
                        MoniIntFaceForm.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void chbRemPassword_CheckedChanged(object sender, EventArgs e) {
            if (chbRemPassword.Checked) {   // select rember password
                
                OleDbConnection m_cnADONetConnection = new OleDbConnection(strAddress());
                /*
                OleDbCommand cmd = new OleDbCommand("Select * From 用户名和密码", m_cnADONetConnection);
                OleDbDataReader reader = cmd.ExecuteReader();
               
                while (reader.Read()) {
                    user_name  = reader[1].ToString();
                    password   = reader[2].ToString();
                    strStatues = reader[3].ToString();

                    if (cobUserName.Text == user_name && txtPassword.Text == password) {
                        if (strStatues == "1") {
                                return; // 
                        } else {
                            
                        }
                    }
                }*/
                OleDbDataAdapter m_daDataAdapter = new OleDbDataAdapter("Select*From 记住密码", m_cnADONetConnection);
                OleDbCommandBuilder m_cbConmmanBuilder = new OleDbCommandBuilder(m_daDataAdapter);
                DataTable m_dtContacts = new DataTable();
                m_daDataAdapter.Fill(m_dtContacts);
                DataRow drNewRow = m_dtContacts.NewRow();
                drNewRow["用户名"] = cobUserName.Text;
                drNewRow["密码"]   = txtPassword.Text;
                drNewRow["状态"]   = "1";
                m_dtContacts.Rows.Add(drNewRow);
                m_daDataAdapter.Update(m_dtContacts);


            } else {
                Console.WriteLine("checked no");
            }
        }

        private void UserLoin_Load(object sender, EventArgs e) {

            OleDbConnection con = new OleDbConnection(strAddress());
            con.Open();

            int i = Convert.ToInt16(Number);
            OleDbCommand cmd = new OleDbCommand("Select * From 记住密码 where ID>=@id", con);
            cmd.Parameters.Add("@id", i);

            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            try {
                cobUserName.Text = reader[0].ToString();
                txtPassword.Text = reader[1].ToString();
                checkflag = true;
                chbRemPassword.Checked = true;
            } catch { };

            reader.Close();
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
