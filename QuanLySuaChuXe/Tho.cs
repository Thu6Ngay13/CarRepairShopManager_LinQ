using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuaChuXe
{
    public class Tho
    {
        public string ThoID { get; set; }
        public string HoTenTho { get; set; }
        public DateTime NgaySinhTho { get; set; }
        public EGioiTinh GioiTinhTho { get; set; }
        public string DiaChiTho { get; set; }  
        public double LuongTho { get; set; }

        public string NhomThoID { get; set; }
        public NhomTho NhomTho;

        public Tho(string thoID, string hoTenTho, 
            DateTime ngaySinhTho, EGioiTinh gioiTinhTho, 
            string diaChiTho, double luongTho, 
            string nhomThoID, NhomTho nhomTho)
        {
            ThoID = thoID;
            HoTenTho = hoTenTho;
            NgaySinhTho = ngaySinhTho;
            GioiTinhTho = gioiTinhTho;
            DiaChiTho = diaChiTho;
            LuongTho = luongTho;
            NhomThoID = nhomThoID;
            NhomTho = nhomTho;
        }
    }
}
