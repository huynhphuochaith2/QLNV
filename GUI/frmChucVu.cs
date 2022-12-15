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
    public partial class frmChucVu : Form
    {
        
        public frmChucVu()
        {
            InitializeComponent();
           
        }
        private void Reset()
        {
            txtMacv.Clear();
            txtTencv.Clear();
            txtHSPhucap.Clear();
            
        }
        private void HienThiChucVuLenDataGrid()
        {
            List<ChucVuDTO> lstChucVu = ChucVuBUS.LayChucVu();
            dtgvChucVu.DataSource = lstChucVu;
            //Header
            dtgvChucVu.Columns["SMaCV"].HeaderText = "Mã chức vụ";
            dtgvChucVu.Columns["STenCV"].HeaderText = "Tên chức vụ";
            dtgvChucVu.Columns["FHSPhuCap"].HeaderText = "Phụ cấp";
            dtgvChucVu.Columns["SMaCV"].Width = 96;
            dtgvChucVu.Columns["STenCV"].Width = 97;
            dtgvChucVu.Columns["FHSPhuCap"].Width = 96;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMacv.Text == "" || txtTencv.Text == "" || txtHSPhucap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            
            // Kiểm tra mã chức vụ có bị trùng không
            if (ChucVuBUS.TimChucVuTheoMa(txtMacv.Text) != null)
            {
                MessageBox.Show("Mã chức vụ đã tồn tại! Vui lòng chọn mã khác.");
                return;
            }
            // Gán dữ liệu vào kiểu ChucVuDTO
            ChucVuDTO cv = new ChucVuDTO();
            cv.SMaCV = txtMacv.Text;
            cv.STenCV = txtTencv.Text;
            cv.FHSPhuCap = float.Parse(txtHSPhucap.Text);

            // Thực hiện thêm
            if (ChucVuBUS.ThemChucVuDAO(cv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            Reset();
            HienThiChucVuLenDataGrid();
            MessageBox.Show("Đã thêm chức vụ.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã chức vụ có tồn tại không
            if (ChucVuBUS.TimChucVuTheoMa(txtMacv.Text) == null)
            {
                MessageBox.Show("Mã chức vụ không tồn tại!");
                return;
            }
            // Gán dữ liệu vào kiểu ChucVuDTO
            ChucVuDTO cv = new ChucVuDTO();
            cv.SMaCV = txtMacv.Text;

            // Thực hiện xóa 
            if (ChucVuBUS.XoaChucVuBUS(cv) == false)
            {
                MessageBox.Show("Không xóa được.");
                return;
            }
            Reset();
            HienThiChucVuLenDataGrid(); ;
            MessageBox.Show("Đã xóa chức vụ.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMacv.Text == "" || txtTencv.Text == "" || txtHSPhucap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã chức vụ có bị trùng không
            if (ChucVuBUS.TimChucVuTheoMa(txtMacv.Text) == null)
            {
                MessageBox.Show("Mã chức vụ đã tồn tại! Vui lòng chọn mã khác.");
                return;
            }
            // Gán dữ liệu vào kiểu ChucVuDTO
            ChucVuDTO cv = new ChucVuDTO();
            cv.SMaCV = txtMacv.Text;
            cv.STenCV = txtTencv.Text;
            cv.FHSPhuCap = float.Parse(txtHSPhucap.Text);

            // Thực hiện thêm
            if (ChucVuBUS.UpdateChucVuBUS(cv) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }
            Reset();
            HienThiChucVuLenDataGrid();
            MessageBox.Show("Đã sửa chức vụ.");
        }

        private void dtgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dtgvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            HienThiChucVuLenDataGrid();
        }

        private void dtgvChucVu_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtgvChucVu.SelectedRows[0];
            txtMacv.Text = r.Cells["SMaCV"].Value.ToString();
            txtTencv.Text = r.Cells["STenCV"].Value.ToString();
            txtHSPhucap.Text = r.Cells["FHSPhuCap"].Value.ToString();
        }
    }
}
