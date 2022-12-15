using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
           
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTenNguoiDung.Text = frmChinh.NguoiDung.STen;
            txtTenNguoiDung.Enabled = false;

            txtMKCu.UseSystemPasswordChar = true;
            txtMKMoi.UseSystemPasswordChar = true;
        }

        private void chkHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThi.Checked == true)
            {
                txtMKCu.UseSystemPasswordChar = false;
                txtMKMoi.UseSystemPasswordChar = false;
            }
            else
            {
                txtMKCu.UseSystemPasswordChar = true;
                txtMKMoi.UseSystemPasswordChar = true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (NguoiDungBUS.LayNguoiDung(txtTenNguoiDung.Text, txtMKCu.Text) == null)
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
                return;
            }
            NguoiDungDTO nd = new NguoiDungDTO();
            nd.STen = txtTenNguoiDung.Text;
            nd.SMatKhau = txtMKMoi.Text;
            if (NguoiDungBUS.CapNhatMatKhau(nd))
            {
                MessageBox.Show("Chưa cập nhật được");
                return;
            }
            MessageBox.Show("Đã cập nhật mật khẩu");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
