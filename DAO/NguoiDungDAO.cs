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
    public class NguoiDungDAO
    {
        static SqlConnection con;
        public static NguoiDungDTO LayNguoiDung(string ten, string matkhau)
        {
            string sTruyVan = string.Format("select * from nguoidung where ten='{0}' and matkhau='{1}'", ten, matkhau);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu NguoiDungDTO
            NguoiDungDTO nd = new NguoiDungDTO();
            nd.STen = dt.Rows[0]["ten"].ToString();
            nd.SMatKhau = dt.Rows[0]["matkhau"].ToString();
            nd.IQuyen = int.Parse(dt.Rows[0]["quyen"].ToString());
            DataProvider.DongKetNoi(con);
            return nd;
        }

        public static List<NguoiDungDTO> DanhSachNguoiDungDAO()
        {
            string sTruyVan = "select *from nguoidung";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu NguoiDungDTO
            List<NguoiDungDTO> lstNguoiDung = new List<DTO.NguoiDungDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NguoiDungDTO nd = new NguoiDungDTO();
                nd.STen = dt.Rows[i]["ten"].ToString();
                nd.SMatKhau = dt.Rows[i]["matkhau"].ToString();
                nd.IQuyen = int.Parse(dt.Rows[i]["quyen"].ToString());
                lstNguoiDung.Add(nd);
            }
            DataProvider.DongKetNoi(con);
            return lstNguoiDung;
        }

        public static bool ThemNguoiDungDAO(string ten, string matkhau, int quyen)
        {
            string sTruyVan = string.Format(@"insert into nguoidung values ('{0}', '{1}', {2})", ten, matkhau, quyen);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaNguoiDungDAO(string ten)
        {
            string sTruyVan = string.Format(@"delete nguoidung where ten = '{0}'", ten);
            
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool CapLaiMatKhauDAO(string id, string matkhauMH)
        {
            string sTruyVan = string.Format(@"update nguoidung set matkhau = '{0}' where ten = '{1}'", matkhauMH, id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool ThayDoiQuyenND_BUS(string id, int thaydoi)
        {
            string sTruyVan = string.Format(@"update nguoidung set quyen = {0} where ten = '{1}'", thaydoi, id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<NguoiDungDTO> KiemTraID(string sTen)
        {
            string sTruyVan = string.Format(@"select *from nguoidung where ten='{0}'", sTen);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Trả về thông tin kiểu NguoiDungDTO
            List<NguoiDungDTO> lstNguoiDung = new List<NguoiDungDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NguoiDungDTO nd = new NguoiDungDTO();
                nd.STen = dt.Rows[0]["ten"].ToString();
                nd.SMatKhau = dt.Rows[0]["matkhau"].ToString();
                nd.IQuyen = int.Parse(dt.Rows[0]["quyen"].ToString());
                lstNguoiDung.Add(nd);
            }
            
            DataProvider.DongKetNoi(con);
            return lstNguoiDung;
        }

        public static bool CapNhatNguoiDungDAO(string ten, string matkhauMH)
        {
            string sTruyVan = string.Format(@"update nguoidung set matkhau='{0}' where ten='{1}'", matkhauMH, ten);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool CapNhatMatKhau(NguoiDungDTO nd)
        {
            string sTruyVan = string.Format(@"update nguoidung set matkhau='{0}' where ten='{1}'",
                nd.SMatKhau, nd.STen);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
