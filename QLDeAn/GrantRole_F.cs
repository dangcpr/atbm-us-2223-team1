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
    public partial class GrantRole_F : Form
    {
        public GrantRole_F()
        {
            InitializeComponent();
        }
        public static OracleConnection conNow;        
        private void GrantRole_F_Load(object sender, EventArgs e)
        {
            conNow = LoginUI.con;
        }

        private void user_TextChanged(object sender, EventArgs e) { }
        private void role_TextChanged(object sender, EventArgs e) { }
        private void withadminoption_CheckedChanged(object sender, EventArgs e) { }        
       
        private void grantButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.Text.Length == 0)
                {
                    MessageBox.Show("Không được để trống User");
                    return;
                }
                
                if (role.Text.Length == 0)
                {
                    MessageBox.Show("Không được để trống Role");
                    return;
                }
                var cmd = new OracleCommand();
                string withadminoption_ = (withadminoption.Checked) ? "WITH ADMIN OPTION" : "";

                cmd.Connection = conNow;
                cmd.CommandText = "QLDA.grant_role";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("user_name", user.Text.ToString());
                cmd.Parameters.Add("role_name", role.Text.ToString());
                cmd.Parameters.Add("withadminoption", withadminoption_);
                cmd.Parameters.Add("res", OracleDbType.Int32).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                var result_roleuser = Convert.ToString(cmd.Parameters["res"].Value);

                if (result_roleuser == "-1")
                {
                    MessageBox.Show("User/Role cần cấp role không tồn tại");
                }
                else if (result_roleuser == "-2")
                {
                    MessageBox.Show("Role cần cấp cho User không tồn tại");
                }
                else if (result_roleuser == "3")
                {
                    MessageBox.Show("Cấp role " + role.Text.ToString() + " cho user/role " + user.Text.ToString() + " thành công");
                    this.Hide();

                    string sql = "select * from dba_role_privs";

                    OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    RoleUI.data_grid_view1.DataSource = dt;
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
