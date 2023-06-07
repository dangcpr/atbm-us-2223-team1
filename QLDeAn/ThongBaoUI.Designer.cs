
namespace QLDeAn
{
    partial class ThongBaoUI
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
            this.ThongBaoView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.selectData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ThongBaoView)).BeginInit();
            this.SuspendLayout();
            // 
            // ThongBaoView
            // 
            this.ThongBaoView.AllowUserToOrderColumns = true;
            this.ThongBaoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ThongBaoView.Location = new System.Drawing.Point(13, 16);
            this.ThongBaoView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThongBaoView.Name = "ThongBaoView";
            this.ThongBaoView.RowHeadersWidth = 51;
            this.ThongBaoView.Size = new System.Drawing.Size(1201, 506);
            this.ThongBaoView.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(1129, 530);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(85, 34);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "ĐÓNG";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // selectData
            // 
            this.selectData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectData.Location = new System.Drawing.Point(984, 530);
            this.selectData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectData.Name = "selectData";
            this.selectData.Size = new System.Drawing.Size(137, 34);
            this.selectData.TabIndex = 4;
            this.selectData.Text = "LẤY DỮ LIỆU";
            this.selectData.UseVisualStyleBackColor = true;
            this.selectData.Click += new System.EventHandler(this.selectData_Click);
            // 
            // ThongBaoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 575);
            this.ControlBox = false;
            this.Controls.Add(this.selectData);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.ThongBaoView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThongBaoUI";
            this.Text = "BẢNG \"THÔNG BÁO\"";
            this.Load += new System.EventHandler(this.ThongBaoUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongBaoView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ThongBaoView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button selectData;
    }
}