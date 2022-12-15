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
    public partial class frmQuatrinhLuong : Form
    {
        BindingSource QuatrinhLuongList = new BindingSource();
        string manvCu;
        DateTime ngaybdCu;
        public frmQuatrinhLuong()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            //Load mã nhân viên lên Combobox
            loadComBoboxQTL();

            //Hiễn thị danh sách quá trình lương lên datagridview
            dtgvQuaTrinhLuong.DataSource = QuatrinhLuongList;
            BindingQuaTrinhLuong();
            HienThiDanhSachQuaTrinhLuong();

            //Chọn full dòng
            dtgvQuaTrinhLuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void BindingQuaTrinhLuong()
        {
            cbbManv.DataBindings.Add(new Binding("Text", dtgvQuaTrinhLuong.DataSource, "SMaNV", true, DataSourceUpdateMode.Never));
            dtpkNgayBD.DataBindings.Add(new Binding("Text", dtgvQuaTrinhLuong.DataSource, "DNgayBD", true, DataSourceUpdateMode.Never));
            txtHSLuong.DataBindings.Add(new Binding("Text", dtgvQuaTrinhLuong.DataSource, "SHSLuong", true, DataSourceUpdateMode.Never));
        }

        public void loadComBoboxQTL()
        {
            List<NhanVienDTO> listMaNV = NhanVienBUS.LayDSNhanVien();
            cbbManv.DataSource = listMaNV;
            cbbManv.DisplayMember = "SMaNV";
            cbbManv.ValueMember = "SMaNV";
        }
        public void HienThiDanhSachQuaTrinhLuong()
        {
            List<QuaTrinhLuongDTO> listQuatrinhLuong = QuatrinhLuongBUS.ShowDanhSachQTL_BUS();
            QuatrinhLuongList.DataSource = listQuatrinhLuong;

            //Header
            dtgvQuaTrinhLuong.Columns["SMaNV"].HeaderText = "Mã";
            dtgvQuaTrinhLuong.Columns["DNgayBD"].HeaderText = "Ngày bắt đầu";
            dtgvQuaTrinhLuong.Columns["SHSLuong"].HeaderText = "HS Lương";
            dtgvQuaTrinhLuong.Columns["BGhichu"].HeaderText = "Ghi chú";
            dtgvQuaTrinhLuong.Columns["SMaNV"].Width = 60;
            dtgvQuaTrinhLuong.Columns["DNgayBD"].Width = 99;
            dtgvQuaTrinhLuong.Columns["SHSLuong"].Width = 60;
            dtgvQuaTrinhLuong.Columns["BGhichu"].Width = 60;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuaTrinhLuongDTO qtl = new QuaTrinhLuongDTO();
            qtl.SMaNV = cbbManv.Text;
            qtl.DNgayBD = DateTime.Parse(dtpkNgayBD.Text);
            qtl.SHSLuong = float.Parse(txtHSLuong.Text);
            if (chkGhiChu.Checked == true)
            {
                qtl.BGhichu = true;
            }
            else
            {
                qtl.BGhichu = false;
            }

            if (QuatrinhLuongBUS.ThemQuaTrinhLuongBUS(qtl))
            {
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại");
            }
            HienThiDanhSachQuaTrinhLuong();
        }

        private void dtgvQuaTrinhLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                DataGridViewRow dr = dtgvQuaTrinhLuong.Rows[e.RowIndex];
                bool ghichu = bool.Parse(dr.Cells[3].Value.ToString());
                if (ghichu == true)
                {
                    chkGhiChu.Checked = true;
                }
                else
                {
                    chkGhiChu.Checked = false;
                }

                //Lấy mã nhân viên để xóa
                manvCu = dr.Cells[0].Value.ToString();

                //Ngày bắt đầu cũ
                ngaybdCu = DateTime.Parse(dr.Cells[1].Value.ToString());
            } catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (QuatrinhLuongBUS.XoaQuaTrinhLuongTheoNgayBUS(ngaybdCu))
            {
                MessageBox.Show($"Xóa quá trình lương có ngày bắt đầu {ngaybdCu} thành công");
            }
            else
            {
                MessageBox.Show($"Xóa quá trình lương có ngày bắt đầu {ngaybdCu} thất bại");
            }
            HienThiDanhSachQuaTrinhLuong();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            QuaTrinhLuongDTO qtl = new QuaTrinhLuongDTO();
            qtl.SMaNV = cbbManv.Text;
            qtl.DNgayBD = DateTime.Parse(dtpkNgayBD.Text);
            qtl.SHSLuong = float.Parse(txtHSLuong.Text);
            if (chkGhiChu.Checked == true)
            {
                qtl.BGhichu = true;
            }
            else
            {
                qtl.BGhichu = false;
            }

            if (qtl.SMaNV != manvCu)
            {
                MessageBox.Show("Không thể thay đổi mã nhân viên");
            }
            else
            {
                if (QuatrinhLuongBUS.CapNhatQuaTrinhLuong(qtl, ngaybdCu))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            HienThiDanhSachQuaTrinhLuong();
        }
    }
}

