using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class DuAnBUS
    {
        //Lấy DS dự án
        public static List<DuAnDTO> LayDSDuAn()
        {
            return DuAnDAO.LayDSDuAn();
        }

        // Thêm mới dự án
        public static bool ThemDuAn(DuAnDTO da)
        {
            return DuAnDAO.ThemDuAn(da);
        }

        // Tìm DA theo mã
        public static DuAnDTO TimDuAnTheoMa(string ma)
        {
            return DuAnDAO.TimDuAnTheoMa(ma);
        }

        // Sửa thông tin DA
        public static bool CapNhatDuAn(DuAnDTO da)
        {
            return DuAnDAO.CapNhatDuAn(da);
        }

        // Xóa thông tin DA
        public static bool XoaDuAn(DuAnDTO da)
        {
            return DuAnDAO.XoaDuAn(da);
        }
    }
}
