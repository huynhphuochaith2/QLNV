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
    public class DuAnDAO
    {
        static SqlConnection con;
        // Lấy danh sách tất cả dự án
        public static List<DuAnDTO> LayDSDuAn()
        {
            string sTruyVan = "select * from duan";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DuAnDTO> lstDuAn = new List<DTO.DuAnDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DuAnDTO da = new DuAnDTO();
                da.SMaNV = dt.Rows[i]["manv"].ToString();
                da.SMaDA = dt.Rows[i]["mada"].ToString();
                da.STenDA = dt.Rows[i]["tenda"].ToString();
                da.SMaKyNang = dt.Rows[i]["makynang"].ToString();                
                da.STenKyNang = dt.Rows[i]["tenkynang"].ToString();               
                lstDuAn.Add(da);
            }
            DataProvider.DongKetNoi(con);
            return lstDuAn;
        }
        // Lấy thông tin dự án có mã , trả về null nếu không thấy
        public static DuAnDTO TimDuAnTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from duan where mada=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu DuAnDTO
            DuAnDTO da = new DuAnDTO();
            da.SMaNV = dt.Rows[0]["manv"].ToString();
            da.SMaDA = dt.Rows[0]["mada"].ToString();
            da.STenDA = dt.Rows[0]["tenda"].ToString();
            da.SMaKyNang = dt.Rows[0]["makynang"].ToString();
            da.STenKyNang = dt.Rows[0]["tenkynang"].ToString();
            DataProvider.DongKetNoi(con);
            return da;
        }
        // Thêm DA
        public static bool ThemDuAn(DuAnDTO da)
        {
            string sTruyVan = string.Format(@"insert into duan values(N'{0}',
                N'{1}',N'{2}',N'{3}','{4}')", da.SMaNV, da.SMaDA, da.STenDA,
                da.SMaKyNang, da.STenKyNang);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Cập nhật thông tin DA
        public static bool CapNhatDuAn(DuAnDTO da)
        {
            string sTruyVan = string.Format(@"update duan set tenda=N'{0}',
                makynang=N'{1}',tenkynang=N'{2}',manv='{3}' where mada=N'{4}'",
                 da.STenDA, da.SMaKyNang, da.STenKyNang, da.SMaNV, da.SMaDA);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Xóa thông tin 1 dự án
        public static bool XoaDuAn(DuAnDTO da)
        {
            string sTruyVan = string.Format(@"delete from duan where mada=N'{0}'", da.SMaDA);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
