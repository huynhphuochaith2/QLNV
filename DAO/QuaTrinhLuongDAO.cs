using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuaTrinhLuongDAO
    {
        static SqlConnection con;
        public static bool XoaQuaTrinhLuongDAO(string manv)
        {
            string sTruyVan = string.Format(@"delete quatrinhluong where manv = '{0}'", manv);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool ThemQuaTrinhLuongDAO(QuaTrinhLuongDTO qtl)
        {
            int Ighichu;
            if (qtl.BGhichu == true)
            {
                Ighichu = 1;
            }
            else
            {
                Ighichu = 0;
            }    
            string sTruyVan = string.Format(@"insert into quatrinhluong values('{0}','{1}',{2},{3})", qtl.SMaNV, qtl.DNgayBD, qtl.SHSLuong, Ighichu);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool XoaQuaTrinhLuongTheoNgayDAO(DateTime ngaybdCu)
        {
            string sTruyVan = string.Format(@"delete quatrinhluong where ngaybd = '{0}'", ngaybdCu);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool CapNhatQuaTrinhLuong(QuaTrinhLuongDTO qtl, DateTime ngaybdCu)
        {
            int Ighichu;
            if (qtl.BGhichu == true)
            {
                Ighichu = 1;
            }
            else
            {
                Ighichu = 0;
            }
            string sTruyVan = string.Format(@"update quatrinhluong set ngaybd = '{0}', hsluong = {1}, ghichu = {2} where ngaybd = '{3}'", qtl.DNgayBD, qtl.SHSLuong, Ighichu, ngaybdCu);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<QuaTrinhLuongDTO> ShowDanhSachQTL_BUS()
        {
            string sTruyVan = "select *from quatrinhluong";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<QuaTrinhLuongDTO> listQuaTrinhLuong = new List<DTO.QuaTrinhLuongDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                QuaTrinhLuongDTO qtl = new QuaTrinhLuongDTO();
                qtl.SMaNV = dt.Rows[i]["manv"].ToString();
                qtl.DNgayBD = DateTime.Parse(dt.Rows[i]["ngaybd"].ToString());
                qtl.SHSLuong = float.Parse(dt.Rows[i]["hsluong"].ToString());
                qtl.BGhichu = bool.Parse(dt.Rows[i]["ghichu"].ToString());
                listQuaTrinhLuong.Add(qtl);
            }
            DataProvider.DongKetNoi(con);
            return listQuaTrinhLuong;
        }
    }
}
