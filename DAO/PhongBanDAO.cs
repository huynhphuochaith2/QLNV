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
    public class PhongBanDAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả phòng ban
        public static List<PhongBanDTO> LayDSPhongBan()
        {
            string sTruyVan = "select *from phongban";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<PhongBanDTO> lstPhongBan = new List<DTO.PhongBanDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhongBanDTO pb = new PhongBanDTO();
                pb.Smapb = dt.Rows[i]["mapb"].ToString();
                pb.Stenpb = dt.Rows[i]["tenpb"].ToString();
                pb.Ssdt = dt.Rows[i]["sdt"].ToString();
                pb.Smanv = dt.Rows[i]["manv"].ToString();
                pb.STrang_thai = dt.Rows[i]["Trang_thai"].ToString();
                lstPhongBan.Add(pb);
            }
            DataProvider.DongKetNoi(con);
            return lstPhongBan;
        }

        public static PhongBanDTO TimPhongBanTheoTen(string ma)
        {
            string sTruyVan = string.Format(@"select * from phongban where mapb=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu PhongBanDTO
            PhongBanDTO pb = new PhongBanDTO();
            pb.Smapb = dt.Rows[0]["mapb"].ToString();
            pb.Stenpb = dt.Rows[0]["tenpb"].ToString();
            pb.Ssdt = dt.Rows[0]["sdt"].ToString();
            pb.Smanv = dt.Rows[0]["manv"].ToString();
            pb.STrang_thai = dt.Rows[0]["Trang_thai"].ToString();
            DataProvider.DongKetNoi(con);
            return pb;
        }
        
        // Thêm PB
        public static bool ThemPhongBan(PhongBanDTO pb)
        {
            string sTruyVan = string.Format(@"insert into phongban values(N'{0}',
                N'{1}',N'{2}',N'{3}',N'{4}')", pb.Smapb, pb.Stenpb, pb.Ssdt,
                pb.Smanv,pb.STrang_thai);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool CapNhatPhongBan(PhongBanDTO pb)
        {
            string sTruyVan = string.Format(@"update phongban set 
                tenpb=N'{0}',sdt=N'{1}',manv='{2}',Trang_thai='{3}' where mapb=N'{4}'",
                pb.Stenpb, pb.Ssdt, pb.Smanv, pb.STrang_thai, pb.Smapb);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        // Xóa thông tin 1 phòng ban
        public static bool XoaPhongBan(PhongBanDTO pb)
        {
            string sTruyVan = string.Format(@"delete phongban where mapb = '{0}'", pb.Smapb);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool CapnhatTTPhongBan(PhongBanDTO pb)
        {
            string sTruyVan = string.Format(@"update phongban set Trang_thai=N'{0}'
            where mapb='{1}'", pb.STrang_thai, pb.Smapb);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
