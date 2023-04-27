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
    public partial class GrantPrivil_F : Form
    {
        public GrantPrivil_F()
        {
            InitializeComponent();
        }

        public static OracleConnection conNow;
        public static string result_roleuser;
        private void GrantPrivil_F_Load(object sender, EventArgs e)
        {
            conNow = LoginUI.con;
        }

        private void userrolelabel_Click(object sender, EventArgs e) { }
        private void roleuser_TextChanged(object sender, EventArgs e) { }

        private void check_Click(object sender, EventArgs e)
        {
            try
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
                    cmd.CommandText = "QLDA.check_user_role_exist";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("user_role", roleuser.Text.ToString());
                    cmd.Parameters.Add("res", OracleDbType.Int32).Direction = ParameterDirection.Output;

                    //cmd.Connection.Open();
                    cmd.ExecuteNonQuery();

                    result_roleuser = Convert.ToString(cmd.Parameters["res"].Value);

                    if (result_roleuser != "1" && result_roleuser != "2")
                    {
                        result.Text = "Không tồn tại";
                        return;
                    }
                    else
                    {
                        roleuser.Enabled = false;
                        privil.Enabled = true;
                        //table.Enabled = true;
                        //column.Enabled = true;


                        if (result_roleuser == "1")
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
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
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
        private void resultlabel_Click(object sender, EventArgs e) { }

        private void result_Click(object sender, EventArgs e) { }

        private void privillable_Click(object sender, EventArgs e) { }

        private void privil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (privil.Text.ToString() != "")
            {
                table.Enabled = true;
            }
            if (privil.Text.ToString() == "UPDATE" || privil.Text.ToString() == "SELECT")
            {
                column.Enabled = true;
            }
            else
            {
                column.Enabled = false;
                for (int i = 0; i < column.Items.Count; i++)
                {
                    column.SetItemChecked(i, false);
                }
            }
        }

        private void tablelabel_Click(object sender, EventArgs e) { }

        private void table_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int count_column = column.Items.Count;
                for (int i = count_column - 1; i >= 0; i--)
                {
                    column.Items.RemoveAt(i);
                }
                string query = "select COLUMN_NAME from dba_tab_columns where table_name = \'" + table.Text.ToString() + '\'';
                OracleDataAdapter adapter = new OracleDataAdapter(query, conNow);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    column.Items.Add(row["column_name"].ToString());
                }
            }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void withgrantoption_CheckedChanged(object sender, EventArgs e) { }
        private void columnlabel_Click(object sender, EventArgs e) { }
        private void column_SelectedIndexChanged(object sender, EventArgs e) { }

        private void grantButton_Click(object sender, EventArgs e)
        {
            try
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
                    if ((privil.Text.ToString() == "SELECT" || privil.Text.ToString() == "UPDATE") && column.CheckedItems.Count == 0)
                    {
                        MessageBox.Show("Vui lòng chọn những thuộc tính trong bảng cần cấp quyền");
                        return;
                    }
                }

                var cmd = new OracleCommand();

                cmd.Connection = conNow;
                string column_list = "";
                string withgrantoption_ = (withgrantoption.Checked) ? "WITH GRANT OPTION" : "";
                for (int i = 0; i < column.Items.Count; i++)
                {
                    if (column.GetItemChecked(i) == true)
                    {
                        column_list += column.Items[i].ToString() + ",";
                    }
                }
                if (column_list.Length > 0)
                {
                    // Xóa dấu "," cuối chuỗi
                    column_list = column_list.Substring(0, column_list.Length - 1);
                }

                //Lấy schema_name
                OracleCommand get_schema_name = conNow.CreateCommand();
                get_schema_name.CommandText = "select owner from dba_tables where table_name = \'" + table.Text.ToString() + '\'';
                OracleDataReader reader = get_schema_name.ExecuteReader();
                reader.Read();
                string schema_name = reader.GetString(0);

                //Các trường hợp cấp quyền
                if (privil.Text.ToString() == "INSERT")
                {
                    cmd.CommandText = "QLDA.grant_insert_privilege";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("user_role", roleuser.Text.ToString());
                    cmd.Parameters.Add("table_name", schema_name + "." + table.Text.ToString());
                    cmd.Parameters.Add("withgrantoption", withgrantoption_);
                    cmd.ExecuteNonQuery();

                    //cập nhật lại Privilge
                    string sql = "select * from DBA_TAB_PRIVS where TABLE_NAME LIKE 'QLDA_%' OR TABLE_NAME LIKE 'V_QLDA_%' ";

                    OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    PrivilegeUI.data_grid_view1.DataSource = dt1;

                }
                else if (privil.Text.ToString() == "DELETE")
                {
                    cmd.CommandText = "QLDA.grant_delete_privilege";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("user_role", roleuser.Text.ToString());
                    cmd.Parameters.Add("table_name", schema_name + "." + table.Text.ToString());
                    cmd.Parameters.Add("withgrantoption", withgrantoption_);
                    cmd.ExecuteNonQuery();

                    //cập nhật lại Privilge
                    string sql = "select * from DBA_TAB_PRIVS where TABLE_NAME LIKE 'QLDA_%' OR TABLE_NAME LIKE 'V_QLDA_%' ";

                    OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    PrivilegeUI.data_grid_view1.DataSource = dt1;
                }
                else if (privil.Text.ToString() == "UPDATE")
                {
                    cmd.CommandText = "QLDA.grant_update_privilege";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("user_role", roleuser.Text.ToString());
                    cmd.Parameters.Add("table_name", schema_name + "." + table.Text.ToString());
                    cmd.Parameters.Add("column_name", column_list);
                    cmd.Parameters.Add("withgrantoption", withgrantoption_);
                    cmd.ExecuteNonQuery();

                    //cập nhật lại Privilge
                    string sql = "select * from DBA_COL_PRIVS where TABLE_NAME LIKE 'QLDA_%' ";

                    OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    PrivilegeUI.data_grid_view2.DataSource = dt1;
                }
                else if (privil.Text.ToString() == "SELECT")
                {
                    cmd.CommandText = "QLDA.grant_select_privilege";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("user_role", roleuser.Text.ToString());
                    cmd.Parameters.Add("schema_name", schema_name);
                    cmd.Parameters.Add("table_name", table.Text.ToString());
                    cmd.Parameters.Add("column_name", column_list);
                    cmd.Parameters.Add("withgrantoption", withgrantoption_);
                    cmd.ExecuteNonQuery();

                    //cập nhật lại Privilge
                    string sql = "select * from DBA_TAB_PRIVS where TABLE_NAME LIKE 'QLDA_%' OR TABLE_NAME LIKE 'V_QLDA_%'";

                    OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    PrivilegeUI.data_grid_view1.DataSource = dt1;
                }

                MessageBox.Show("Cấp quyền cho " + ((result_roleuser == "1") ? "user " : "role ") + roleuser.Text.ToString() + " thành công");
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
            this.Hide();
        }
    }
}
