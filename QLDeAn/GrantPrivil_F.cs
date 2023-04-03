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
using Dapper;

namespace QLDeAn
{
    public partial class GrantPrivil_F : Form
    {
        public GrantPrivil_F()
        {
            InitializeComponent();
        }

        public static OracleConnection conNow;
        private void GrantPrivil_F_Load(object sender, EventArgs e)
        {
            conNow = LoginUI.con;
        }

        private void userrolelabel_Click(object sender, EventArgs e)
        {

        }
        private void roleuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void check_Click(object sender, EventArgs e)
        {
            if (roleuser.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Username hoặc Role");
                return;
            }
            else
            {
                var cmd = new OracleCommand();

                cmd.Connection = conNow;
                cmd.CommandText = "check_user_role_exist";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("user_role", roleuser.Text.ToString());
                cmd.Parameters.Add("res", OracleDbType.Int32).Direction = ParameterDirection.Output;

                //cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                var result_ = Convert.ToString(cmd.Parameters["res"].Value);

                if (result_ != "1" && result_ != "2")
                {
                    result.Text = "Không tồn tại";
                    return;
                }
                else
                {
                    roleuser.Enabled = false;
                    privil.Enabled = true;
                    table.Enabled = true;
                    column.Enabled = true;


                    if (result_ == "1")
                    {
                        result.Text = "Đây là User";
                        withgrantoption.Enabled = true;
                    }
                    else
                    {
                        result.Text = "Đây là Role";
                    }
                }
            }
        }        
        
        private void resetUR_Click(object sender, EventArgs e)
        {
            roleuser.Clear();
            roleuser.Enabled = true;
            result.Text = "Chưa kiểm tra";
            privil.SelectedIndex = -1;
            privil.Enabled = false;
            table.SelectedIndex = -1;
            table.Enabled = false;
            for (int i = 0; i < column.Items.Count; i++)
            {
                column.SetItemChecked(i, false);
            }
            column.Enabled = false;
            withgrantoption.Checked = false;
            withgrantoption.Enabled = false;
        }
        private void resultlabel_Click(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void privillable_Click(object sender, EventArgs e)
        {

        }

        private void privil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void tablelabel_Click(object sender, EventArgs e)
        {

        }

        private void table_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void withgrantoption_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void columnlabel_Click(object sender, EventArgs e)
        {

        }

        private void column_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grantButton_Click(object sender, EventArgs e)
        {
            if (roleuser.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Username hoặc Role");
                return;
            }

            if (privil.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn quyền muốn cấp");
                return;
            }
            if (table.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn bảng cần cấp quyền");
                return;
            }
            if (column.Items.Count != 0)
            {
                if (column.CheckedIndices.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn những thuộc tính trong bảng cần cấp quyền");
                    return;
                }
            }
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
