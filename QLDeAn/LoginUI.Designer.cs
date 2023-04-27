
namespace QLDeAn
{
    partial class LoginUI
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
            this.title = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.role = new System.Windows.Forms.ComboBox();
            this.label_role = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.title.Location = new System.Drawing.Point(209, 108);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(683, 55);
            this.title.TabIndex = 0;
            this.title.Text = "HỆ THỐNG QUẢN LÝ ĐỀ ÁN";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(275, 245);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(187, 25);
            this.label_user.TabIndex = 1;
            this.label_user.Text = "TÊN ĐĂNG NHẬP";
            this.label_user.Click += new System.EventHandler(this.label_user_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(275, 297);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(125, 25);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "MẬT KHẨU";
            this.label_password.Click += new System.EventHandler(this.label_password_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(494, 245);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(308, 27);
            this.username.TabIndex = 3;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(494, 297);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(308, 27);
            this.password.TabIndex = 4;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(449, 413);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(206, 54);
            this.login.TabIndex = 8;
            this.login.Text = "ĐĂNG NHẬP";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // role
            // 
            this.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "SYSDBA",
            "ADMIN"});
            this.role.Location = new System.Drawing.Point(494, 349);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(308, 28);
            this.role.TabIndex = 9;
            this.role.SelectedIndexChanged += new System.EventHandler(this.role_SelectedIndexChanged);
            // 
            // label_role
            // 
            this.label_role.AutoSize = true;
            this.label_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_role.Location = new System.Drawing.Point(275, 352);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(99, 25);
            this.label_role.TabIndex = 5;
            this.label_role.Text = "VAI TRÒ";
            this.label_role.Click += new System.EventHandler(this.label_role_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(1009, 577);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 33);
            this.Close.TabIndex = 10;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 622);
            this.ControlBox = false;
            this.Controls.Add(this.Close);
            this.Controls.Add(this.role);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label_role);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginUI";
            this.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.Load += new System.EventHandler(this.LoginUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.Label label_role;
        private System.Windows.Forms.Button Close;
    }
}

