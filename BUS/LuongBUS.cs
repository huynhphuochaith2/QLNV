using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class LuongBUS
    {
        public static List<LuongDTO> LayDSLuong()
        {
            return LuongDAO.LayDSLuong();
        }
        public static LuongDTO TimNhanVienTheoMa(string ma)
        {
            return LuongDAO.TimNhanVienTheoMa(ma);
        }
    }
}
