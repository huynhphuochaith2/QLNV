using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LuongDTO
    {
        private int iluongcoban;
        private string smanv;
        private float fhsluong;
        private float fhsphucap;
        private int ingaycong;

        public int Iluongcoban { get => iluongcoban; set => iluongcoban = value; }
        public string Smanv { get => smanv; set => smanv = value; }
        public float Fhsluong { get => fhsluong; set => fhsluong = value; }
        public float Fhsphucap { get => fhsphucap; set => fhsphucap = value; }
        public int Ingaycong { get => ingaycong; set => ingaycong = value; }
    }
}
