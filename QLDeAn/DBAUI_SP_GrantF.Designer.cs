
namespace QLDeAn
{
    partial class DBAUI_SP_GrantF
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
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.privilege = new System.Windows.Forms.Label();
            this.grantRevokeButton = new System.Windows.Forms.Button();
            this.granteeTextBox = new System.Windows.Forms.TextBox();
            this.privilBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.activityBox = new System.Windows.Forms.ComboBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(640, 218);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 31);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "ĐÓNG";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHỦ THỂ";
            // 
            // privilege
            // 
            this.privilege.AutoSize = true;
            this.privilege.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilege.Location = new System.Drawing.Point(57, 139);
            this.privilege.Name = "privilege";
            this.privilege.Size = new System.Drawing.Size(176, 20);
            this.privilege.TabIndex = 2;
            this.privilege.Text = "QUYỀN HỆ THỐNG";
            // 
            // grantRevokeButton
            // 
            this.grantRevokeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantRevokeButton.Location = new System.Drawing.Point(514, 218);
            this.grantRevokeButton.Name = "grantRevokeButton";
            this.grantRevokeButton.Size = new System.Drawing.Size(120, 31);
            this.grantRevokeButton.TabIndex = 3;
            this.grantRevokeButton.Text = "THỰC HIỆN";
            this.grantRevokeButton.UseVisualStyleBackColor = true;
            this.grantRevokeButton.Click += new System.EventHandler(this.grantRevokeButton_Click);
            // 
            // granteeTextBox
            // 
            this.granteeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.granteeTextBox.Location = new System.Drawing.Point(266, 92);
            this.granteeTextBox.Name = "granteeTextBox";
            this.granteeTextBox.Size = new System.Drawing.Size(411, 27);
            this.granteeTextBox.TabIndex = 4;
            // 
            // privilBox
            // 
            this.privilBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilBox.FormattingEnabled = true;
            this.privilBox.Location = new System.Drawing.Point(266, 136);
            this.privilBox.Name = "privilBox";
            this.privilBox.Size = new System.Drawing.Size(411, 28);
            this.privilBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "THAO TÁC";
            // 
            // activityBox
            // 
            this.activityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityBox.FormattingEnabled = true;
            this.activityBox.Items.AddRange(new object[] {
            "CẤP QUYỀN",
            "HỦY QUYỀN"});
            this.activityBox.Location = new System.Drawing.Point(266, 50);
            this.activityBox.Name = "activityBox";
            this.activityBox.Size = new System.Drawing.Size(411, 28);
            this.activityBox.TabIndex = 7;
            this.activityBox.SelectedIndexChanged += new System.EventHandler(this.activityBox_SelectedIndexChanged);
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Enabled = false;
            this.checkBoxAdmin.Location = new System.Drawing.Point(503, 170);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(169, 21);
            this.checkBoxAdmin.TabIndex = 8;
            this.checkBoxAdmin.Text = "WITH ADMIN OPTION";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // DBAUI_SP_GrantF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 261);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxAdmin);
            this.Controls.Add(this.activityBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.privilBox);
            this.Controls.Add(this.granteeTextBox);
            this.Controls.Add(this.grantRevokeButton);
            this.Controls.Add(this.privilege);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Name = "DBAUI_SP_GrantF";
            this.Text = "CẤP/HỦY QUYỀN HỆ THỐNG";
            this.Load += new System.EventHandler(this.DBAUI_SP_GrantF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label privilege;
        private System.Windows.Forms.Button grantRevokeButton;
        private System.Windows.Forms.TextBox granteeTextBox;
        public System.Windows.Forms.ComboBox privilBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox activityBox;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
    }
}