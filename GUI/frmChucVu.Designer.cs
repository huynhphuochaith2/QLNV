namespace GUI
{
    partial class frmChucVu
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtHSPhucap = new System.Windows.Forms.TextBox();
            this.txtTencv = new System.Windows.Forms.TextBox();
            this.txtMacv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvChucVu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btnSua);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            this.splitContainer1.Panel1.Controls.Add(this.txtHSPhucap);
            this.splitContainer1.Panel1.Controls.Add(this.txtTencv);
            this.splitContainer1.Panel1.Controls.Add(this.txtMacv);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgvChucVu);
            this.splitContainer1.Size = new System.Drawing.Size(451, 324);
            this.splitContainer1.SplitterDistance = 115;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::GUI.Properties.Resources.icons8_insurance_fixture_24;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(275, 75);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(148, 30);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::GUI.Properties.Resources.icons8_remove_48;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(275, 44);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(148, 30);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::GUI.Properties.Resources.icons8_add_48;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(275, 14);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(148, 30);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtHSPhucap
            // 
            this.txtHSPhucap.Location = new System.Drawing.Point(119, 79);
            this.txtHSPhucap.Margin = new System.Windows.Forms.Padding(4);
            this.txtHSPhucap.Name = "txtHSPhucap";
            this.txtHSPhucap.Size = new System.Drawing.Size(132, 22);
            this.txtHSPhucap.TabIndex = 5;
            // 
            // txtTencv
            // 
            this.txtTencv.Location = new System.Drawing.Point(119, 48);
            this.txtTencv.Margin = new System.Windows.Forms.Padding(4);
            this.txtTencv.Name = "txtTencv";
            this.txtTencv.Size = new System.Drawing.Size(132, 22);
            this.txtTencv.TabIndex = 4;
            // 
            // txtMacv
            // 
            this.txtMacv.Location = new System.Drawing.Point(119, 17);
            this.txtMacv.Margin = new System.Windows.Forms.Padding(4);
            this.txtMacv.Name = "txtMacv";
            this.txtMacv.Size = new System.Drawing.Size(132, 22);
            this.txtMacv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hệ số phụ cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chức vụ";
            // 
            // dtgvChucVu
            // 
            this.dtgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChucVu.Location = new System.Drawing.Point(3, 4);
            this.dtgvChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvChucVu.Name = "dtgvChucVu";
            this.dtgvChucVu.ReadOnly = true;
            this.dtgvChucVu.RowHeadersWidth = 51;
            this.dtgvChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChucVu.Size = new System.Drawing.Size(443, 193);
            this.dtgvChucVu.TabIndex = 0;
            this.dtgvChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChucVu_CellClick);
            this.dtgvChucVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChucVu_CellContentClick);
            this.dtgvChucVu.Click += new System.EventHandler(this.dtgvChucVu_Click);
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 324);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chức vụ";
            this.Load += new System.EventHandler(this.frmChucVu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChucVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtHSPhucap;
        private System.Windows.Forms.TextBox txtTencv;
        private System.Windows.Forms.TextBox txtMacv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvChucVu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}