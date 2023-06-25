using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLDeAn
{
    public partial class DBAUI_TableView_CreateTable_F : Form
    {
        public DBAUI_TableView_CreateTable_F()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabelTextBox.TextLength == 0)
                {
                    MessageBox.Show("Vui lòng nhập tên bảng!");
                    return;
                }
                if (attributeTable.Rows.Count == 0)
                {
                    MessageBox.Show("Vui lòng nhập thuộc tính cho bảng!");
                    return;
                }
                string tableName = tabelTextBox.Text;
                string sql = "CREATE TABLE " + tableName + "(";
                foreach (DataGridViewRow row in attributeTable.Rows)
                {
                    if(row.Index == attributeTable.Rows.Count - 1)
                    {
                        break;
                    }
                    if (row.Cells["COLUMN_NAME"].Value == null || row.Cells["COLUMN_NAME"].Value.ToString() == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thuộc tính!");
                        return;
                    }
                    
                    sql += row.Cells["COLUMN_NAME"].Value.ToString() + ' ' + row.Cells["DATA_TYPE"].Value.ToString() + "";
                    if (row.Cells["SIZE"].Value != null) sql += '(' + row.Cells["SIZE"].Value.ToString() + ") ";
                    sql += Convert.ToBoolean(row.Cells["NOT_NULL"].Value) ? " NOT NULL " : "";
                    if (row.Cells["FOREIGN_KEY"].Value != null && Convert.ToBoolean(row.Cells["FOREIGN_KEY"].Value))
                    {
                        sql += "REFERENCES " + row.Cells["TABLE_REFERENCE"].Value.ToString() + "(" + row.Cells["COLUMN_REFERENCE"].Value.ToString() + ")";
                    }
                    sql += ',';
                }
                string PK = "";
                foreach (DataGridViewRow row in attributeTable.Rows)
                {
                    if (row.Cells["PRIMARY_KEY"].Value != null && Convert.ToBoolean(row.Cells["PRIMARY_KEY"].Value))
                    {
                        if (PK == "") PK += "PRIMARY KEY(";
                        PK += row.Cells["COLUMN_NAME"].Value.ToString() + ",";
                    }
                }
                if (PK != "")
                {
                    PK = PK.Remove(PK.Length - 1, 1);
                    PK += "),";

                    sql += PK;
                }
                sql = sql.Remove(sql.Length - 1, 1);
                sql += ")";
                OracleCommand cmd = new OracleCommand(sql, LoginUI.con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tạo bảng thành công!");
            } 
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<string> GetTableReference()
        {
            var tableReference = new List<string>();
            //Oracle SQL select Table
            var cmd = new OracleCommand();

            cmd.Connection = LoginUI.con;
            cmd.CommandText = "SELECT table_name FROM user_tables";
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tableReference.Add(reader.GetString(0));
            }

            return tableReference;
        }
        private List<string> GetAttributeTableReference(string tableName)
        {
            var tableReference = new List<string>();

            var cmd = new OracleCommand();
            //con.ConnectionString = connectionString;
            //con.Open();
            cmd.Connection = LoginUI.con;
            cmd.CommandText = "SELECT column_name FROM user_tab_columns WHERE table_name = :tablename";
            cmd.Parameters.Add(new OracleParameter("tablename", tableName));
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tableReference.Add(reader.GetString(0));
            }

            return tableReference;
        }
        private void DBAUI_TableView_CreateTable_F_Load(object sender, EventArgs e)
        {
            var tableReference = GetTableReference();
            foreach (var table in tableReference)
            {
                TABLE_REFERENCE.Items.Add(table);
            }
        }
        
        private void attributeTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool openCreateTable = false;
            if (fc.Count == 0)
            {
                return;
            }
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "DBAUI_TableView_CreateTable_F")
                {
                    openCreateTable = true;
                }
            }
            if (openCreateTable == false)
            {
                return;
            }   
            if (e.ColumnIndex == 6)
            {
                if (attributeTable.Rows[e.RowIndex].Cells[6].Value == null) return;
                attributeTable.Rows[e.RowIndex].Cells[7].Value = null;
                var attributeReference = GetAttributeTableReference(attributeTable.Rows[e.RowIndex].Cells[6].Value.ToString());
                DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)attributeTable.Rows[e.RowIndex].Cells[7];
                cbCell.Items.Clear();
                foreach (var attribute in attributeReference)
                {
                    cbCell.Items.Add(attribute);
                }
            }
            if (e.ColumnIndex == 5)
            {
                DataGridViewCheckBoxCell cbCell = (DataGridViewCheckBoxCell)attributeTable.Rows[e.RowIndex].Cells[5];
                if(!Convert.ToBoolean(cbCell.Value))
                {
                    attributeTable.Rows[e.RowIndex].Cells[6].Value = null;
                    attributeTable.Rows[e.RowIndex].Cells[7].Value = null;
                    attributeTable.Rows[e.RowIndex].Cells[6].ReadOnly = true;
                    attributeTable.Rows[e.RowIndex].Cells[7].ReadOnly = true;
                }
                else
                {
                    attributeTable.Rows[e.RowIndex].Cells[6].ReadOnly = false;
                    attributeTable.Rows[e.RowIndex].Cells[7].ReadOnly = false;
                }
            }
            if(e.ColumnIndex == 1)
            {
                DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)attributeTable.Rows[e.RowIndex].Cells[1];
                if (cbCell.Value.ToString().Contains("CHAR") == true)
                {
                    attributeTable.Rows[e.RowIndex].Cells[2].ReadOnly = false;
                }
                else
                {
                    attributeTable.Rows[e.RowIndex].Cells[2].ReadOnly = true;
                    attributeTable.Rows[e.RowIndex].Cells[2].Value = null;
                }

            }
        }
    }
}
