using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuaChuXe
{
    public class CongViec
    {
        public string CongViecID { get; set; }
        public string TenCongViec { get; set; }
        
        public string NhomCongViecID { get; set; }
        public NhomCongViec NhomCongViec { get; set; }

        public CongViec(string congViecID, string tenCongViec, 
            string nhomCongViecID, NhomCongViec nhomCongViec)
        {
            CongViecID = congViecID;
            TenCongViec = tenCongViec;
            NhomCongViecID = nhomCongViecID;
            NhomCongViec = nhomCongViec;
        }
    }
}
