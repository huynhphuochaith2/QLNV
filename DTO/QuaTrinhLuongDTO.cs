using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuaTrinhLuongDTO
    {
        private string sMaNV;
        private DateTime dNgayBD;
        private float sHSLuong;
        private bool bGhichu;

        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public DateTime DNgayBD { get => dNgayBD; set => dNgayBD = value; }
        public float SHSLuong { get => sHSLuong; set => sHSLuong = value; }
        public bool BGhichu { get => bGhichu; set => bGhichu = value; }
    }
}
