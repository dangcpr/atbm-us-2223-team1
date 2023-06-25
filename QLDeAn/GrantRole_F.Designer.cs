
namespace QLDeAn
{
    partial class GrantRole_F
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
            this.userrolelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grantButton = new System.Windows.Forms.Button();
            this.withadminoption = new System.Windows.Forms.CheckBox();
            this.role = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(391, 128);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 33);
            this.Close.TabIndex = 12;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // userrolelabel
            // 
            this.userrolelabel.AutoSize = true;
            this.userrolelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userrolelabel.ForeColor = System.Drawing.Color.Black;
            this.userrolelabel.Location = new System.Drawing.Point(24, 28);
            this.userrolelabel.Name = "userrolelabel";
            this.userrolelabel.Size = new System.Drawing.Size(188, 18);
            this.userrolelabel.TabIndex = 27;
            this.userrolelabel.Text = "User/Role cần cấp Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Role muốn cấp cho User/Role";
            // 
            // grantButton
            // 
            this.grantButton.Location = new System.Drawing.Point(223, 128);
            this.grantButton.Name = "grantButton";
            this.grantButton.Size = new System.Drawing.Size(162, 33);
            this.grantButton.TabIndex = 31;
            this.grantButton.Text = "Cấp Role";
            this.grantButton.UseVisualStyleBackColor = true;
            this.grantButton.Click += new System.EventHandler(this.grantButton_Click);
            // 
            // withadminoption
            // 
            this.withadminoption.AutoSize = true;
            this.withadminoption.Location = new System.Drawing.Point(285, 102);
            this.withadminoption.Name = "withadminoption";
            this.withadminoption.Size = new System.Drawing.Size(164, 20);
            this.withadminoption.TabIndex = 32;
            this.withadminoption.Text = "WITH ADMIN OPTION";
            this.withadminoption.UseVisualStyleBackColor = true;
            this.withadminoption.CheckedChanged += new System.EventHandler(this.withadminoption_CheckedChanged);
            // 
            // role
            // 
            this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.Location = new System.Drawing.Point(295, 65);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(162, 24);
            this.role.TabIndex = 34;
            this.role.TextChanged += new System.EventHandler(this.role_TextChanged);
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(295, 25);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(162, 24);
            this.user.TabIndex = 35;
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // GrantRole_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 170);
            this.ControlBox = false;
            this.Controls.Add(this.user);
            this.Controls.Add(this.role);
            this.Controls.Add(this.withadminoption);
            this.Controls.Add(this.grantButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userrolelabel);
            this.Controls.Add(this.Close);
            this.Name = "GrantRole_F";
            this.Text = "CẤP ROLE CHO USER/ROLE";
            this.Load += new System.EventHandler(this.GrantRole_F_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label userrolelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button grantButton;
        private System.Windows.Forms.CheckBox withadminoption;
        private System.Windows.Forms.TextBox role;
        private System.Windows.Forms.TextBox user;
    }
}