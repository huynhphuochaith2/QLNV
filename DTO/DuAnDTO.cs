using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DuAnDTO
    {
        private string sMaNV;
        private string sMaDA;
        private string sTenDA;
        private string sMaKyNang;
        private string sTenKyNang;

        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public string SMaDA { get => sMaDA; set => sMaDA = value; }
        public string STenDA { get => sTenDA; set => sTenDA = value; }
        public string SMaKyNang { get => sMaKyNang; set => sMaKyNang = value; }
        public string STenKyNang { get => sTenKyNang; set => sTenKyNang = value; }
    }
}
