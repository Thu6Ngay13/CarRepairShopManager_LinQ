using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuaChuXe
{
    public class KhachHang
    {
        public string KhachHangID { get; set; } 
        public string HoTenKhachHang { get; set; }
        public DateTime NgaySinh { get; set; }
        public EGioiTinh GioiTinhKhachHang { get; set; }
        public string SoDienThoaiKhachHang { get; set; }
        
        public ICollection<Xe> DSXe_KhachHang { get; set; }

        public KhachHang(string khachHangID, string hoTenKhachHang, 
            DateTime ngaySinh, EGioiTinh gioiTinhKhachHang, 
            string soDienThoaiKhachHang, ICollection<Xe> dSXe_KhachHang)
        {
            KhachHangID = khachHangID;
            HoTenKhachHang = hoTenKhachHang;
            NgaySinh = ngaySinh;
            GioiTinhKhachHang = gioiTinhKhachHang;
            SoDienThoaiKhachHang = soDienThoaiKhachHang;
            DSXe_KhachHang = dSXe_KhachHang;
        }
    }
}
