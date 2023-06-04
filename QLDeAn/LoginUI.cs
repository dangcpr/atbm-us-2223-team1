using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public static String roleUser;
        private void LoginUI_Load(object sender, EventArgs e) 
        {
            
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
                if (role.Text == "SYSDBA")
                    connectionString = @"DATA SOURCE = localhost:1521/XE;DBA Privilege=SYSDBA; USER ID=" + username.Text +";PASSWORD=" + password.Text;
                else
                    connectionString = @"DATA SOURCE = localhost:1521/XE; USER ID=" + username.Text + ";PASSWORD=" + password.Text;

                con = new OracleConnection();
                con.ConnectionString = connectionString;
                con.Open();


                if (role.Text == "SYSDBA" || role.Text == "ADMIN")
                {
                    OracleCommand command = new OracleCommand("alter session set \"_ORACLE_SCRIPT\"=true", con);
                    command.ExecuteNonQuery();
                    DBAUI dba = new DBAUI();
                    dba.Show();
                }
                else
                {
                    OracleCommand command = new OracleCommand("alter session set \"_ORACLE_SCRIPT\"=true", con);
                    command.ExecuteNonQuery();
                    string sqlRole = "";
                    if(role.Text != "Nhân sự")
                    {
                        sqlRole = "SELECT VAITRO FROM QLDA.QLDA_NHANVIEN WHERE MANV = :manv";
                    }
                    else
                    {
                        sqlRole = "SELECT VAITRO FROM QLDA.V_QLDA_NHANVIEN_NS WHERE MANV = :manv";
                    }
                    OracleCommand command_role = new OracleCommand(sqlRole, con);
                    command_role.Parameters.Add(new OracleParameter("manv", username.Text));
                    OracleDataReader dr = command_role.ExecuteReader();
                    if (dr.Read())
                    {
                        roleUser = dr.GetString(0);
                        if (role.Text != roleUser)
                        {
                            MessageBox.Show("Role không khớp với User");
                            con.Dispose();
                            con.Close();
                            OracleConnection.ClearPool(con);
                            return;
                        }
                    }
                    //this.Hide();

                    MessageBox.Show("Connect với Oracle thành công");
                    NhanVienUI NVUI = new NhanVienUI();
                    switch (roleUser)
                    {
                        case "Nhân viên":
                            NVUI.Text = "NHÂN VIÊN";
                            break;
                        case "Quản lý":
                            NVUI.Text = "QUẢN LÝ";
                            break;
                        case "Trưởng phòng":
                            NVUI.Text = "TRƯỞNG PHÒNG";
                            break;
                        case "Tài chính":
                            NVUI.Text = "TÀI CHÍNH";
                            break;
                        case "Nhân sự":
                            NVUI.Text = "NHÂN SỰ";
                            break;
                        case "Trưởng dự án":
                            NVUI.Text = "TRƯỞNG DỰ ÁN";
                            break;
                        case "Giám đốc":
                            NVUI.Text = "GIÁM ĐỐC";
                            break;
                    }
                    NVUI.Show();
                    dr.Close();
                }
                //MessageBox.Show("Connect với Oracle thành công");

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
