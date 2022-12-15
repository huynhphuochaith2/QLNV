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
    public class LuongDAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả nhân viên
        public static List<LuongDTO> LayDSLuong()
        {
            string sTruyVan = "select * from luong";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LuongDTO> lstLuong = new List<DTO.LuongDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LuongDTO l = new LuongDTO();
                l.Iluongcoban = int.Parse(dt.Rows[i]["luongcoban"].ToString());
                l.Smanv = dt.Rows[i]["manv"].ToString();
                l.Fhsluong = float.Parse(dt.Rows[i]["hsluong"].ToString());
                l.Fhsphucap = float.Parse(dt.Rows[i]["hsphucap"].ToString());
                l.Ingaycong = int.Parse(dt.Rows[i]["ngaycong"].ToString());

                lstLuong.Add(l);
            }
            DataProvider.DongKetNoi(con);
            return lstLuong;
        }
        public static LuongDTO TimNhanVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from luong where luongcoban=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO
            LuongDTO l = new LuongDTO();
            l.Iluongcoban = int.Parse(dt.Rows[0]["luongcoban"].ToString());
            l.Smanv = dt.Rows[0]["manv"].ToString();
            l.Fhsluong = float.Parse(dt.Rows[0]["tennv"].ToString());
            l.Fhsphucap = float.Parse(dt.Rows[0]["phai"].ToString());
            l.Ingaycong = int.Parse(dt.Rows[0]["ngaycong"].ToString());
            DataProvider.DongKetNoi(con);
            return l;
        }
    }
}
