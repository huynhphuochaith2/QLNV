
namespace GUI
{
    partial class frmDoiMatKhau
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
            this.txtTenNguoiDung = new System.Windows.Forms.TextBox();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.chkHienThi = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTenNguoiDung
            // 
            this.txtTenNguoiDung.Location = new System.Drawing.Point(200, 28);
            this.txtTenNguoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNguoiDung.Name = "txtTenNguoiDung";
            this.txtTenNguoiDung.Size = new System.Drawing.Size(132, 22);
            this.txtTenNguoiDung.TabIndex = 0;
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(200, 60);
            this.txtMKCu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(132, 22);
            this.txtMKCu.TabIndex = 1;
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(200, 92);
            this.txtMKMoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(132, 22);
            this.txtMKMoi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên người dùng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCapNhat.Location = new System.Drawing.Point(87, 174);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 28);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // chkHienThi
            // 
            this.chkHienThi.AutoSize = true;
            this.chkHienThi.Location = new System.Drawing.Point(200, 137);
            this.chkHienThi.Name = "chkHienThi";
            this.chkHienThi.Size = new System.Drawing.Size(140, 21);
            this.chkHienThi.TabIndex = 16;
            this.chkHienThi.Text = "Hiển thị mật khẩu";
            this.chkHienThi.UseVisualStyleBackColor = true;
            this.chkHienThi.CheckedChanged += new System.EventHandler(this.chkHienThi_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(213, 174);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 253);
            this.Controls.Add(this.chkHienThi);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.txtTenNguoiDung);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDoiMatKhau";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        public System.Windows.Forms.TextBox txtTenNguoiDung;
        public System.Windows.Forms.TextBox txtMKCu;
        public System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.CheckBox chkHienThi;
    }
}