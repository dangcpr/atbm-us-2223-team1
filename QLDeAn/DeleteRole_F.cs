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
    public partial class DeleteRole_F : Form
    {
        public DeleteRole_F()
        {
            InitializeComponent();
        }

        public static string result_roleuser;
        public static OracleConnection conNow;

        private void DeleteRole_F_Load(object sender, EventArgs e)
        {
            conNow = LoginUI.con;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (roleBox.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập role bạn muốn xóa! ");
                    return;
                }
                else
                {
                    var cmd = new OracleCommand();

                    cmd.Connection = conNow;
                    cmd.CommandText = "QLDA.check_user_role_exist";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("user_role", roleBox.Text.ToString());
                    cmd.Parameters.Add("res", OracleDbType.Int32).Direction = ParameterDirection.Output;

                    //cmd.Connection.Open();
                    cmd.ExecuteNonQuery();

                    result_roleuser = Convert.ToString(cmd.Parameters["res"].Value);

                    if (result_roleuser != "2")
                    {
                        MessageBox.Show("Không tồn tại role này!");
                        return;
                    }
                    else
                    {
                        var cmd1 = new OracleCommand();

                        cmd1.Connection = conNow;
                        cmd1.CommandText = "QLDA.delete_role";
                        cmd1.CommandType = CommandType.StoredProcedure;

                        cmd1.Parameters.Add("p_role_name", roleBox.Text.ToString());

                        cmd1.ExecuteNonQuery();

                        //cập nhật lại Role
                        string sql = "SELECT ROLE, ROLE_ID, PASSWORD_REQUIRED FROM DBA_ROLES";

                        OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
                        DataTable dt1 = new DataTable();
                        da.Fill(dt1);
                        UserAndRoleUI.data_grid_view2.DataSource = dt1;
                    }

                }
                MessageBox.Show("Xóa role thành công.");
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void roleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
