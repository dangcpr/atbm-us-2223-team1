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
    public partial class DBAUI : Form
    {
        public DBAUI()
        {
            InitializeComponent();
        }
        public static OracleConnection conNow;
        public static string current_user;
        private void DBAUI_Load(object sender, EventArgs e)
        {
             conNow = LoginUI.con;
            /* Test kết nối (thành công)
            OracleCommand selectGD = conNow.CreateCommand();
            selectGD.CommandText = "SELECT MaNV FROM NHANVIEN WHERE ChucVu = 'Giám đốc'";
            OracleDataReader reader = selectGD.ExecuteReader();
            reader.Read();
            label1.Text = reader.GetString(0);*/
            OracleCommand selectUser = conNow.CreateCommand();
            selectUser.CommandText = "select sys_context('userenv', 'current_user') from dual";
            OracleDataReader reader = selectUser.ExecuteReader();
            reader.Read();
            label1.Text = "XIN CHÀO " + reader.GetString(0).ToUpper() + "!";
        }

        private void logout_Click(object sender, EventArgs e)
        {
            try
            {
                conNow.Dispose();
                conNow.Close();
                OracleConnection.ClearPool(conNow);


                MessageBox.Show("Đóng kết nối và đăng xuất thành công");

                LoginUI login = new LoginUI();
                login.Show();
                this.Hide();

            }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            conNow.Dispose();
            conNow.Close();
            OracleConnection.ClearPool(conNow);

            Application.Exit();
        }

        private void tabUserARole_Click(object sender, EventArgs e)
        {

        }

        private void userAndRoleUI1_Load(object sender, EventArgs e)
        {

        }

        private void roleUI1_Load(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {

        }

        private void tabPrivilege_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
