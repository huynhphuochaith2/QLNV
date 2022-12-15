using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class CSDL_DAO
    {
        static SqlConnection con;

        public static bool SaoLuuDuLieu(string sDuongDan)
        {
            string sTen = "\\QLNV(" + DateTime.Now.Day.ToString() + "_" +
            DateTime.Now.Month.ToString() + "_" +
            DateTime.Now.Year.ToString() + "_" +
            DateTime.Now.Hour.ToString() + "_" +
            DateTime.Now.Minute.ToString() + ").bak";
            string sql = "BACKUP DATABASE QLNV TO DISK = N'" + sDuongDan +
           sTen + "'";
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, con);
            return kq;
        }
        public static bool PhucHoiDuLieu(string sDuongDan)
        {
            string sql = "restore DATABASE QLCHNGK from DISK = N'" + sDuongDan + "'";
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.PhucHoi(sql, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
