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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
namespace GUI
{
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }
       
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            HienThiMaNhanVienLenCombobox();
            HienThiDSPhongBanLenDatagrid();
        }
        private void Reset()
        {
            txtMaPB.Clear();
            txtTenPB.Clear();
            txtSDT.Clear();
            txtTrangThai.Clear();
        }
        private void HienThiMaNhanVienLenCombobox()
        {
            List<NhanVienDTO> lstNhanVien = NhanVienBUS.LayDSNhanVien();
            cboMaNV.DataSource = lstNhanVien;
            cboMaNV.DisplayMember = "SMaNV";
            cboMaNV.ValueMember = "SMaNV";
        }
        private void HienThiDSPhongBanLenDatagrid()
        {
            List<PhongBanDTO> lstPhongBan = PhongBanBUS.LayDSPhongBan();
            dgvPhongBan.DataSource = lstPhongBan;
            dgvPhongBan.Columns["Smapb"].HeaderText = "Mã phòng ban";
            dgvPhongBan.Columns["Stenpb"].HeaderText = "Tên phòng ban";
            dgvPhongBan.Columns["Ssdt"].HeaderText = "Điện thoại";
            dgvPhongBan.Columns["Smanv"].HeaderText = "Mã nhân viên";
            dgvPhongBan.Columns["STrang_thai"].HeaderText = "Trạng thái";

            dgvPhongBan.Columns["Smapb"].Width = 80;
            dgvPhongBan.Columns["Stenpb"].Width = 150;
            dgvPhongBan.Columns["Ssdt"].Width = 120;
            dgvPhongBan.Columns["Smanv"].Width = 80;
            dgvPhongBan.Columns["STrang_thai"].Width = 90;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaPB.Text == "" || txtTenPB.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã phòng ban có độ dài chuỗi hợp lệ hay không
            if (txtMaPB.Text.Length > 5)
            {
                MessageBox.Show("Mã phòng ban tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã phòng ban có bị trùng không
            if (PhongBanBUS.TimPhongBanTheoTen(txtMaPB.Text) != null)
            {
                MessageBox.Show("Tên phòng ban đã tồn tại! Vui lòng chọn mã khác.");
                return;
            }
            // Gán dữ liệu vào kiểu PhongBanDTO
            PhongBanDTO pb = new PhongBanDTO();
            pb.Smapb = txtMaPB.Text;
            pb.Stenpb = txtTenPB.Text;
            pb.Ssdt = txtSDT.Text;
            pb.Smanv = cboMaNV.SelectedValue.ToString();
            pb.STrang_thai = txtTrangThai.Text;
            // Thực hiện thêm
            if (PhongBanBUS.ThemPhongBan(pb) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            Reset();
            MessageBox.Show("Đã thêm phòng ban.");
            HienThiDSPhongBanLenDatagrid();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaPB.Text == "" || txtTenPB.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            
            // Kiểm tra mã phòng bann có bị trùng không
            if (PhongBanBUS.TimPhongBanTheoTen(txtMaPB.Text) == null)
            {
                MessageBox.Show("Mã phòng ban đã tồn tại! Vui lòng chọn mã khác.");
                return;
            }
            // Gán dữ liệu vào kiểu PhongBanDTO
            PhongBanDTO pb = new PhongBanDTO();
            pb.Smapb = txtMaPB.Text;
            pb.Stenpb = txtTenPB.Text;
            pb.Ssdt = txtSDT.Text;
            pb.Smanv = cboMaNV.SelectedValue.ToString();
            pb.STrang_thai = txtTrangThai.Text;
            // Thực hiện thêm
            if (PhongBanBUS.CapNhatPhongBan(pb) == false)
            {
                MessageBox.Show("Không cập nhật được.");
                return;
            }
            Reset();
            MessageBox.Show("Đã cập nhật phòng ban.");
            HienThiDSPhongBanLenDatagrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã phòng ban có tồn tại không
            if (PhongBanBUS.TimPhongBanTheoTen(txtMaPB.Text) == null)
            {
                MessageBox.Show("Tên phòng ban không tồn tại!");
                return;
            }
            // Gán dữ liệu vào kiểu PhongBanDTO
            PhongBanDTO pb = new PhongBanDTO();
            pb.Smapb = txtMaPB.Text;

            // Thực hiện xóa 
            if (PhongBanBUS.XoaPhongBan(pb) == false)
            {
                MessageBox.Show("Không xóa được.");
                return;
            }
            Reset();
            HienThiDSPhongBanLenDatagrid();
            MessageBox.Show("Đã xóa phòng ban.");
        }

        

        private void dgvPhongBan_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvPhongBan.SelectedRows[0];
            txtMaPB.Text = r.Cells["Smapb"].Value.ToString();
            txtTenPB.Text = r.Cells["Stenpb"].Value.ToString();
            txtSDT.Text = r.Cells["Ssdt"].Value.ToString();
            cboMaNV.SelectedValue = r.Cells["Smanv"].Value.ToString();
            txtTrangThai.Text = r.Cells["STrang_thai"].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDoiTT_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvPhongBan.SelectedRows[0];
            string trangthai = "";
            if (dr.Cells["STrang_thai"].Value.ToString() == "Mở")
            {
                trangthai = "Đóng";
            }
            else
            {
                trangthai = "Mở";
            }
            PhongBanDTO pb = new PhongBanDTO();
            pb.Smapb = dr.Cells["Smapb"].Value.ToString();
            pb.STrang_thai = trangthai;
            if (PhongBanBUS.CapnhatTTPhongBan(pb) == false)
            {
                MessageBox.Show("Không cập nhật được");
                return;
            }
            Reset();
            HienThiDSPhongBanLenDatagrid();
            MessageBox.Show("Đã cập nhật trạng thái thành công");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            List<PhongBanDTO> ds = PhongBanBUS.LayDSPhongBan();
            List<PhongBanDTO> kq = (from pb in ds
                                    where pb.Smapb.Contains(txtTimMa.Text)
                                    where pb.Stenpb.Contains(txtTimTen.Text)
                                    select pb).ToList();
            dgvPhongBan.DataSource = kq;
        }
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for(int i=0;i<dgvPhongBan.Columns.Count;i++)
            {
                application.Cells[1, i + 1] = dgvPhongBan.Columns[i].HeaderText;

            }
            for(int i=0;i<dgvPhongBan.Rows.Count;i++)
            {
                for(int j=0;j<dgvPhongBan.Columns.Count;j++)
                {
                    application.Cells[i + 2, j + 1] = dgvPhongBan.Rows[i].Cells[j].Value;
                }    
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel Workbook(*.xlsx)|*.xlsx";
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công\n" + ex.Message);
                }
            }    
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
