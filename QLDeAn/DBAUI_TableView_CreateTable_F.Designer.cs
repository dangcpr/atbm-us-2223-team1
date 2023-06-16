
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
            this.attributeTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabelTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.COLUMN_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_TYPE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SIZE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIMARY_KEY = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NOT_NULL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FOREIGN_KEY = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TABLE_REFERENCE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.COLUMN_REFERENCE = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.attributeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // attributeTable
            // 
            this.attributeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attributeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COLUMN_NAME,
            this.DATA_TYPE,
            this.SIZE,
            this.PRIMARY_KEY,
            this.NOT_NULL,
            this.FOREIGN_KEY,
            this.TABLE_REFERENCE,
            this.COLUMN_REFERENCE});
            this.attributeTable.Location = new System.Drawing.Point(16, 49);
            this.attributeTable.Name = "attributeTable";
            this.attributeTable.RowHeadersWidth = 51;
            this.attributeTable.RowTemplate.Height = 24;
            this.attributeTable.Size = new System.Drawing.Size(1112, 416);
            this.attributeTable.TabIndex = 0;
            this.attributeTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.attributeTable_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÊN TABLE";
            // 
            // tabelTextBox
            // 
            this.tabelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabelTextBox.Location = new System.Drawing.Point(140, 15);
            this.tabelTextBox.Name = "tabelTextBox";
            this.tabelTextBox.Size = new System.Drawing.Size(550, 27);
            this.tabelTextBox.TabIndex = 2;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(902, 471);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(110, 49);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "CREATE";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(1018, 471);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(110, 49);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "ĐÓNG";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // COLUMN_NAME
            // 
            this.COLUMN_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COLUMN_NAME.HeaderText = "COLUMN_NAME";
            this.COLUMN_NAME.MinimumWidth = 15;
            this.COLUMN_NAME.Name = "COLUMN_NAME";
            this.COLUMN_NAME.Width = 139;
            // 
            // DATA_TYPE
            // 
            this.DATA_TYPE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DATA_TYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DATA_TYPE.HeaderText = "DATA_TYPE";
            this.DATA_TYPE.Items.AddRange(new object[] {
            "INT",
            "FLOAT",
            "NUMBER",
            "DATE",
            "CHAR ",
            "NCHAR",
            "VARCHAR2",
            "NVARCHAR2",
            "VARCHAR"});
            this.DATA_TYPE.MinimumWidth = 15;
            this.DATA_TYPE.Name = "DATA_TYPE";
            this.DATA_TYPE.Width = 93;
            // 
            // SIZE
            // 
            this.SIZE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SIZE.HeaderText = "SIZE";
            this.SIZE.MinimumWidth = 6;
            this.SIZE.Name = "SIZE";
            this.SIZE.ReadOnly = true;
            this.SIZE.Width = 65;
            // 
            // PRIMARY_KEY
            // 
            this.PRIMARY_KEY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PRIMARY_KEY.HeaderText = "PRIMARY_KEY";
            this.PRIMARY_KEY.MinimumWidth = 15;
            this.PRIMARY_KEY.Name = "PRIMARY_KEY";
            this.PRIMARY_KEY.Width = 107;
            // 
            // NOT_NULL
            // 
            this.NOT_NULL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NOT_NULL.HeaderText = "NOT_NULL";
            this.NOT_NULL.MinimumWidth = 6;
            this.NOT_NULL.Name = "NOT_NULL";
            this.NOT_NULL.Width = 83;
            // 
            // FOREIGN_KEY
            // 
            this.FOREIGN_KEY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FOREIGN_KEY.HeaderText = "FOREIGN_KEY";
            this.FOREIGN_KEY.MinimumWidth = 6;
            this.FOREIGN_KEY.Name = "FOREIGN_KEY";
            this.FOREIGN_KEY.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FOREIGN_KEY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FOREIGN_KEY.Width = 129;
            // 
            // TABLE_REFERENCE
            // 
            this.TABLE_REFERENCE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TABLE_REFERENCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TABLE_REFERENCE.HeaderText = "TABLE_REFERENCE";
            this.TABLE_REFERENCE.MinimumWidth = 6;
            this.TABLE_REFERENCE.Name = "TABLE_REFERENCE";
            this.TABLE_REFERENCE.ReadOnly = true;
            this.TABLE_REFERENCE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TABLE_REFERENCE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TABLE_REFERENCE.Width = 169;
            // 
            // COLUMN_REFERENCE
            // 
            this.COLUMN_REFERENCE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COLUMN_REFERENCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COLUMN_REFERENCE.HeaderText = "COLUMN_REFERENCE";
            this.COLUMN_REFERENCE.MinimumWidth = 6;
            this.COLUMN_REFERENCE.Name = "COLUMN_REFERENCE";
            this.COLUMN_REFERENCE.ReadOnly = true;
            this.COLUMN_REFERENCE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.COLUMN_REFERENCE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.COLUMN_REFERENCE.Width = 183;
            // 
            // DBAUI_TableView_CreateTable_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 532);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.tabelTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attributeTable);
            this.Name = "DBAUI_TableView_CreateTable_F";
            this.Text = "TẠO \"TABLE\"";
            this.Load += new System.EventHandler(this.DBAUI_TableView_CreateTable_F_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attributeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView attributeTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tabelTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUMN_NAME;
        private System.Windows.Forms.DataGridViewComboBoxColumn DATA_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIZE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PRIMARY_KEY;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NOT_NULL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FOREIGN_KEY;
        private System.Windows.Forms.DataGridViewComboBoxColumn TABLE_REFERENCE;
        private System.Windows.Forms.DataGridViewComboBoxColumn COLUMN_REFERENCE;
    }
}