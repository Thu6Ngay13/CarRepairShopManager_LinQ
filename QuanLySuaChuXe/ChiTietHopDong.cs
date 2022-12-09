using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace QuanLySuaChuXe
{
    public class ChiTietHopDong
    {
        public string ThoID { get; set; }
        public string CongViecID { get; set; }
        public string HopDongID { get; set; }

        public Tho Tho { get; set; }
        public CongViec CongViec { get; set; }
        public HopDong HopDong { get; set; }

        public ChiTietHopDong(string thoID, string congViecID, 
            string hopDongID, Tho tho, 
            CongViec congViec, HopDong hopDong)
        {
            ThoID = thoID;
            CongViecID = congViecID;
            HopDongID = hopDongID;
            Tho = tho;
            CongViec = congViec;
            HopDong = hopDong;
        }
    }
}
