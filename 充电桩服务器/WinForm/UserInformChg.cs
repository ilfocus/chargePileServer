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
    public partial class UserInformChg : Form {
        public UserInformChg() {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e) {
            string path = System.Environment.CurrentDirectory + "\\" + "用户挡案.mdb;";
            string openMathed = @"Password=;Jet OLEDB:Database Password=lide2015;Mode=Share Deny Read|Share Deny Write";
            string ConStr = @"Provider=Microsoft.Jet.OLEDB.4.0;data source=" + path + openMathed;
            OleDbConnection con = new OleDbConnection(ConStr);
            con.Open();
            string sql = "update 用户名和密码 set [用户名]='" + txtUser.Text + "', [密码]='" + txtPassword.Text + "' where 用户编号='1'";
            OleDbCommand cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("修改用户名及密码成功！");
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            string path = System.Environment.CurrentDirectory + "\\" + "用户挡案.mdb;";
            string openMathed = @"Password=;Jet OLEDB:Database Password=lide2015;Mode=Share Deny Read|Share Deny Write";
            string ConStr = @"Provider=Microsoft.Jet.OLEDB.4.0;data source=" + path + openMathed;
            OleDbConnection m_cnADONetConnection = new OleDbConnection();
            OleDbDataAdapter m_daDataAdapter;
            OleDbCommandBuilder m_cbConmmanBuilder;
            DataTable m_dtContacts = new DataTable();
            m_cnADONetConnection.ConnectionString = ConStr;
            m_daDataAdapter = new OleDbDataAdapter("Select*From 用户名和密码", m_cnADONetConnection);
            m_cbConmmanBuilder = new OleDbCommandBuilder(m_daDataAdapter);
            m_daDataAdapter.Fill(m_dtContacts);
            DataRow drNewRow = m_dtContacts.NewRow();
            drNewRow["用户编号"] = txtAddUserNum.Text;
            drNewRow["用户名"] = txtAddUser.Text;
            drNewRow["密码"] = txtAddPassword.Text;
            m_dtContacts.Rows.Add(drNewRow);
            m_daDataAdapter.Update(m_dtContacts);
            MessageBox.Show("添加用户名及密码成功！");
        }
    }
}
