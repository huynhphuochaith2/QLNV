using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class ChucVuDAO
    {
        static SqlConnection con;
        public static List<ChucVuDTO> LayChucVu()
        {
            string sTruyVan = "select * from chucvu";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChucVuDTO> lstChucVu = new List<ChucVuDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChucVuDTO cv = new ChucVuDTO();
                cv.SMaCV = dt.Rows[i]["macv"].ToString();
                cv.STenCV = dt.Rows[i]["tencv"].ToString();
                cv.FHSPhuCap = float.Parse(dt.Rows[i]["hsphucap"].ToString());
                lstChucVu.Add(cv);
            }
            DataProvider.DongKetNoi(con);
            return lstChucVu;
        }
        public static ChucVuDTO TimChucVuTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from chucvu where macv=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu ChucVuDTO
            ChucVuDTO cv = new ChucVuDTO();
            cv.SMaCV = dt.Rows[0]["macv"].ToString();
            cv.STenCV = dt.Rows[0]["tencv"].ToString();
            cv.FHSPhuCap = float.Parse(dt.Rows[0]["hsphucap"].ToString());
            DataProvider.DongKetNoi(con);
            return cv;
        }
        public static bool XoaChucVuDAO(ChucVuDTO cv)
        {
            string sTruyVan = string.Format(@"delete chucvu where macv = '{0}'", cv.SMaCV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool UpdateChucVuDAO(ChucVuDTO cv)
        {
            string sTruyVan = string.Format(@"update chucvu set tencv = N'{0}', hsphucap = {1} where macv = '{2}'",
                cv.STenCV, cv.FHSPhuCap, cv.SMaCV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool ThemChucVuDAO(ChucVuDTO cv)
        {
            string sTruyVan = string.Format(@"insert into chucvu values (N'{0}', N'{1}', {2})", cv.SMaCV, cv.STenCV, cv.FHSPhuCap);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
