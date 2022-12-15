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
    public partial class frmNguoiDung : Form
    {
        public frmNguoiDung()
        {
            InitializeComponent();
            load();
        }

        BindingSource NguoiDungList = new BindingSource();
        int rowIndex;
        private bool flag = true;

        void load()
        {
            dtgvNguoiDung.DataSource = NguoiDungList;
            HienThiNguoiDung();
            AddBinding();
            PhanQuyen();

            dtgvNguoiDung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void PhanQuyen()
        {
            if (flag == true)
            {
                flag = false;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                btnReset.Enabled = true;
                btnDoiQuyen.Enabled = true;
                btnflag.Text = "+";
            }
        }

        public void HienThiNguoiDung()
        {
            List<NguoiDungDTO> lstNguoiDung = NguoiDungBUS.DanhSachNguoiDungBUS();
            NguoiDungList.DataSource = lstNguoiDung;

            //Header
            dtgvNguoiDung.Columns["STen"].HeaderText = "Username";
            dtgvNguoiDung.Columns["SMatKhau"].HeaderText = "Password";
            dtgvNguoiDung.Columns["IQuyen"].HeaderText = "Quyền";
            dtgvNguoiDung.Columns["SMatKhau"].Width = 126;
        }

        public void AddBinding()
        {
            txtUser.DataBindings.Add(new Binding("Text", dtgvNguoiDung.DataSource, "STen"));
            txtPassword.DataBindings.Add(new Binding("Text", dtgvNguoiDung.DataSource, "SMatKhau"));
            lblQuyen.DataBindings.Add(new Binding("Text", dtgvNguoiDung.DataSource, "IQuyen"));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tennd = txtUser.Text;
            string matkhau = txtPassword.Text;
            int quyen = 1;
            List<NguoiDungDTO> NguoiDung = NguoiDungBUS.KiemTraID(tennd);
            if (NguoiDung != null)
            {
                MessageBox.Show("Tài khoản bị trùng");
            }
            else
            {
                if (NguoiDungBUS.ThemNguoiDungBUS(tennd, matkhau, quyen))
                {
                    MessageBox.Show("Thêm người dùng thành công");
                    HienThiNguoiDung();
                }
                else
                {
                    MessageBox.Show("Thêm người dùng thất bại");
                }    
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ten = txtUser.Text;
            if (NguoiDungBUS.XoaNhanVienBUS(ten))
            {
                MessageBox.Show("Xóa nhân viên thành công");
                HienThiNguoiDung();
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
        }

        private void btnflag_Click(object sender, EventArgs e)
        {
            if(flag == false)
            {
                flag = true;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
                btnReset.Enabled = false;
                btnDoiQuyen.Enabled = false;
                txtUser.Enabled = true;
                txtPassword.Enabled = true;
                lblQuyen.Enabled = true;
                btnflag.Text = "-";
            }
            else
            {
                flag = false;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
                btnReset.Enabled = true;
                btnDoiQuyen.Enabled = true;
                txtUser.Enabled = false;
                txtPassword.Enabled = false;
                lblQuyen.Enabled = false;
                btnflag.Text = "+";
            }    
        }

        private void btnDoiQuyen_Click(object sender, EventArgs e)
        {
            int quyen = int.Parse(lblQuyen.Text);
            string id = txtUser.Text;
            //Thay đổi giá trị quyền
            int thaydoi = 3 - quyen;
            if (NguoiDungBUS.ThayDoiQuyenND_DAO(id, thaydoi))
            {
                if (thaydoi == 1)
                {
                    MessageBox.Show("Đã được cấp làm quản trị viên");
                }
                else
                {
                    MessageBox.Show("Đã bị giáng cấp làm nhân viên");
                }    
            }
            HienThiNguoiDung();
        }

        private void dtgvNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int quyen = int.Parse(lblQuyen.Text);

            if (quyen == 1)
            {
                btnDoiQuyen.Text = "Hạ quyền";
            }
            else
            {
                btnDoiQuyen.Text = "Nâng quyền";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            string id = txtUser.Text;

            if (NguoiDungBUS.CapLaiMatKhauBUS(id))
            {
                MessageBox.Show("Mật khẩu đã được cấp lại là 123");
            }
            else
            {
                MessageBox.Show("Cấp lại mật khẩu thất bại");
            }    
        }
    }
}
