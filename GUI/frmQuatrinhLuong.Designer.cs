
namespace GUI
{
    partial class frmQuatrinhLuong
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
            this.dtgvQuaTrinhLuong = new System.Windows.Forms.DataGridView();
            this.cbbManv = new System.Windows.Forms.ComboBox();
            this.dtpkNgayBD = new System.Windows.Forms.DateTimePicker();
            this.txtHSLuong = new System.Windows.Forms.TextBox();
            this.chkGhiChu = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuaTrinhLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvQuaTrinhLuong
            // 
            this.dtgvQuaTrinhLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQuaTrinhLuong.Location = new System.Drawing.Point(263, 1);
            this.dtgvQuaTrinhLuong.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvQuaTrinhLuong.Name = "dtgvQuaTrinhLuong";
            this.dtgvQuaTrinhLuong.ReadOnly = true;
            this.dtgvQuaTrinhLuong.RowHeadersWidth = 51;
            this.dtgvQuaTrinhLuong.Size = new System.Drawing.Size(452, 298);
            this.dtgvQuaTrinhLuong.TabIndex = 0;
            this.dtgvQuaTrinhLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvQuaTrinhLuong_CellClick);
            // 
            // cbbManv
            // 
            this.cbbManv.FormattingEnabled = true;
            this.cbbManv.Location = new System.Drawing.Point(120, 11);
            this.cbbManv.Margin = new System.Windows.Forms.Padding(4);
            this.cbbManv.Name = "cbbManv";
            this.cbbManv.Size = new System.Drawing.Size(133, 24);
            this.cbbManv.TabIndex = 1;
            // 
            // dtpkNgayBD
            // 
            this.dtpkNgayBD.Location = new System.Drawing.Point(120, 50);
            this.dtpkNgayBD.Margin = new System.Windows.Forms.Padding(4);
            this.dtpkNgayBD.Name = "dtpkNgayBD";
            this.dtpkNgayBD.Size = new System.Drawing.Size(133, 22);
            this.dtpkNgayBD.TabIndex = 2;
            // 
            // txtHSLuong
            // 
            this.txtHSLuong.Location = new System.Drawing.Point(120, 89);
            this.txtHSLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtHSLuong.Name = "txtHSLuong";
            this.txtHSLuong.Size = new System.Drawing.Size(133, 22);
            this.txtHSLuong.TabIndex = 3;
            // 
            // chkGhiChu
            // 
            this.chkGhiChu.AutoSize = true;
            this.chkGhiChu.Location = new System.Drawing.Point(120, 127);
            this.chkGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.chkGhiChu.Name = "chkGhiChu";
            this.chkGhiChu.Size = new System.Drawing.Size(18, 17);
            this.chkGhiChu.TabIndex = 4;
            this.chkGhiChu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hệ số lương";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ghi chú";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::GUI.Properties.Resources.icons8_add_48;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(44, 155);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(159, 41);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::GUI.Properties.Resources.icons8_remove_48;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(44, 204);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(159, 41);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::GUI.Properties.Resources.icons8_insurance_fixture_24;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(44, 252);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(159, 41);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmQuatrinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 298);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkGhiChu);
            this.Controls.Add(this.txtHSLuong);
            this.Controls.Add(this.dtpkNgayBD);
            this.Controls.Add(this.cbbManv);
            this.Controls.Add(this.dtgvQuaTrinhLuong);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuatrinhLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quá trình lương";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuaTrinhLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvQuaTrinhLuong;
        private System.Windows.Forms.ComboBox cbbManv;
        private System.Windows.Forms.DateTimePicker dtpkNgayBD;
        private System.Windows.Forms.TextBox txtHSLuong;
        private System.Windows.Forms.CheckBox chkGhiChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}