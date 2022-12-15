using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmDuAn : Form
    {
        public frmDuAn()
        {
            InitializeComponent();
        }
        private void Reset()
        {          
            txtMaDA.Clear();
            txtTenDA.Clear();
            txtMaKN.Clear();
            txtTenKN.Clear();
        }
        private void HienThiMaNhanVienLenCombobox()
        {
            List<NhanVienDTO> lstNhanVien = NhanVienBUS.LayDSNhanVien();
            cboMaNV.DataSource = lstNhanVien;
            cboMaNV.DisplayMember = "SMaNV";
            cboMaNV.ValueMember = "SMaNV";
        }
        private void HienThiDSDuAnLenDatagrid()
        {
            List<DuAnDTO> lstDuAn = DuAnBUS.LayDSDuAn();
            dgvDuAn.DataSource = lstDuAn;
            dgvDuAn.Columns["SMaNV"].HeaderText = "Mã nv";
            dgvDuAn.Columns["SMaDA"].HeaderText = "Mã dự án";
            dgvDuAn.Columns["STenDA"].HeaderText = "Tên dự án";
            dgvDuAn.Columns["SMaKyNang"].HeaderText = "Mã kỹ năng";
            dgvDuAn.Columns["STenKyNang"].HeaderText = "Tên kỹ năng";

            dgvDuAn.Columns["SMaNV"].Width = 70;
            dgvDuAn.Columns["SMaDA"].Width = 80;
            dgvDuAn.Columns["STenDA"].Width = 120;
            dgvDuAn.Columns["SMaKyNang"].Width = 70;
            dgvDuAn.Columns["STenKyNang"].Width = 120;          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaDA.Text == "" || txtMaKN.Text == ""||txtTenKN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã dự án có độ dài chuỗi hợp lệ hay không
            if (txtMaDA.Text.Length > 5)
            {
                MessageBox.Show("Mã dự án tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã dự án có bị trùng không
            if (DuAnBUS.TimDuAnTheoMa(txtMaDA.Text) != null)
            {
                MessageBox.Show("Mã dự án đã tồn tại! Vui lòng chọn mã khác.");
                return;
            }
            // Gán dữ liệu vào kiểu DuAnDTO
            DuAnDTO da = new DuAnDTO();
            da.SMaNV = cboMaNV.SelectedValue.ToString();
            da.SMaDA = txtMaDA.Text;
            da.STenDA = txtTenDA.Text;
            da.SMaKyNang = txtMaKN.Text;
            da.STenKyNang = txtTenKN.Text;          
            // Thực hiện thêm
            if (DuAnBUS.ThemDuAn(da) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            Reset();
            HienThiDSDuAnLenDatagrid();
            MessageBox.Show("Đã thêm dự án.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if ( txtMaDA.Text == "" || txtMaKN.Text == ""||txtTenKN.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            
            // Kiểm tra mã dự án có bị trùng không
            if (DuAnBUS.TimDuAnTheoMa(txtMaDA.Text) == null)
            {
                MessageBox.Show("Mã dự án đã tồn tại! Vui lòng chọn mã khác.");
                return;
            }
            // Gán dữ liệu vào kiểu DuAnDTO
            DuAnDTO da = new DuAnDTO();
            da.SMaNV = cboMaNV.SelectedValue.ToString();
            da.SMaDA = txtMaDA.Text;
            da.STenDA = txtTenDA.Text;
            da.SMaKyNang = txtMaKN.Text;
            da.STenKyNang = txtTenKN.Text;
            // Thực hiện thêm
            if (DuAnBUS.CapNhatDuAn(da) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            Reset();
            HienThiDSDuAnLenDatagrid();
            MessageBox.Show("Đã sữa dự án.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã dự án có tồn tại không
            if (DuAnBUS.TimDuAnTheoMa(txtMaDA.Text) == null)
            {
                MessageBox.Show("Mã dự án không tồn tại!");
                return;
            }
            // Gán dữ liệu vào kiểu DuAnDTO
            DuAnDTO da = new DuAnDTO();
            da.SMaDA = txtMaDA.Text;

            // Thực hiện xóa 
            if (DuAnBUS.XoaDuAn(da) == false)
            {
                MessageBox.Show("Không xóa được.");
                return;
            }
            Reset();
            HienThiDSDuAnLenDatagrid();
            MessageBox.Show("Đã xóa dự án.");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            List<DuAnDTO> ds = DuAnBUS.LayDSDuAn();
            List<DuAnDTO> kq = (from da in ds
                                    where da.SMaDA.Contains(txtTimMa.Text)
                                    
                                    select da).ToList();
            dgvDuAn.DataSource = kq;
        }

        private void frmDuAn_Load(object sender, EventArgs e)
        {
            HienThiMaNhanVienLenCombobox();

            HienThiDSDuAnLenDatagrid();
        }

        private void dgvDuAn_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvDuAn.SelectedRows[0];
            cboMaNV.SelectedValue = r.Cells["SMaNV"].Value.ToString();
            txtMaDA.Text = r.Cells["SMaDA"].Value.ToString();
            txtTenDA.Text = r.Cells["STenDA"].Value.ToString();
            txtMaKN.Text = r.Cells["SMaKyNang"].Value.ToString();
            txtTenKN.Text = r.Cells["STenKyNang"].Value.ToString();
            
        }
        
    }
}
