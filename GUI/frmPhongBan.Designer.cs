
namespace GUI
{
    partial class frmPhongBan
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
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.btnDoiTT = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimMa = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.GroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Location = new System.Drawing.Point(4, 31);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.RowHeadersWidth = 51;
            this.dgvPhongBan.RowTemplate.Height = 24;
            this.dgvPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongBan.Size = new System.Drawing.Size(763, 326);
            this.dgvPhongBan.TabIndex = 0;
            this.dgvPhongBan.Click += new System.EventHandler(this.dgvPhongBan_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.btnThoat);
            this.GroupBox.Controls.Add(this.btnExport);
            this.GroupBox.Controls.Add(this.btnDoiTT);
            this.GroupBox.Controls.Add(this.btnSua);
            this.GroupBox.Controls.Add(this.btnXoa);
            this.GroupBox.Controls.Add(this.btnThem);
            this.GroupBox.Location = new System.Drawing.Point(378, 384);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(313, 231);
            this.GroupBox.TabIndex = 1;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Chọn";
            // 
            // btnDoiTT
            // 
            this.btnDoiTT.Location = new System.Drawing.Point(180, 100);
            this.btnDoiTT.Name = "btnDoiTT";
            this.btnDoiTT.Size = new System.Drawing.Size(104, 42);
            this.btnDoiTT.TabIndex = 3;
            this.btnDoiTT.Text = "Đổi trạng thái";
            this.btnDoiTT.UseVisualStyleBackColor = true;
            this.btnDoiTT.Click += new System.EventHandler(this.btnDoiTT_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::GUI.Properties.Resources.icons8_insurance_fixture_24;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(21, 100);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 42);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sữa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::GUI.Properties.Resources.icons8_remove_48;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(180, 33);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 44);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::GUI.Properties.Resources.icons8_add_48;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(21, 35);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 42);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phòng ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên phòng ban";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã nhân viên";
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(145, 34);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(162, 22);
            this.txtMaPB.TabIndex = 6;
            // 
            // txtTenPB
            // 
            this.txtTenPB.Location = new System.Drawing.Point(145, 77);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(162, 22);
            this.txtTenPB.TabIndex = 7;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(145, 118);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(162, 22);
            this.txtSDT.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTrangThai);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboMaNV);
            this.groupBox1.Controls.Add(this.txtMaPB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenPB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 252);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(145, 214);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(162, 22);
            this.txtTrangThai.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Trạng thái";
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(145, 169);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(162, 24);
            this.cboMaNV.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimTen);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.txtTimMa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(743, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 252);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tra cứu";
            // 
            // txtTimTen
            // 
            this.txtTimTen.Location = new System.Drawing.Point(182, 116);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(143, 22);
            this.txtTimTen.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tìm tên phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tìm mã phòng";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Image = global::GUI.Properties.Resources.icons8_find_32;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(182, 179);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(104, 42);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimMa
            // 
            this.txtTimMa.Location = new System.Drawing.Point(182, 28);
            this.txtTimMa.Name = "txtTimMa";
            this.txtTimMa.Size = new System.Drawing.Size(117, 22);
            this.txtTimMa.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(21, 158);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(102, 41);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "ExportExcel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.thiet_ke_phong_lv_cong_so_01_1_;
            this.pictureBox1.Location = new System.Drawing.Point(785, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Danh sách phòng ban";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::GUI.Properties.Resources.icons8_close_30;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(180, 158);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 42);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1116, 625);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.dgvPhongBan);
            this.Name = "frmPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng ban";
            this.Load += new System.EventHandler(this.frmPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Button btnDoiTT;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimMa;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThoat;
    }
}