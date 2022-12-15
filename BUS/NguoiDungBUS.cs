using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class NguoiDungBUS
    {
        public static NguoiDungDTO LayNguoiDung(string ten, string matkhau)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = NguoiDungBUS.GetMd5Hash(md5Hash, matkhau);
            return NguoiDungDAO.LayNguoiDung(ten, matkhauMH);
        }
        public static bool CapNhatNguoiDungBUS(string ten, string mkmoi)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = NguoiDungBUS.GetMd5Hash(md5Hash, mkmoi);
            return NguoiDungDAO.CapNhatNguoiDungDAO(ten, matkhauMH);
        }

        public static List<NguoiDungDTO> DanhSachNguoiDungBUS()
        {
            return NguoiDungDAO.DanhSachNguoiDungDAO();
        }
        public static bool CapNhatMatKhau(NguoiDungDTO nd)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = NguoiDungBUS.GetMd5Hash(md5Hash, nd.SMatKhau);
            nd.SMatKhau = matkhauMH;
            return NguoiDungDAO.CapNhatMatKhau(nd);
        }
        // Hàm mã hóa
        // Tham khảo tại
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2")); 
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public static bool ThemNguoiDungBUS(string ten, string matkhau, int quyen)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = NguoiDungBUS.GetMd5Hash(md5Hash, matkhau);
            return NguoiDungDAO.ThemNguoiDungDAO(ten, matkhauMH, quyen);
        }

        public static bool XoaNhanVienBUS(string ten)
        {
            return NguoiDungDAO.XoaNguoiDungDAO(ten);
        }

        public static List<NguoiDungDTO> KiemTraID(string sTen)
        {
            return NguoiDungDAO.KiemTraID(sTen);
        }

        public static bool ThayDoiQuyenND_DAO(string id, int thaydoi)
        {
            return NguoiDungDAO.ThayDoiQuyenND_BUS(id, thaydoi);
        }

        public static bool CapLaiMatKhauBUS(string id)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = NguoiDungBUS.GetMd5Hash(md5Hash, "123");
            return NguoiDungDAO.CapLaiMatKhauDAO(id, matkhauMH);
        }
    }
}
