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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace GUI
{
    public partial class frmNhanVien : Form
    {
        
        public frmNhanVien()
        {
            InitializeComponent();
            
        }
        private void Reset()
        {
            txtMaNV.Clear();
            txtHoLot.Clear();
            txtTen.Clear();
            txtTinhTrang.Clear();
            //txtTrangThai.Clear();
        }
        private void HienThiChucVuLenCombobox()
        {
            List<ChucVuDTO> lstChucVu = ChucVuBUS.LayChucVu();
            cboChucVu.DataSource = lstChucVu;
            cboChucVu.DisplayMember = "STenCV";
            cboChucVu.ValueMember = "SMaCV";
        }

        private void HienThiDSNhanVienLenDatagrid()
        {
            List<NhanVienDTO> lstNhanVien = NhanVienBUS.LayDSNhanVien();
            dtgvNhanVien.DataSource = lstNhanVien;
            dtgvNhanVien.Columns["SMaNV"].HeaderText = "Mã số";
            dtgvNhanVien.Columns["SHoLot"].HeaderText = "Họ và lót";
            dtgvNhanVien.Columns["STen"].HeaderText = "Tên";
            dtgvNhanVien.Columns["SPhai"].HeaderText = "Phái";
            dtgvNhanVien.Columns["DtNgaySinh"].HeaderText = "Ngày sinh";
            dtgvNhanVien.Columns["SMaCV"].HeaderText = "Chức vụ";
            dtgvNhanVien.Columns["STinhTrang"].HeaderText = "Hôn nhân";
            //dtgvNhanVien.Columns["STrangThai"].HeaderText = "Trạng thái";

            dtgvNhanVien.Columns["SMaNV"].Width = 60;
            dtgvNhanVien.Columns["SHoLot"].Width = 120;
            dtgvNhanVien.Columns["STen"].Width = 50;
            dtgvNhanVien.Columns["SPhai"].Width = 50;
            dtgvNhanVien.Columns["DtNgaySinh"].Width = 50;
            dtgvNhanVien.Columns["STinhTrang"].Width = 80;
            //dtgvNhanVien.Columns["STrangThai"].Width = 80;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaNV.Text == "" || txtHoLot.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtMaNV.Text.Length > 5)
            {
                MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (NhanVienBUS.TimNhanVienTheoMa(txtMaNV.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại! Vui lòng chọn mã khác.");
                return;
            }
            // Gán dữ liệu vào kiểu NhanVienDTO
            NhanVienDTO nv = new NhanVienDTO();
            nv.SMaNV = txtMaNV.Text;
            nv.SHoLot = txtHoLot.Text;
            nv.STen = txtTen.Text;
            if (radNam.Checked == true)
            {
                nv.SPhai = "Nam";
            }
            else
            {
                nv.SPhai = "Nữ";
            }
            nv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            nv.SMaCV = cboChucVu.SelectedValue.ToString();
            nv.STinhTrang = txtTinhTrang.Text;
            //nv.STrangThai = txtTrangThai.Text;
            // Thực hiện thêm
            if (NhanVienBUS.ThemNhanVien(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            Reset();
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm nhân viên.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaNV.Text == "" || txtHoLot.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã nhân viên có tồn tại không
            if (NhanVienBUS.TimNhanVienTheoMa(txtMaNV.Text) == null)
            {
                MessageBox.Show("Mã nhân viên không tồn tại!");
                return;
            }
            // Gán dữ liệu vào kiểu NhanVienDTO
            NhanVienDTO nv = new NhanVienDTO();
            nv.SMaNV = txtMaNV.Text;
            nv.SHoLot = txtHoLot.Text;
            nv.STen = txtTen.Text;
            if (radNam.Checked == true)
            {
                nv.SPhai = "Nam";
            }
            else
            {
                nv.SPhai = "Nữ";
            }
            nv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            nv.SMaCV = cboChucVu.SelectedValue.ToString();
            nv.STinhTrang = txtTinhTrang.Text;
            //nv.STrangThai = txtTrangThai.Text;
            // Thực hiện cập nhật
            if (NhanVienBUS.CapNhatNhanVien(nv) == false)
            {
                MessageBox.Show("Không cập nhật được.");
                return;
            }
            Reset();
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã cập nhật nhân viên.");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            // Kiểm tra mã nhân viên có tồn tại không
            if (NhanVienBUS.TimNhanVienTheoMa(txtMaNV.Text) == null)
            {
                MessageBox.Show("Mã nhân viên không tồn tại!");
                return;
            }
            // Gán dữ liệu vào kiểu NhanVienDTO
            NhanVienDTO nv = new NhanVienDTO();
            nv.SMaNV = txtMaNV.Text;

            // Thực hiện xóa (xóa quá trình lương trước khi xóa nhân viên)
            if (NhanVienBUS.XoaNhanVien(nv) == false)
            {
                MessageBox.Show("Không xóa được.");
                return;
            }
            Reset();
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã xóa nhân viên.");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            List<NhanVienDTO> ds = NhanVienBUS.LayDSNhanVien();
            List<NhanVienDTO> kq = (from nv in ds
                                    where nv.SHoLot.Contains(txtTimHo.Text)
                                    where nv.STen.Contains(txtTimTen.Text)
                                    select nv).ToList();
            dtgvNhanVien.DataSource = kq;
        }

        

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // Combobox chức vụ
            HienThiChucVuLenCombobox();

            // Datagrid nhân viên
            HienThiDSNhanVienLenDatagrid();
        }

        private void dtgvNhanVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtgvNhanVien.SelectedRows[0];
            txtMaNV.Text = r.Cells["SMaNV"].Value.ToString();
            txtHoLot.Text = r.Cells["SHoLot"].Value.ToString();
            txtTen.Text = r.Cells["STen"].Value.ToString();
            cboChucVu.SelectedValue = r.Cells["SMaCV"].Value.ToString();
            dtpNgaySinh.Text = r.Cells["DtNgaySinh"].Value.ToString();
            if (r.Cells["SPhai"].Value.ToString() == "Nam")
                radNam.Checked = true;
            else
                radNu.Checked = true;
            txtTinhTrang.Text = r.Cells["STinhTrang"].Value.ToString();
            //txtTrangThai.Text = r.Cells["STrangThai"].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            /*DataGridViewRow dr = dtgvNhanVien.SelectedRows[0];
            string trangthai = "";
            if (dr.Cells["STrangThai"].Value.ToString() == "Đang làm việc")
            {
                trangthai = "Đã nghỉ";
            }
            else
            {
                trangthai = "Đang làm việc";
            }
            NhanVienDTO nv = new NhanVienDTO();
            nv.SMaNV = dr.Cells["SMaNV"].Value.ToString();
            nv.STrangThai = trangthai;
            if (NhanVienBUS.CapnhatTrangThai(nv) == false)
            {
                MessageBox.Show("Không cập nhật được");
                return;
            }
            Reset();
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã cập nhật trạng thái thành công");*/
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow dr = dtgvNhanVien.SelectedRows[0];
            string trangthai = "";
            if (dr.Cells["STinhTrang"].Value.ToString() == "Đã kết hôn")
            {
                trangthai = "Độc thân";
            }
            else
            {
                trangthai = "Đã kết hôn";
            }
            NhanVienDTO nv = new NhanVienDTO();
            nv.SMaNV = dr.Cells["SMaNV"].Value.ToString();
            nv.STinhTrang = trangthai;
            if (NhanVienBUS.CapnhatTTHonNhan(nv) == false)
            {
                MessageBox.Show("Không cập nhật được");
                return;
            }
            Reset();
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã cập nhật trạng thái thành công");
        }
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dtgvNhanVien.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dtgvNhanVien.Columns[i].HeaderText;

            }
            for (int i = 0; i < dtgvNhanVien.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvNhanVien.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dtgvNhanVien.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        private void btnXuatDS_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel Workbook(*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công\n" + ex.Message);
                }
            }
        }
    }
}

