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
    public partial class RevokePrivil_F : Form
    {
        public RevokePrivil_F()
        {
            InitializeComponent();
        }

        public static OracleConnection conNow;
        public static string result_roleuser;

        private void RevokePrivil_F_Load(object sender, EventArgs e)
        {
            conNow = LoginUI.con;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tableview_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insertBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void userroleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void revokeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (userroleBox.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập Username hoặc Role");
                    return;
                }
                if (TVcomboBox.Text.Length == 0)
                {
                    MessageBox.Show("Vui lòng nhập Table hoặc View");
                    return;
                }
                if (selectCheck.Checked == false && insertCheck.Checked == false && updateCheck.Checked == false && deleteCheck.Checked == false)
                {
                    MessageBox.Show("Vui lòng nhập chọn quyền cần thu hồi");
                    return;
                }
                else
                {
                    OracleCommand cmd = new OracleCommand();

                    cmd.Connection = conNow;
                    cmd.CommandText = "QLDA.revoke_privil";
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter inParam1 = cmd.Parameters.Add("username", OracleDbType.Varchar2);
                    inParam1.Direction = ParameterDirection.Input;
                    inParam1.Value = userroleBox.Text;
                    string privil = "";

                    OracleCommand get_schema_name = conNow.CreateCommand();
                    get_schema_name.CommandText = "select owner from dba_tables where table_name = \'" + TVcomboBox.Text + '\'';
                    OracleDataReader reader = get_schema_name.ExecuteReader();
                    reader.Read();
                    string schema_name = reader.GetString(0);

                    if (selectCheck.Checked == true)
                    {
                        string view = schema_name + "." + "V_" + TVcomboBox.Text + "_" + userroleBox.Text;
                        OracleParameter inParam2 = cmd.Parameters.Add("table_view", OracleDbType.Varchar2);
                        inParam2.Direction = ParameterDirection.Input;
                        inParam2.Value = view;

                        privil += "SELECT";
                    }
                    else
                    {
                        OracleParameter inParam2 = cmd.Parameters.Add("table_view", OracleDbType.Varchar2);
                        inParam2.Direction = ParameterDirection.Input;
                        inParam2.Value = schema_name + "." + TVcomboBox.Text;

                        //privl = insert, update, delete nếu cả 4 ô được chọn (loại nếu không được chọn)

                        if (insertCheck.Checked == true)
                        {
                            privil += "INSERT";
                        }
                        if (updateCheck.Checked == true)
                        {
                            if (privil != "")
                            {
                                privil += ",";
                            }
                            privil += "UPDATE";
                        }
                        if (deleteCheck.Checked == true)
                        {
                            if (privil != "")
                            {
                                privil += ",";
                            }
                            privil += "DELETE";
                        }
                    }
                    OracleParameter inParam3 = cmd.Parameters.Add("privil", OracleDbType.Varchar2);
                    inParam3.Direction = ParameterDirection.Input;
                    inParam3.Value = privil;

                    OracleParameter outParam = cmd.Parameters.Add("res", OracleDbType.Int32);
                    outParam.Direction = ParameterDirection.Output;

                    // Thực thi stored procedure
                    cmd.ExecuteNonQuery();

                    // Lấy giá trị của tham số OUTPUT
                    string res = outParam.Value.ToString();

                    if (res == "1")
                    {
                        MessageBox.Show("Thu hồi quyền thành công");


                        //cập nhật lại Privilge
                        string sql = "select * from DBA_TAB_PRIVS where TABLE_NAME LIKE 'QLDA_%' OR TABLE_NAME LIKE 'V_QLDA_%' ";

                        OracleDataAdapter da = new OracleDataAdapter(sql, conNow);
                        DataTable dt1 = new DataTable();
                        da.Fill(dt1);
                        PrivilegeUI.data_grid_view1.DataSource = dt1;

                        //cập nhật lại Privilge
                        string sql2 = "select * from DBA_COL_PRIVS where TABLE_NAME LIKE 'QLDA_%' ";

                        OracleDataAdapter da2 = new OracleDataAdapter(sql2, conNow);
                        DataTable dt2 = new DataTable();
                        da2.Fill(dt2);
                        PrivilegeUI.data_grid_view2.DataSource = dt2;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thu hồi quyền không thành công");
                        return;
                    }

                   
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void reTable_Click(object sender, EventArgs e)
        {

        }

        private void deleteBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void updateBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void selectBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
