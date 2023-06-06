
namespace QLDeAn
{
    partial class DBAUI_TableView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableView = new System.Windows.Forms.DataGridView();
            this.viewView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.createTableButton = new System.Windows.Forms.Button();
            this.createViewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableView
            // 
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Location = new System.Drawing.Point(25, 42);
            this.tableView.Name = "tableView";
            this.tableView.RowHeadersWidth = 51;
            this.tableView.RowTemplate.Height = 24;
            this.tableView.Size = new System.Drawing.Size(1034, 258);
            this.tableView.TabIndex = 0;
            // 
            // viewView
            // 
            this.viewView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewView.Location = new System.Drawing.Point(25, 341);
            this.viewView.Name = "viewView";
            this.viewView.RowHeadersWidth = 51;
            this.viewView.RowTemplate.Height = 24;
            this.viewView.Size = new System.Drawing.Size(1034, 258);
            this.viewView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "TABLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "VIEW";
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.Location = new System.Drawing.Point(1076, 52);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(166, 29);
            this.selectButton.TabIndex = 4;
            this.selectButton.Text = "SELECT DATA";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // createTableButton
            // 
            this.createTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTableButton.Location = new System.Drawing.Point(1076, 87);
            this.createTableButton.Name = "createTableButton";
            this.createTableButton.Size = new System.Drawing.Size(166, 29);
            this.createTableButton.TabIndex = 5;
            this.createTableButton.Text = "CREATE \"TABLE\"";
            this.createTableButton.UseVisualStyleBackColor = true;
            // 
            // createViewButton
            // 
            this.createViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createViewButton.Location = new System.Drawing.Point(1076, 122);
            this.createViewButton.Name = "createViewButton";
            this.createViewButton.Size = new System.Drawing.Size(166, 29);
            this.createViewButton.TabIndex = 6;
            this.createViewButton.Text = "CREATE \"VIEW\"";
            this.createViewButton.UseVisualStyleBackColor = true;
            // 
            // DBAUI_TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createViewButton);
            this.Controls.Add(this.createTableButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewView);
            this.Controls.Add(this.tableView);
            this.Name = "DBAUI_TableView";
            this.Size = new System.Drawing.Size(1261, 620);
            this.Load += new System.EventHandler(this.DBAUI_TableView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableView;
        private System.Windows.Forms.DataGridView viewView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button createTableButton;
        private System.Windows.Forms.Button createViewButton;
    }
}
