
namespace GUI
{
    partial class frmLuong
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
            this.txtNgayCong = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHeSoPC = new System.Windows.Forms.TextBox();
            this.txtHeSoL = new System.Windows.Forms.TextBox();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNgayCong
            // 
            this.txtNgayCong.Location = new System.Drawing.Point(472, 431);
            this.txtNgayCong.Name = "txtNgayCong";
            this.txtNgayCong.Size = new System.Drawing.Size(134, 22);
            this.txtNgayCong.TabIndex = 27;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(851, 431);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(134, 22);
            this.txtKQ.TabIndex = 26;
            this.txtKQ.TextChanged += new System.EventHandler(this.txtKQ_TextChanged);
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(472, 374);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(134, 24);
            this.cmbMaNV.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ngày công";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(701, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Hệ số phụ cấp";
            // 
            // txtHeSoPC
            // 
            this.txtHeSoPC.Location = new System.Drawing.Point(851, 374);
            this.txtHeSoPC.Name = "txtHeSoPC";
            this.txtHeSoPC.Size = new System.Drawing.Size(134, 22);
            this.txtHeSoPC.TabIndex = 21;
            // 
            // txtHeSoL
            // 
            this.txtHeSoL.Location = new System.Drawing.Point(851, 305);
            this.txtHeSoL.Name = "txtHeSoL";
            this.txtHeSoL.Size = new System.Drawing.Size(134, 22);
            this.txtHeSoL.TabIndex = 20;
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(472, 307);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(134, 22);
            this.txtLuongCB.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hệ số lương ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lương cơ bản";
            // 
            // dgvLuong
            // 
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.Location = new System.Drawing.Point(333, 31);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.RowHeadersWidth = 51;
            this.dgvLuong.RowTemplate.Height = 24;
            this.dgvLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLuong.Size = new System.Drawing.Size(670, 248);
            this.dgvLuong.TabIndex = 15;
            this.dgvLuong.Click += new System.EventHandler(this.dgvLuong_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(700, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tổng lương";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.coins_stacks_on_laptop_23_2147931179;
            this.pictureBox1.Location = new System.Drawing.Point(2, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(621, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Danh sách ";
            // 
            // frmLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 478);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNgayCong);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.cmbMaNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHeSoPC);
            this.Controls.Add(this.txtHeSoL);
            this.Controls.Add(this.txtLuongCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLuong);
            this.Name = "frmLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lương";
            this.Load += new System.EventHandler(this.frmLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNgayCong;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHeSoPC;
        private System.Windows.Forms.TextBox txtHeSoL;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}