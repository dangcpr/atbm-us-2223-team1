
namespace QLDeAn
{
    partial class DBAUI_TableView_CreateTable_F
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.COLUMN_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_TYPE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PRIMARY_KEY = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COLUMN_NAME,
            this.DATA_TYPE,
            this.PRIMARY_KEY});
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(826, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // COLUMN_NAME
            // 
            this.COLUMN_NAME.HeaderText = "COLUMN_NAME";
            this.COLUMN_NAME.MinimumWidth = 15;
            this.COLUMN_NAME.Name = "COLUMN_NAME";
            this.COLUMN_NAME.Width = 125;
            // 
            // DATA_TYPE
            // 
            this.DATA_TYPE.HeaderText = "DATA_TYPE";
            this.DATA_TYPE.MinimumWidth = 15;
            this.DATA_TYPE.Name = "DATA_TYPE";
            this.DATA_TYPE.Width = 125;
            // 
            // PRIMARY_KEY
            // 
            this.PRIMARY_KEY.HeaderText = "PRIMARY_KEY";
            this.PRIMARY_KEY.MinimumWidth = 15;
            this.PRIMARY_KEY.Name = "PRIMARY_KEY";
            this.PRIMARY_KEY.Width = 125;
            // 
            // DBAUI_TableView_CreateTable_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 524);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Name = "DBAUI_TableView_CreateTable_F";
            this.Text = "TẠO \"TABLE\"";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_NAME;
        private System.Windows.Forms.DataGridViewComboBoxColumn DATA_TYPE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PRIMARY_KEY;
    }
}