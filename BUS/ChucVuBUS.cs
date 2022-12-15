using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class ChucVuBUS
    {
        public static List<ChucVuDTO> LayChucVu()
        {
            return ChucVuDAO.LayChucVu();
        }
        public static ChucVuDTO TimChucVuTheoMa(string ma)
        {
            return ChucVuDAO.TimChucVuTheoMa(ma);
        }
        public static bool ThemChucVuDAO(ChucVuDTO cv)
        {
            return ChucVuDAO.ThemChucVuDAO(cv);
        }

        public static bool UpdateChucVuBUS(ChucVuDTO cv)
        {
            return ChucVuDAO.UpdateChucVuDAO(cv);
        }

        public static bool XoaChucVuBUS(ChucVuDTO cv)
        {
            return ChucVuDAO.XoaChucVuDAO(cv);
        }
    }
}
