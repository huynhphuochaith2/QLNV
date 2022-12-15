using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả nhân viên
        public static List<NhanVienDTO> LayDSNhanVien()
        {
            string sTruyVan = "select * from nhanvien";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVienDTO> lstNhanVien = new List<DTO.NhanVienDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.SMaNV = dt.Rows[i]["manv"].ToString();
                nv.SHoLot = dt.Rows[i]["holot"].ToString();
                nv.STen = dt.Rows[i]["tennv"].ToString();
                nv.SPhai = dt.Rows[i]["phai"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.SMaCV = dt.Rows[i]["macv"].ToString();
                nv.STinhTrang = dt.Rows[i]["tinhtrang"].ToString();
                //nv.STinhTrang = dt.Rows[i]["trangthai"].ToString();
                lstNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }
        public static bool CapNhatNhienVien_MACV_MoiDAO(string macv, string macvCu)
        {
            string sTruyVan = string.Format(@"update nhanvien set macv = '{0}' where macv = '{1}'", macv, macvCu);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Thêm NV
        public static bool ThemNhanVien(NhanVienDTO nv)
        {
            string sTruyVan = string.Format(@"insert into nhanvien values(N'{0}',
                N'{1}',N'{2}',N'{3}','{4}',N'{5}',N'{6}')", nv.SMaNV, nv.SHoLot, nv.STen,
                nv.SPhai, nv.DtNgaySinh, nv.SMaCV,nv.STinhTrang);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin nhân viên có mã ma, trả về null nếu không thấy
        public static NhanVienDTO TimNhanVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where manv=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO
            NhanVienDTO nv = new NhanVienDTO();
            nv.SMaNV = dt.Rows[0]["manv"].ToString();
            nv.SHoLot = dt.Rows[0]["holot"].ToString();
            nv.STen = dt.Rows[0]["tennv"].ToString();
            nv.SPhai = dt.Rows[0]["phai"].ToString();
            nv.DtNgaySinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
            nv.SMaCV = dt.Rows[0]["macv"].ToString();
            nv.STinhTrang = dt.Rows[0]["tinhtrang"].ToString();
            //nv.STrangThai = dt.Rows[0]["trangthai"].ToString();
            DataProvider.DongKetNoi(con);
            return nv;
        }

        // Cập nhật thông tin NV
        public static bool CapNhatNhanVien(NhanVienDTO nv)
        {
            string sTruyVan = string.Format(@"update nhanvien set holot=N'{0}',
                tennv=N'{1}',phai=N'{2}',ngaysinh='{3}',macv='{4}',tinhtrang='{5}' where manv=N'{6}'",
                nv.SHoLot, nv.STen, nv.SPhai, nv.DtNgaySinh, nv.SMaCV, nv.STinhTrang, nv.SMaNV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Xóa thông tin 1 nhân viên
        public static bool XoaNhanVien(NhanVienDTO nv)
        {
            string sTruyVan = string.Format(@"delete from nhanvien where manv=N'{0}'", nv.SMaNV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool CapnhatTTHonNhan(NhanVienDTO nv)
        {
            string sTruyVan = string.Format(@"update nhanvien set tinhtrang=N'{0}'
            where manv='{1}'", nv.STinhTrang, nv.SMaNV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
