using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QLDeAn
{
    public partial class UpdateUser_F : Form
    {
        public UpdateUser_F()
        {
            InitializeComponent();
        }

        public static string result_roleuser;
        public static OracleConnection conNow;

        private void UpdateUser_F_Load(object sender, EventArgs e)
        {
            conNow = LoginUI.con;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (usernameBox.Text.Length == 0 || oldpasswordBox.Text.Length == 0 || newpasswordBox.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập đủ username, password cũ và mới.");
                    return;
                }
                else
                {
                    var cmd = new OracleCommand();

                    cmd.Connection = conNow;
                    cmd.CommandText = "check_user_role_exist";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("user_role", usernameBox.Text.ToString());
                    cmd.Parameters.Add("res", OracleDbType.Int32).Direction = ParameterDirection.Output;

                    //cmd.Connection.Open();
                    cmd.ExecuteNonQuery();

                    result_roleuser = Convert.ToString(cmd.Parameters["res"].Value);

                    if (result_roleuser != "1")
                    {
                        MessageBox.Show("Không tồn tại username này!");
                        return;
                    }
                    else
                    {

                        var cmd1 = new OracleCommand();

                        cmd1.Connection = conNow;
                        cmd1.CommandText = "change_password";
                        cmd1.CommandType = CommandType.StoredProcedure;

                        cmd1.Parameters.Add("p_username", usernameBox.Text.ToString());
                        cmd1.Parameters.Add("p_oldpassword", oldpasswordBox.Text.ToString());
                        cmd1.Parameters.Add("p_newpassword", newpasswordBox.Text.ToString());

                        cmd1.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Đổi mật khẩu thành công!");
            }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void usernameBox_TextChanged(object sender, EventArgs e) { }
        
        private void oldpasswordBox_TextChanged(object sender, EventArgs e) { }

        private void newpasswordBox_TextChanged(object sender, EventArgs e) { }
    }
}
