using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuaChuXe
{
    public class HopDong
    {
        public string HopDongID { get; set; }
        public string TenHopDong { get; set; }
        public DateTime NgayBatDauHopDong { get; set; }
        public DateTime NgayKetThucHopDong { get; set; }
        public double GiaTriHopDong { get; set; }

        public string XeID { get; set; }
        public Xe Xe { get; set; }
        public ICollection<PhieuThu> DSPhieuThu_HopDong { get; set; }

        public HopDong(string hopDongID, 
            string tenHopDong, DateTime ngayBatDauHopDong, 
            DateTime ngayKetThucHopDong, double giaTriHopDong, 
            string xeID, Xe xe, ICollection<PhieuThu> dSPhieuThu_HopDong)
        {
            HopDongID = hopDongID;
            TenHopDong = tenHopDong;
            NgayBatDauHopDong = ngayBatDauHopDong;
            NgayKetThucHopDong = ngayKetThucHopDong;
            GiaTriHopDong = giaTriHopDong;
            XeID = xeID;
            Xe = xe;
            DSPhieuThu_HopDong = dSPhieuThu_HopDong;
        }
    }
}
