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
    public partial class NhanVienUI : Form
    {
        public static OracleConnection conNow;
        public static OracleConnection conPDB;
        public NhanVienUI()
        {

            switch (LoginUI.roleUser)
            {
                case "Nhân viên":
                    this.Text = "NHÂN VIÊN";
                    break;
                case "Quản lý":
                    this.Text = "QUẢN LÝ";
                    break;
                case "Trưởng phòng":
                    this.Text = "TRƯỞNG PHÒNG";
                    break;
                case "Tài chính":
                    this.Text = "TÀI CHÍNH";
                    break;
                case "Nhân sự":
                    this.Text = "NHÂN SỰ";
                    break;
                case "Trưởng dự án":
                    this.Text = "TRƯỞNG DỰ ÁN";
                    break;
                case "Giám đốc":
                    this.Text = "GIÁM ĐỐC";
                    break;

            }
            this.Update();
            InitializeComponent();
        }
        private void NhanVienUI_Load(object sender, EventArgs e)
        {
            try
            {
                conNow = LoginUI.con;
                OracleCommand selectUser = conNow.CreateCommand();
                selectUser.CommandText = "select sys_context('userenv', 'current_user') from dual";
                OracleDataReader reader = selectUser.ExecuteReader();
                reader.Read();
                label1.Text = "XIN CHÀO " + reader.GetString(0).ToUpper() + "!";
            } 
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
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
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            conNow.Dispose();
            conNow.Close();
            OracleConnection.ClearPool(conNow);
            Application.Exit();
        }

        private void ThongBaoButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"DATA SOURCE = localhost:1521/PDB1;USER ID=" + LoginUI.userUser + ";PASSWORD=" + LoginUI.passUser;
            conPDB = new OracleConnection();
            conPDB.ConnectionString = connectionString;
            conPDB.Open();

            ThongBaoUI TBUI = new ThongBaoUI();
            TBUI.Show();
        }
    }
}
