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
    public partial class frmLuong : Form
    {
        public frmLuong()
        {
            InitializeComponent();
        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLuong_Load(object sender, EventArgs e)
        {
            HienThiMaNhanVienLenCombobox();
            HienThiDSLuongLenDatagrid();
        }
        private void HienThiMaNhanVienLenCombobox()
        {
            List<NhanVienDTO> lstNhanVien = NhanVienBUS.LayDSNhanVien();
            cmbMaNV.DataSource = lstNhanVien;
            cmbMaNV.DisplayMember = "SMaNV";
            cmbMaNV.ValueMember = "SMaNV";
        }

        private void HienThiDSLuongLenDatagrid()
        {
            List<LuongDTO> lstLuong = LuongBUS.LayDSLuong();
            dgvLuong.DataSource = lstLuong;
            dgvLuong.Columns["Iluongcoban"].HeaderText = "Lương cơ bản";
            dgvLuong.Columns["Smanv"].HeaderText = "Mã nhân viên";
            dgvLuong.Columns["Fhsluong"].HeaderText = "Hệ số lương";
            dgvLuong.Columns["Fhsphucap"].HeaderText = "Hệ số phụ cấp";
            dgvLuong.Columns["Ingaycong"].HeaderText = "Ngày công";

            dgvLuong.Columns["Iluongcoban"].Width = 80;
            dgvLuong.Columns["Smanv"].Width = 80;
            dgvLuong.Columns["Fhsluong"].Width = 80;
            dgvLuong.Columns["Fhsphucap"].Width = 100;
            dgvLuong.Columns["Ingaycong"].Width = 90;
        }

        
        void tinhluong()
        {
            int luongcoban, hsluong, ngaycong;
            float hsphucap, kq;
            luongcoban = Convert.ToInt32(txtLuongCB.Text);
            hsluong = Convert.ToInt32(txtHeSoL.Text);
            hsphucap = float.Parse(txtHeSoPC.Text);
            ngaycong = Convert.ToInt32(txtNgayCong.Text);
            kq = ((luongcoban + hsluong) / 23) * ngaycong + hsphucap;
            txtKQ.Text = kq.ToString();
        }

        private void dgvLuong_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvLuong.SelectedRows[0];
            txtLuongCB.Text = r.Cells["Iluongcoban"].Value.ToString();
            cmbMaNV.SelectedValue = r.Cells["Smanv"].Value.ToString();
            txtHeSoL.Text = r.Cells["Fhsluong"].Value.ToString();
            txtHeSoPC.Text = r.Cells["Fhsphucap"].Value.ToString();
            txtNgayCong.Text = r.Cells["Ingaycong"].Value.ToString();
            tinhluong();
        }
    }
}
