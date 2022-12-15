namespace GUI
{
    partial class frmChinh
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.miniDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.miniDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.saoLưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phucHoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miniNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.miniQuaTrinhLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.miniPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.miniDuAn = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miniHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sttTTNguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttTTThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.miniLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.nghiệpVụToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuMain.Size = new System.Drawing.Size(1248, 30);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniDangNhap,
            this.mniDangXuat,
            this.miniDoiMatKhau,
            this.miniDuLieu});
            this.hệThốngToolStripMenuItem.Image = global::GUI.Properties.Resources.icons8_system_641;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(109, 28);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mniDangNhap
            // 
            this.mniDangNhap.Image = global::GUI.Properties.Resources.icons8_login_261;
            this.mniDangNhap.Name = "mniDangNhap";
            this.mniDangNhap.Size = new System.Drawing.Size(181, 26);
            this.mniDangNhap.Text = "Đăng nhập";
            this.mniDangNhap.Click += new System.EventHandler(this.mniDangNhap_Click);
            // 
            // mniDangXuat
            // 
            this.mniDangXuat.Image = global::GUI.Properties.Resources.icons8_log_out_32;
            this.mniDangXuat.Name = "mniDangXuat";
            this.mniDangXuat.Size = new System.Drawing.Size(181, 26);
            this.mniDangXuat.Text = "Đăng xuất";
            this.mniDangXuat.Click += new System.EventHandler(this.mniDangXuat_Click);
            // 
            // miniDoiMatKhau
            // 
            this.miniDoiMatKhau.Image = global::GUI.Properties.Resources.icons8_change_password_58;
            this.miniDoiMatKhau.Name = "miniDoiMatKhau";
            this.miniDoiMatKhau.Size = new System.Drawing.Size(181, 26);
            this.miniDoiMatKhau.Text = "Đổi mật khẩu";
            this.miniDoiMatKhau.Click += new System.EventHandler(this.miniDoiMatKhau_Click);
            // 
            // miniDuLieu
            // 
            this.miniDuLieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saoLưuToolStripMenuItem,
            this.phucHoiToolStripMenuItem});
            this.miniDuLieu.Name = "miniDuLieu";
            this.miniDuLieu.Size = new System.Drawing.Size(181, 26);
            this.miniDuLieu.Text = "Dữ liệu";
            // 
            // saoLưuToolStripMenuItem
            // 
            this.saoLưuToolStripMenuItem.Name = "saoLưuToolStripMenuItem";
            this.saoLưuToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.saoLưuToolStripMenuItem.Text = "Sao lưu";
            this.saoLưuToolStripMenuItem.Click += new System.EventHandler(this.saoLưuToolStripMenuItem_Click);
            // 
            // phucHoiToolStripMenuItem
            // 
            this.phucHoiToolStripMenuItem.Name = "phucHoiToolStripMenuItem";
            this.phucHoiToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.phucHoiToolStripMenuItem.Text = "Phục hồi";
            this.phucHoiToolStripMenuItem.Click += new System.EventHandler(this.phucHoiToolStripMenuItem_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniChucVu,
            this.mniNhanVien});
            this.danhMụcToolStripMenuItem.Image = global::GUI.Properties.Resources.icons8_sorting_50;
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(114, 28);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // mniChucVu
            // 
            this.mniChucVu.Image = global::GUI.Properties.Resources.icons8_book_26;
            this.mniChucVu.Name = "mniChucVu";
            this.mniChucVu.Size = new System.Drawing.Size(158, 26);
            this.mniChucVu.Text = "Chức vụ";
            this.mniChucVu.Click += new System.EventHandler(this.i_dmChucVu_Click);
            // 
            // mniNhanVien
            // 
            this.mniNhanVien.Image = global::GUI.Properties.Resources.icons8_staff_50;
            this.mniNhanVien.Name = "mniNhanVien";
            this.mniNhanVien.Size = new System.Drawing.Size(158, 26);
            this.mniNhanVien.Text = "Nhân viên";
            this.mniNhanVien.Click += new System.EventHandler(this.i_dmNhanVien_Click);
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miniNguoiDung,
            this.miniQuaTrinhLuong,
            this.miniPhongBan,
            this.miniDuAn,
            this.miniLuong});
            this.nghiệpVụToolStripMenuItem.Image = global::GUI.Properties.Resources.icons8_united_airlines_24;
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            this.nghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(115, 28);
            this.nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // miniNguoiDung
            // 
            this.miniNguoiDung.Image = global::GUI.Properties.Resources.icons8_user_48;
            this.miniNguoiDung.Name = "miniNguoiDung";
            this.miniNguoiDung.Size = new System.Drawing.Size(228, 30);
            this.miniNguoiDung.Text = "Người dùng";
            this.miniNguoiDung.Click += new System.EventHandler(this.miniNguoiDung_Click);
            // 
            // miniQuaTrinhLuong
            // 
            this.miniQuaTrinhLuong.Image = global::GUI.Properties.Resources.icons8_salary_64;
            this.miniQuaTrinhLuong.Name = "miniQuaTrinhLuong";
            this.miniQuaTrinhLuong.Size = new System.Drawing.Size(228, 30);
            this.miniQuaTrinhLuong.Text = "Quá trình lương";
            this.miniQuaTrinhLuong.Click += new System.EventHandler(this.miniQuaTrinhLuong_Click);
            // 
            // miniPhongBan
            // 
            this.miniPhongBan.Image = global::GUI.Properties.Resources.icons8_department_32;
            this.miniPhongBan.Name = "miniPhongBan";
            this.miniPhongBan.Size = new System.Drawing.Size(228, 30);
            this.miniPhongBan.Text = "Phòng ban";
            this.miniPhongBan.Click += new System.EventHandler(this.miniPhongBan_Click);
            // 
            // miniDuAn
            // 
            this.miniDuAn.Image = global::GUI.Properties.Resources.icons8_project_30;
            this.miniDuAn.Name = "miniDuAn";
            this.miniDuAn.Size = new System.Drawing.Size(228, 30);
            this.miniDuAn.Text = "Dự án";
            this.miniDuAn.Click += new System.EventHandler(this.miniDuAn_Click);
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miniHelp});
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(78, 28);
            this.hướngDẫnToolStripMenuItem.Text = "Trợ giúp";
            // 
            // miniHelp
            // 
            this.miniHelp.Name = "miniHelp";
            this.miniHelp.Size = new System.Drawing.Size(224, 26);
            this.miniHelp.Text = "Hướng dẫn sử dụng";
            this.miniHelp.Click += new System.EventHandler(this.miniHelp_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 28);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttTTNguoiDung,
            this.sttTTThoiGian});
            this.statusStrip1.Location = new System.Drawing.Point(0, 633);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1248, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sttTTNguoiDung
            // 
            this.sttTTNguoiDung.Name = "sttTTNguoiDung";
            this.sttTTNguoiDung.Size = new System.Drawing.Size(151, 20);
            this.sttTTNguoiDung.Text = "toolStripStatusLabel1";
            // 
            // sttTTThoiGian
            // 
            this.sttTTThoiGian.Name = "sttTTThoiGian";
            this.sttTTThoiGian.Size = new System.Drawing.Size(151, 20);
            this.sttTTThoiGian.Text = "toolStripStatusLabel2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources._45681;
            this.pictureBox1.Location = new System.Drawing.Point(0, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1248, 597);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // miniLuong
            // 
            this.miniLuong.Image = global::GUI.Properties.Resources.salary;
            this.miniLuong.Name = "miniLuong";
            this.miniLuong.Size = new System.Drawing.Size(228, 30);
            this.miniLuong.Text = "Lương";
            this.miniLuong.Click += new System.EventHandler(this.miniLuong_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 659);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình quản lý nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChinh_FormClosing);
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniChucVu;
        private System.Windows.Forms.ToolStripMenuItem mniNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mniDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mniDangXuat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sttTTNguoiDung;
        private System.Windows.Forms.ToolStripStatusLabel sttTTThoiGian;
        private System.Windows.Forms.ToolStripMenuItem miniDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miniNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem miniQuaTrinhLuong;
        private System.Windows.Forms.ToolStripMenuItem miniPhongBan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem miniDuAn;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miniHelp;
        private System.Windows.Forms.ToolStripMenuItem miniDuLieu;
        private System.Windows.Forms.ToolStripMenuItem saoLưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phucHoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miniLuong;
    }
}

