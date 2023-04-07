
using System.Drawing;
using System.Windows.Forms;

namespace QLDeAn
{
    partial class RevokePrivil_F
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
            this.Close = new System.Windows.Forms.Button();
            this.tableview = new System.Windows.Forms.Label();
            this.userroleBox = new System.Windows.Forms.TextBox();
            this.reTable = new System.Windows.Forms.Label();
            this.preLabel = new System.Windows.Forms.Label();
            this.selectCheck = new System.Windows.Forms.CheckBox();
            this.insertCheck = new System.Windows.Forms.CheckBox();
            this.updateCheck = new System.Windows.Forms.CheckBox();
            this.deleteCheck = new System.Windows.Forms.CheckBox();
            this.revokeButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TVcomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.SystemColors.Control;
            this.Close.Location = new System.Drawing.Point(423, 186);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 33);
            this.Close.TabIndex = 12;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // tableview
            // 
            this.tableview.AutoSize = true;
            this.tableview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableview.Location = new System.Drawing.Point(12, 85);
            this.tableview.Name = "tableview";
            this.tableview.Size = new System.Drawing.Size(89, 18);
            this.tableview.TabIndex = 13;
            this.tableview.Text = "Table/View";
            this.tableview.UseWaitCursor = true;
            this.tableview.Click += new System.EventHandler(this.tableview_Click);
            // 
            // userroleBox
            // 
            this.userroleBox.Location = new System.Drawing.Point(157, 33);
            this.userroleBox.Name = "userroleBox";
            this.userroleBox.Size = new System.Drawing.Size(341, 22);
            this.userroleBox.TabIndex = 14;
            this.userroleBox.TextChanged += new System.EventHandler(this.userroleBox_TextChanged);
            // 
            // reTable
            // 
            this.reTable.AutoSize = true;
            this.reTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reTable.Location = new System.Drawing.Point(12, 37);
            this.reTable.Name = "reTable";
            this.reTable.Size = new System.Drawing.Size(129, 18);
            this.reTable.TabIndex = 15;
            this.reTable.Text = "From User/Role";
            this.reTable.Click += new System.EventHandler(this.reTable_Click);
            // 
            // preLabel
            // 
            this.preLabel.AutoSize = true;
            this.preLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preLabel.Location = new System.Drawing.Point(12, 135);
            this.preLabel.Name = "preLabel";
            this.preLabel.Size = new System.Drawing.Size(81, 18);
            this.preLabel.TabIndex = 16;
            this.preLabel.Text = "Privileges";
            this.preLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // selectCheck
            // 
            this.selectCheck.AutoSize = true;
            this.selectCheck.Location = new System.Drawing.Point(157, 136);
            this.selectCheck.Name = "selectCheck";
            this.selectCheck.Size = new System.Drawing.Size(69, 21);
            this.selectCheck.TabIndex = 17;
            this.selectCheck.Text = "Select";
            this.selectCheck.UseVisualStyleBackColor = true;
            this.selectCheck.CheckedChanged += new System.EventHandler(this.selectBox_CheckedChanged);
            // 
            // insertCheck
            // 
            this.insertCheck.AutoSize = true;
            this.insertCheck.Location = new System.Drawing.Point(241, 136);
            this.insertCheck.Name = "insertCheck";
            this.insertCheck.Size = new System.Drawing.Size(65, 21);
            this.insertCheck.TabIndex = 18;
            this.insertCheck.Text = "Insert";
            this.insertCheck.UseVisualStyleBackColor = true;
            this.insertCheck.CheckedChanged += new System.EventHandler(this.insertBox_CheckedChanged);
            // 
            // updateCheck
            // 
            this.updateCheck.AutoSize = true;
            this.updateCheck.Location = new System.Drawing.Point(327, 136);
            this.updateCheck.Name = "updateCheck";
            this.updateCheck.Size = new System.Drawing.Size(76, 21);
            this.updateCheck.TabIndex = 19;
            this.updateCheck.Text = "Update";
            this.updateCheck.UseVisualStyleBackColor = true;
            this.updateCheck.CheckedChanged += new System.EventHandler(this.updateBox_CheckedChanged);
            // 
            // deleteCheck
            // 
            this.deleteCheck.AutoSize = true;
            this.deleteCheck.Location = new System.Drawing.Point(427, 136);
            this.deleteCheck.Name = "deleteCheck";
            this.deleteCheck.Size = new System.Drawing.Size(71, 21);
            this.deleteCheck.TabIndex = 20;
            this.deleteCheck.Text = "Delete";
            this.deleteCheck.UseVisualStyleBackColor = true;
            this.deleteCheck.CheckedChanged += new System.EventHandler(this.deleteBox_CheckedChanged);
            // 
            // revokeButton
            // 
            this.revokeButton.BackColor = System.Drawing.SystemColors.Control;
            this.revokeButton.Location = new System.Drawing.Point(147, 177);
            this.revokeButton.Name = "revokeButton";
            this.revokeButton.Size = new System.Drawing.Size(120, 50);
            this.revokeButton.TabIndex = 21;
            this.revokeButton.Text = "REVOKE";
            this.revokeButton.UseVisualStyleBackColor = false;
            this.revokeButton.Click += new System.EventHandler(this.revokeButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // TVcomboBox
            // 
            this.TVcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TVcomboBox.FormattingEnabled = true;
            this.TVcomboBox.Location = new System.Drawing.Point(157, 85);
            this.TVcomboBox.Items.AddRange(new object[] {
            "QLDA_NHANVIEN",
            "QLDA_DEAN",
            "QLDA_PHANCONG",
            "QLDA_PHONGBAN"});
            this.TVcomboBox.Name = "TVcomboBox";
            this.TVcomboBox.Size = new System.Drawing.Size(341, 24);
            this.TVcomboBox.TabIndex = 22;
            // 
            // RevokePrivil_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 241);
            this.ControlBox = false;
            this.Controls.Add(this.TVcomboBox);
            this.Controls.Add(this.revokeButton);
            this.Controls.Add(this.deleteCheck);
            this.Controls.Add(this.updateCheck);
            this.Controls.Add(this.insertCheck);
            this.Controls.Add(this.selectCheck);
            this.Controls.Add(this.preLabel);
            this.Controls.Add(this.reTable);
            this.Controls.Add(this.userroleBox);
            this.Controls.Add(this.tableview);
            this.Controls.Add(this.Close);
            this.Name = "RevokePrivil_F";
            this.Text = "THU HỒI QUYỀN CỦA ROLE/USER";
            this.Load += new System.EventHandler(this.RevokePrivil_F_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label tableview;
        private System.Windows.Forms.TextBox userroleBox;
        private System.Windows.Forms.Label reTable;
        private System.Windows.Forms.Label preLabel;
        private System.Windows.Forms.CheckBox selectCheck;
        private System.Windows.Forms.CheckBox insertCheck;
        private System.Windows.Forms.CheckBox updateCheck;
        private System.Windows.Forms.CheckBox deleteCheck;
        private System.Windows.Forms.Button revokeButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox TVcomboBox;
    }
}