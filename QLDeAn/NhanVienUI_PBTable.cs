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
    public partial class NhanVienUI_PBTable : UserControl
    {
        public static OracleConnection conNow;
        public NhanVienUI_PBTable()
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
                        selectPBsql = "SELECT * FROM QLDA.QLDA_PHONGBAN";
                        break;

                }
                OracleDataAdapter adapter = new OracleDataAdapter(selectPBsql, conNow) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                NhanVienTableView.DataSource = dataTable;
            }
            catch (OracleException ex)
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
                
                string insertNVsql = "INSERT INTO QLDA.QLDA_PHONGBAN (MaPB, TenPB, TRPHG) VALUES (:MaPB, :TenPB, :TRPHG)";
                OracleCommand cmd = new OracleCommand(insertNVsql, conNow);
                cmd.Parameters.Add(new OracleParameter("MaPB", OracleDbType.Varchar2, MaPBTextBox.Text, System.Data.ParameterDirection.Input));
                    //cmd.Parameters.Add(new OracleParameter("MaNV", OracleDbType.Varchar2, MaNVTextBox.Text));
                cmd.Parameters.Add(new OracleParameter("TenPB", OracleDbType.Varchar2, TenPBTextBox.Text, System.Data.ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter("TRPHG", OracleDbType.Varchar2, TrPhgTextBox.Text, System.Data.ParameterDirection.Input));
                cmd.ExecuteNonQuery();

                OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
                cmdCommit.ExecuteNonQuery();

                MessageBox.Show("Insert success!");
            }
            catch (OracleException ex)
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
                
                string updateNVsql = "UPDATE QLDA.QLDA_PHONGBAN SET TenPB = :TenPB, TRPHG = :TRPHG WHERE MaPB = :MaPB";
                OracleCommand cmd = new OracleCommand(updateNVsql, conNow);
                cmd.Parameters.Add(new OracleParameter("TenPB", TenPBTextBox.Text));
                cmd.Parameters.Add(new OracleParameter("TRPHG", TrPhgTextBox.Text));
                cmd.Parameters.Add(new OracleParameter("MaPB", MaPBTextBox.Text));
                int count_update = cmd.ExecuteNonQuery();
                MessageBox.Show(count_update + " rows update success!");
                return;                            
            }
            catch (OracleException ex)
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

               string deleteNVsql = "DELETE FROM QLDA.QLDA_PHONGBAN WHERE MaPB = :MaPB";
               OracleCommand cmd = new OracleCommand(deleteNVsql, conNow);
               cmd.Parameters.Add(new OracleParameter("MaPB", MaPBTextBox.Text));
               cmd.ExecuteNonQuery();

               OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
               cmdCommit.ExecuteNonQuery();

               MessageBox.Show("Delete success!");
                
            }
            catch (OracleException ex)
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
                MaPBTextBox.Text = row.Cells[0].Value.ToString();
                TenPBTextBox.Text = row.Cells[1].Value.ToString();
                TrPhgTextBox.Text = row.Cells[2].Value.ToString();
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
                        selectPBsql = "SELECT * FROM QLDA.QLDA_PHONGBAN WHERE MAPB = :MaPB";
                        break;

                }
                OracleCommand cmd = new OracleCommand(selectPBsql, conNow);
                cmd.BindByName = true;
                cmd.Parameters.Add(new OracleParameter("MaPB", searchPB.Text));
                OracleDataAdapter adapter = new OracleDataAdapter(cmd) { SuppressGetDecimalInvalidCastException = true };
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                NhanVienTableView.DataSource = dataTable;
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


    }
}
