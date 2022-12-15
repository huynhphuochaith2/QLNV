using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDungDTO
    {
        private string sTen;
        private string sMatKhau;
        private int iQuyen;

        public string STen { get => sTen; set => sTen = value; }
        public string SMatKhau { get => sMatKhau; set => sMatKhau = value; }
        public int IQuyen { get => iQuyen; set => iQuyen = value; }
    }
}
