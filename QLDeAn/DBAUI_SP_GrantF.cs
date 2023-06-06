using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDeAn
{
    public partial class DBAUI_SP_GrantF : Form
    {
        public static OracleConnection conNow = LoginUI.con;
        public DBAUI_SP_GrantF()
        {
            InitializeComponent();
        }

        private void DBAUI_SP_GrantF_Load(object sender, EventArgs e)
        {
            try
            {
                string selectTsql = "select * from session_privs order by PRIVILEGE ASC";
                OracleCommand comm = new OracleCommand(selectTsql, LoginUI.con);
                OracleDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    privilBox.Items.Add(reader[0]);
                };
                reader.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


        private void grantRevokeButton_Click(object sender, EventArgs e)
        {
            if (granteeTextBox.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống chủ thể");
            }

            if (activityBox.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống thao tác");
            }

            if (privilBox.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống quyền thực hiện");
            }
            try
            {
                string sql = "";
                if (activityBox.Text == "CẤP QUYỀN")
                {
                    sql = "GRANT " + privilBox.Text + " TO " + granteeTextBox.Text;
                    if (checkBoxAdmin.Checked == true) sql += " WITH ADMIN OPTION";            
                }
                if (activityBox.Text == "HỦY QUYỀN")
                {
                    sql = "REVOKE " + privilBox.Text + " FROM " + granteeTextBox.Text;
                }
                OracleCommand cmd = new OracleCommand(sql, conNow);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thực hiện thao tác " + activityBox.Text + " thành công");
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void activityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activityBox.Text == "CẤP QUYỀN")
            {
                checkBoxAdmin.Enabled = true;
            }
            else
            {
                checkBoxAdmin.Enabled = false;
                checkBoxAdmin.Checked = false;
            }
        }
    }
}
