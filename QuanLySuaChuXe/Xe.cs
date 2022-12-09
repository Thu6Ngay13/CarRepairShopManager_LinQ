using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuaChuXe
{
    public class Xe
    {
        public string XeID { get; set; }
        public ELoaiXe LoaiXe { get; set; }
        public EHangXe HangXe { get; set; }
        
        public string KhachHangID { get; set; }
        public KhachHang KhachHang { get; set; }
        public ICollection<HopDong> DSHopDong_Xe { get; set; }

        public Xe(string xeID, ELoaiXe loaiXe, 
            EHangXe hangXe, string khachHangID, 
            KhachHang khachHang, ICollection<HopDong> dSHopDong_Xe)
        {
            XeID = xeID;
            LoaiXe = loaiXe;
            HangXe = hangXe;
            KhachHangID = khachHangID;
            KhachHang = khachHang;
            DSHopDong_Xe = dSHopDong_Xe;
        }
    }
}
