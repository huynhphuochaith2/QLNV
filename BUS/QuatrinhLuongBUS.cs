using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class QuatrinhLuongBUS
    {
        public static bool XoaQuaTrinhLuongBUS(string manv)
        {
            return QuaTrinhLuongDAO.XoaQuaTrinhLuongDAO(manv);
        }

        public static List<QuaTrinhLuongDTO> ShowDanhSachQTL_BUS()
        {
            return QuaTrinhLuongDAO.ShowDanhSachQTL_BUS();
        }

        public static bool ThemQuaTrinhLuongBUS(QuaTrinhLuongDTO qtl)
        {
            return QuaTrinhLuongDAO.ThemQuaTrinhLuongDAO(qtl);
        }

        public static bool CapNhatQuaTrinhLuong(QuaTrinhLuongDTO qtl, DateTime ngaybdCu)
        {
            return QuaTrinhLuongDAO.CapNhatQuaTrinhLuong(qtl, ngaybdCu);
        }

        public static bool XoaQuaTrinhLuongTheoNgayBUS(DateTime ngaybdCu)
        {
            return QuaTrinhLuongDAO.XoaQuaTrinhLuongTheoNgayDAO(ngaybdCu);
        }
    }
}
