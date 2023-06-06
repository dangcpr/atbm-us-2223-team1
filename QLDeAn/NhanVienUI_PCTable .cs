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
    public partial class NhanVienUI_PCTable : UserControl
    {
        public static OracleConnection conNow;
        public NhanVienUI_PCTable()
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
                string selectPCsql = "";
                switch(LoginUI.roleUser)
                {
                    case "Nhân viên":
                    case "Trưởng dự án":
                    case "Tài chính":
                    case "Trưởng phòng":
                    case "Nhân sự":
                    case "Giám đốc":
                        selectPCsql = "SELECT * FROM QLDA.QLDA_PHANCONG";
                        break;
                    case "Quản lý":
                        selectPCsql = "SELECT * FROM QLDA.V_QLDA_PHANCONG_QL";
                        break;

                }
                OracleDataAdapter adapter = new OracleDataAdapter(selectPCsql, conNow) { SuppressGetDecimalInvalidCastException = true };
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

                if (LoginUI.roleUser != "Quản lý")
                {
                    string insertNVsql = "INSERT INTO QLDA.QLDA_PHANCONG (MaNV, MaDA, ThoiGian) VALUES (:MaNV, :MaDA, TO_DATE(:ThoiGian, 'DD/MM/YYYY'))";
                    OracleCommand cmd = new OracleCommand(insertNVsql, conNow);
                    cmd.Parameters.Add(new OracleParameter("MaNV", OracleDbType.Varchar2, MaNVTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("MaDA", OracleDbType.Varchar2, MaDATextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("ThoiGian", OracleDbType.Varchar2, ThoiGianTextBox.Text, System.Data.ParameterDirection.Input));

                    cmd.ExecuteNonQuery();

                    OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
                    cmdCommit.ExecuteNonQuery();
                }
                else
                {
                    string insertNVsql = "INSERT INTO QLDA.V_QLDA_PHANCONG_QL (MaNV, MaDA, ThoiGian) VALUES (:MaNV, :MaDA, TO_DATE(:ThoiGian, 'DD/MM/YYYY'))";
                    OracleCommand cmd = new OracleCommand(insertNVsql, conNow);
                    cmd.Parameters.Add(new OracleParameter("MaNV", OracleDbType.Varchar2, MaNVTextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("MaDA", OracleDbType.Varchar2, MaDATextBox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("ThoiGian", OracleDbType.Varchar2, ThoiGianTextBox.Text, System.Data.ParameterDirection.Input));

                    cmd.ExecuteNonQuery();

                    OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
                    cmdCommit.ExecuteNonQuery();
                }
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
                if (LoginUI.roleUser != "Quản lý")
                {
                    string updateNVsql = "UPDATE QLDA.QLDA_PHANCONG SET ThoiGian = TO_DATE(:ThoiGian, 'DD/MM/YYYY') WHERE MaNV = :MaNV AND MaDA = :MaDA";
                    OracleCommand cmd = new OracleCommand(updateNVsql, conNow);
                    cmd.Parameters.Add(new OracleParameter("ThoiGian", ThoiGianTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MaNV", MaNVTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MaDA", MaDATextBox.Text));

                    OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
                    cmdCommit.ExecuteNonQuery();

                    int count_update = cmd.ExecuteNonQuery();
                    MessageBox.Show(count_update + " rows update success!");
                    return;
                }
                else
                {
                    string updateNVsql = "UPDATE QLDA.V_QLDA_PHANCONG_QL SET ThoiGian = TO_DATE(:ThoiGian, 'DD/MM/YYYY') WHERE MaNV = :MaNV AND MaDA = :MaDA";
                    OracleCommand cmd = new OracleCommand(updateNVsql, conNow);
                    cmd.Parameters.Add(new OracleParameter("ThoiGian", ThoiGianTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MaNV", MaNVTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MaDA", MaDATextBox.Text));

                    OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
                    cmdCommit.ExecuteNonQuery();

                    int count_update = cmd.ExecuteNonQuery();
                    MessageBox.Show(count_update + " rows update success!");
                    return;
                }
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
                if (LoginUI.roleUser != "Quản lý")
                {
                    string deleteNVsql = "DELETE FROM QLDA.QLDA_PHANCONG WHERE MaNV = :MaNV AND MaDA = :MaDA";
                    OracleCommand cmd = new OracleCommand(deleteNVsql, conNow);
                    cmd.Parameters.Add(new OracleParameter("MaNV", MaNVTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MaDA", MaDATextBox.Text));
                    int count_delete = cmd.ExecuteNonQuery();

                    OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
                    cmdCommit.ExecuteNonQuery();

                    MessageBox.Show(count_delete + " rows delete success!");
                }
                else
                {
                    string deleteNVsql = "DELETE FROM QLDA.V_QLDA_PHANCONG_QL WHERE MaNV = :MaNV AND MaDA = :MaDA";
                    OracleCommand cmd = new OracleCommand(deleteNVsql, conNow);
                    cmd.Parameters.Add(new OracleParameter("MaNV", MaNVTextBox.Text));
                    cmd.Parameters.Add(new OracleParameter("MaDA", MaDATextBox.Text));
                    int count_delete = cmd.ExecuteNonQuery();

                    OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
                    cmdCommit.ExecuteNonQuery();

                    MessageBox.Show(count_delete + " rows delete success!");
                }
                
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
                MaNVTextBox.Text = row.Cells[0].Value.ToString();
                MaDATextBox.Text = row.Cells[1].Value.ToString();
                ThoiGianTextBox.Text = row.Cells[2].Value.ToString();
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
                    case "Trưởng phòng":
                    case "Nhân sự":
                    case "Giám đốc":
                        selectPBsql = "SELECT * FROM QLDA.QLDA_PHANCONG WHERE MADA = :MaDA AND MANV = :MaNV";
                        break;
                    case "Quản lý":
                        selectPBsql = "SELECT * FROM QLDA.V_QLDA_PHANCONG_QL WHERE MADA = :MaDA AND MANV = :MaNV";
                        break;
                }
                OracleCommand cmd = new OracleCommand(selectPBsql, conNow);
                cmd.BindByName = true;
                cmd.Parameters.Add(new OracleParameter("MaDA", searchDA.Text));
                cmd.Parameters.Add(new OracleParameter("MaNV", searchNV.Text));
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
