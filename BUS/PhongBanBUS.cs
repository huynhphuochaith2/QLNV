using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class PhongBanBUS
    {
        //Lấy DS phòng ban
        public static List<PhongBanDTO> LayDSPhongBan()
        {
            return PhongBanDAO.LayDSPhongBan();
        }

        // Thêm mới PB
        public static bool ThemPhongBan(PhongBanDTO pb)
        {
            return PhongBanDAO.ThemPhongBan(pb);
        }

        // Tìm PB theo mã
        public static PhongBanDTO TimPhongBanTheoTen(string ma)
        {
            return PhongBanDAO.TimPhongBanTheoTen(ma);
        }

        // Sửa thông tin PB
        public static bool CapNhatPhongBan(PhongBanDTO pb)
        {
            return PhongBanDAO.CapNhatPhongBan(pb);
        }

        // Xóa thông tin PB
        public static bool XoaPhongBan(PhongBanDTO pb)
        {
            return PhongBanDAO.XoaPhongBan(pb);
        }
        public static bool CapnhatTTPhongBan(PhongBanDTO pb)
        {
            return PhongBanDAO.CapnhatTTPhongBan(pb);
        }
    }
}
