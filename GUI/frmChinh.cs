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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }
        frmPhongBan fPB;
        frmDangNhap fDN;      
        
        frmQuatrinhLuong qtl;
        frmChucVu cv;
        frmNhanVien nv;
        public bool bDangNhap=false; // cho biết đã đăng nhập thành công chưa
        public static NguoiDungDTO NguoiDung; // lưu thông tin người dùng đã đăng nhập 
        private void i_dmChucVu_Click(object sender, EventArgs e)
        {
            frmChucVu f6 = new frmChucVu();
            this.Hide();
            f6.ShowDialog();
            this.Show();
        }

        private void i_dmNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien f5 = new frmNhanVien();
            this.Hide();
            f5.ShowDialog();
            this.Show();
        }

        private void mniDangNhap_Click(object sender, EventArgs e)
        {
            fDN = new frmDangNhap();
            if(fDN.ShowDialog() == DialogResult.OK)
            {
                NguoiDung = NguoiDungBUS.LayNguoiDung(fDN.txtTen.Text, fDN.txtMatKhau.Text);
                if (NguoiDung != null)
                    bDangNhap = true;
            }
            else
            {
                bDangNhap = false;
            }
            HienThiMenu();
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            // Bật tắt menu
            HienThiMenu();
        }

        private void HienThiMenu()
        {
            mniDangNhap.Enabled = !bDangNhap;
            mniDangXuat.Enabled = bDangNhap;

            if (bDangNhap == false)
            {
                sttTTNguoiDung.Text = "Chưa đăng nhập";
                sttTTThoiGian.Text = "";

                mniChucVu.Enabled = false;
                mniNhanVien.Enabled = false;
                miniDoiMatKhau.Enabled = false;
                miniNguoiDung.Enabled = false;
                miniQuaTrinhLuong.Enabled = false;
                miniPhongBan.Enabled = false;
                miniDuAn.Enabled = false;
                miniHelp.Enabled = false;
                miniDuLieu.Enabled = false;
                miniLuong.Enabled = false;
            }
            else
            {
                int quyen;
                if (NguoiDung == null)
                    quyen = 0;
                else
                {
                    quyen = NguoiDung.IQuyen;
                    sttTTNguoiDung.Text = "Chào " + NguoiDung.STen + "! ";
                    sttTTThoiGian.Text = "Thời điểm đăng nhập: " + DateTime.Now;
                }
                switch (quyen) // hiển thị menu phù hợp với quyền 
                {
                    case 1: // quản trị
                        mniChucVu.Enabled = true;
                        mniNhanVien.Enabled = true;
                        miniDoiMatKhau.Enabled = true;
                        miniNguoiDung.Enabled = true;
                        miniQuaTrinhLuong.Enabled = true;
                        miniPhongBan.Enabled = true;
                        miniDuAn.Enabled = true; 
                        miniHelp.Enabled = true;
                        miniDuLieu.Enabled = true;
                        miniLuong.Enabled = true;
                        break;
                    case 2: // nhân viên
                        mniChucVu.Enabled = true;
                        mniNhanVien.Enabled = true;
                        miniDoiMatKhau.Enabled = true;                       
                        miniNguoiDung.Enabled = false;
                        miniQuaTrinhLuong.Enabled = false;
                        miniPhongBan.Enabled = false;
                        miniDuAn.Enabled = false;
                        miniHelp.Enabled = true;
                        miniDuLieu.Enabled = true;
                        miniLuong.Enabled = false;
                        break;
                    default:
                        break;

                }
            }
            
        }

        private void mniDangXuat_Click(object sender, EventArgs e)
        {
            // Đóng các form đang mở (nếu có)
            foreach(Form f in this.MdiChildren)
            {
                if (!f.IsDisposed)
                    f.Close();
            }

            // Gán lại trạng thái đăng nhập = false
            bDangNhap = false;
            HienThiMenu();
        }

        private void miniDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();         
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void miniNguoiDung_Click(object sender, EventArgs e)
        {
            frmNguoiDung f1 = new frmNguoiDung();
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }

        private void miniQuaTrinhLuong_Click(object sender, EventArgs e)
        {
            frmQuatrinhLuong f2 = new frmQuatrinhLuong();
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }

        
        private void miniPhongBan_Click(object sender, EventArgs e)
        {
            frmPhongBan f3 = new frmPhongBan();
            this.Hide();
            f3.ShowDialog();
            this.Show();
        }

        private void miniDuAn_Click(object sender, EventArgs e)
        {
            frmDuAn f4 = new frmDuAn();
            this.Hide();
            f4.ShowDialog();
            this.Show();
        }

        private void miniHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "QLNVHelp.chm");
        }

        private void saoLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
            saoluuFolder.Description = "Chọn thư mục lưu trữ";
            if (saoluuFolder.ShowDialog() == DialogResult.OK)
            {
                string sDuongDan = saoluuFolder.SelectedPath;
                if (CSDL_BUS.SaoLuu(sDuongDan) == true)
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                else
                    MessageBox.Show("Thao tác không thành công");
            }

        }

        private void phucHoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog phuchoiFile = new OpenFileDialog();
            phuchoiFile.Filter = "*.bak|*.bak";
            phuchoiFile.Title = "Chọn tập tin phục hồi (.bak)";
            if (phuchoiFile.ShowDialog() == DialogResult.OK &&
           phuchoiFile.CheckFileExists == true)
            {
                string sDuongDan = phuchoiFile.FileName;
                if (CSDL_BUS.SaoLuu(sDuongDan) == true)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng hệ thống không?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void frmChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void miniLuong_Click(object sender, EventArgs e)
        {
            frmLuong f7 = new frmLuong();
            this.Hide();
            f7.ShowDialog();
            this.Show();
        }
    }
}
