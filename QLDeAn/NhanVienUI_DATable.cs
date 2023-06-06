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
using System.Data.OleDb;
using System.Globalization;

namespace QLDeAn
{
    public partial class NhanVienUI_DATable : UserControl
    {
        public static OracleConnection conNow;
        public NhanVienUI_DATable()
        {

            InitializeComponent();
        }        
        
        private void NhanVienUI_PCTable_Load(object sender, EventArgs e)
        {

        }

        private void selectData_Click(object sender, EventArgs e)
        {
            try
            {
                conNow = LoginUI.con;
                string selectPBsql = "";
                switch(LoginUI.roleUser)
                {
                    case "Nhân viên":
                    case "Trưởng dự án":
                    case "Tài chính":
                    case "Quản lý":
                    case "Trưởng phòng":
                    case "Nhân sự":
                    case "Giám đốc":
                        selectPBsql = "SELECT * FROM QLDA.QLDA_DEAN";
                        break;

                }
                OracleDataAdapter adapter = new OracleDataAdapter(selectPBsql, conNow) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                NhanVienTableView.DataSource = dataTable;
            }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void insertData_Click(object sender, EventArgs e)
        {
            //Insert data from TextBox
            try
            {
                conNow = LoginUI.con;
                
                string insertNVsql = "INSERT INTO QLDA.QLDA_DEAN (MaDA, TenDA, NgayBD, Phong) VALUES (:MaDA, :TenDA, TO_DATE(:NgayBD, 'DD/MM/YYYY'), :Phong)";
                OracleCommand cmd = new OracleCommand(insertNVsql, conNow);
                cmd.Parameters.Add(new OracleParameter("MaDA", OracleDbType.Varchar2, MaDATextBox.Text, System.Data.ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter("TenDA", OracleDbType.Varchar2, TenDATextBox.Text, System.Data.ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter("NgayBD", OracleDbType.Varchar2, NgayBDTextBox.Text, System.Data.ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter("Phong", OracleDbType.Varchar2, PhongTextBox.Text, System.Data.ParameterDirection.Input));

                cmd.ExecuteNonQuery();

                OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
                cmdCommit.ExecuteNonQuery();
                
                MessageBox.Show("Insert success!");
            }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void updateData_Click(object sender, EventArgs e)
        {
            //Update data from TextBox to QLDA_NHANVIEN (NgaySinh,DiaChi,SDT)     
            try
            {
                conNow = LoginUI.con;
                
                string updateNVsql = "UPDATE QLDA.QLDA_DEAN SET TenDA = :TenDA, NgayBD = TO_DATE(:NgayBD, 'DD/MM/YYYY'), Phong = :Phong WHERE MaDA = :MaDA";
                OracleCommand cmd = new OracleCommand(updateNVsql, conNow);
                cmd.Parameters.Add(new OracleParameter("TenDA", TenDATextBox.Text));
                cmd.Parameters.Add(new OracleParameter("NgayBD", NgayBDTextBox.Text));
                cmd.Parameters.Add(new OracleParameter("Phong", PhongTextBox.Text));
                cmd.Parameters.Add(new OracleParameter("MaDA", MaDATextBox.Text));
                int count_update = cmd.ExecuteNonQuery();
                MessageBox.Show(count_update + " rows update success!");
                return;                            
            }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }       
        }

        private void deleteData_Click(object sender, EventArgs e)
        {
            //Delete data from TextBox to QLDA_NHANVIEN
            conNow = LoginUI.con;
            try
            {

               string deleteNVsql = "DELETE FROM QLDA.QLDA_DEAN WHERE MaDA = :MaDA";
               OracleCommand cmd = new OracleCommand(deleteNVsql, conNow);
               cmd.Parameters.Add(new OracleParameter("MaDA", MaDATextBox.Text));
               int count_delete =  cmd.ExecuteNonQuery();

               OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
               cmdCommit.ExecuteNonQuery();

               MessageBox.Show(count_delete + " rows delete success!");

            }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void NhanVienTableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NhanVienTableView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Fill in Textbox when clicking a row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.NhanVienTableView.Rows[e.RowIndex];
                MaDATextBox.Text = row.Cells[0].Value.ToString();
                TenDATextBox.Text = row.Cells[1].Value.ToString();
                NgayBDTextBox.Text = row.Cells[2].Value.ToString();
                PhongTextBox.Text = row.Cells[3].Value.ToString();
            }

        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                conNow = LoginUI.con;
                string selectPBsql = "";
                switch (LoginUI.roleUser)
                {
                    case "Nhân viên":
                    case "Trưởng dự án":
                    case "Tài chính":
                    case "Quản lý":
                    case "Trưởng phòng":
                    case "Nhân sự":
                    case "Giám đốc":
                        selectPBsql = "SELECT * FROM QLDA.QLDA_DEAN WHERE MADA = :MaDA";
                        break;

                }
                OracleCommand cmd = new OracleCommand(selectPBsql, conNow);
                cmd.BindByName = true;
                cmd.Parameters.Add(new OracleParameter("MaDA", searchDA.Text));
                OracleDataAdapter adapter = new OracleDataAdapter(cmd) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                NhanVienTableView.DataSource = dataTable;
            }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


    }
}
