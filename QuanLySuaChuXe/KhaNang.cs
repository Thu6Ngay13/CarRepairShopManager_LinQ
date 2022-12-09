using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuaChuXe
{
    public class KhaNang
    {
        public string ThoID { get; set; }
        public string CongViecID { get; set; }

        public Tho Tho { get; set; }
        public CongViec CongViec { get; set; }

        public KhaNang(string thoID, string congViecID, 
            Tho tho, CongViec congViec)
        {
            ThoID = thoID;
            CongViecID = congViecID;
            Tho = tho;
            CongViec = congViec;
        }
    }
}
