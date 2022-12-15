using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string sMaNV;        
        private string sHoLot;       
        private string sTen;       
        private string sPhai;       
        private DateTime dtNgaySinh;      
        private string sMaCV;
        private string sTinhTrang;
        

        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public string SHoLot { get => sHoLot; set => sHoLot = value; }
        public string STen { get => sTen; set => sTen = value; }
        public string SPhai { get => sPhai; set => sPhai = value; }
        public DateTime DtNgaySinh { get => dtNgaySinh; set => dtNgaySinh = value; }
        public string SMaCV { get => sMaCV; set => sMaCV = value; }
        public string STinhTrang { get => sTinhTrang; set => sTinhTrang = value; }
        
    }
}
