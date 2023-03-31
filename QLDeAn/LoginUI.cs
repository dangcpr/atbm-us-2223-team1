using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QLDeAn
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            
            InitializeComponent();
        }
        public static OracleConnection con;
        private void Form1_Load(object sender, EventArgs e) 
        {
            this.ControlBox = false;
        }
        private void title_Click(object sender, EventArgs e) { }
        private void label_user_Click(object sender, EventArgs e) { }
        private void username_TextChanged(object sender, EventArgs e) { }
        private void label_password_Click(object sender, EventArgs e) { }
        private void password_TextChanged(object sender, EventArgs e) { }
        private void role_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label_role_Click(object sender, EventArgs e) { }
        private void login_Click(object sender, EventArgs e)
        {
            if (username.Text.Length == 0)
            {
                MessageBox.Show("TÊN ĐĂNG NHẬP không được để trống.");
                return;
            }
            if (password.Text.Length == 0)
            {
                MessageBox.Show("MẬT KHẨU không được để trống.");
                return;
            }
            if (role.Text.Length == 0)
            {
                MessageBox.Show("VAI TRÒ không được để trống.");
                return;
            }

            //Check username, password and role
            try
            {
                string connectionString = "";
                if (role.Text == "DBA")
                    connectionString = @"DATA SOURCE = localhost:1521/XE;DBA Privilege=SYSDBA; USER ID=" + username.Text +";PASSWORD=" + password.Text;
                else
                    connectionString = @"DATA SOURCE = localhost:1521/XE; USER ID=" + username.Text + ";PASSWORD=" + password.Text;

                con = new OracleConnection();
                con.ConnectionString = connectionString;
                con.Open();

                MessageBox.Show("Connect với Oracle thành công");

                if (role.Text == "DBA")
                {
                    DBAUI dba = new DBAUI();
                    dba.Show();
                }

                this.Hide();
            }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
