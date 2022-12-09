using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuaChuXe
{
    public class PhieuThu
    {
        public string PhieuThuID { get; set; }
        public string HoTenNguoiNopPhieuThu { get; set; }
        public string HoTenNguoiThuPhieuThu { get; set; }
        public DateTime NgayThuPhieuThu { get; set; }
        public double SoTienThuPhieuThu { get; set; }

        public string HopDongID { get; set; }
        public HopDong HopDong { get; set; }

        public PhieuThu(string phieuThuID, 
            string hoTenNguoiNopPhieuThu, string hoTenNguoiThuPhieuThu, 
            DateTime ngayThuPhieuThu, double soTienThuPhieuThu, 
            string hopDongID, HopDong hopDong)
        {
            PhieuThuID = phieuThuID;
            HoTenNguoiNopPhieuThu = hoTenNguoiNopPhieuThu;
            HoTenNguoiThuPhieuThu = hoTenNguoiThuPhieuThu;
            NgayThuPhieuThu = ngayThuPhieuThu;
            SoTienThuPhieuThu = soTienThuPhieuThu;
            HopDongID = hopDongID;
            HopDong = hopDong;
        }
    }
}
