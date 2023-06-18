namespace QLDeAn
{
    partial class DBA_Audit
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
            this.label1 = new System.Windows.Forms.Label();
            this.auditTable = new System.Windows.Forms.DataGridView();
            this.selectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.auditTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "AUDIT";
            // 
            // auditTable
            // 
            this.auditTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.auditTable.Location = new System.Drawing.Point(28, 42);
            this.auditTable.Name = "auditTable";
            this.auditTable.RowHeadersWidth = 51;
            this.auditTable.RowTemplate.Height = 24;
            this.auditTable.Size = new System.Drawing.Size(1205, 555);
            this.auditTable.TabIndex = 4;
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.Location = new System.Drawing.Point(1067, 10);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(166, 29);
            this.selectButton.TabIndex = 5;
            this.selectButton.Text = "SELECT DATA";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // DBA_Audit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.auditTable);
            this.Controls.Add(this.label1);
            this.Name = "DBA_Audit";
            this.Size = new System.Drawing.Size(1261, 620);
            ((System.ComponentModel.ISupportInitialize)(this.auditTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView auditTable;
        private System.Windows.Forms.Button selectButton;
    }
}
