
namespace GUI
{
    partial class frmNguoiDung
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
            this.dtgvNguoiDung = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDoiQuyen = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnflag = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQuyen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvNguoiDung
            // 
            this.dtgvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNguoiDung.Location = new System.Drawing.Point(320, 0);
            this.dtgvNguoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvNguoiDung.Name = "dtgvNguoiDung";
            this.dtgvNguoiDung.ReadOnly = true;
            this.dtgvNguoiDung.RowHeadersWidth = 51;
            this.dtgvNguoiDung.Size = new System.Drawing.Size(502, 288);
            this.dtgvNguoiDung.TabIndex = 0;
            this.dtgvNguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNguoiDung_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên người dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(167, 28);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(143, 23);
            this.txtUser.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(167, 76);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(143, 23);
            this.txtPassword.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::GUI.Properties.Resources.icons8_remove_48;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(167, 174);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 33);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(88, 174);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 33);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDoiQuyen
            // 
            this.btnDoiQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiQuyen.Location = new System.Drawing.Point(167, 222);
            this.btnDoiQuyen.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoiQuyen.Name = "btnDoiQuyen";
            this.btnDoiQuyen.Size = new System.Drawing.Size(127, 33);
            this.btnDoiQuyen.TabIndex = 3;
            this.btnDoiQuyen.Text = "Đổi quyền";
            this.btnDoiQuyen.UseVisualStyleBackColor = true;
            this.btnDoiQuyen.Click += new System.EventHandler(this.btnDoiQuyen_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(36, 222);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 33);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Đặt lại MK";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnflag
            // 
            this.btnflag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnflag.Location = new System.Drawing.Point(39, 174);
            this.btnflag.Margin = new System.Windows.Forms.Padding(4);
            this.btnflag.Name = "btnflag";
            this.btnflag.Size = new System.Drawing.Size(53, 33);
            this.btnflag.TabIndex = 4;
            this.btnflag.Text = "+";
            this.btnflag.UseVisualStyleBackColor = true;
            this.btnflag.Click += new System.EventHandler(this.btnflag_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quyền";
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Enabled = false;
            this.lblQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.Location = new System.Drawing.Point(163, 128);
            this.lblQuyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(55, 17);
            this.lblQuyen.TabIndex = 5;
            this.lblQuyen.Text = "Quyền";
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(824, 286);
            this.Controls.Add(this.lblQuyen);
            this.Controls.Add(this.btnflag);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDoiQuyen);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvNguoiDung);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người dùng";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNguoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvNguoiDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDoiQuyen;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnflag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQuyen;
    }
}