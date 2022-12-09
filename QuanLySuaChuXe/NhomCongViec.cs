using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuaChuXe
{
    public class NhomCongViec
    {
        public string NhomCongViecID { get; set; }
        public string TenNhomCongViec { get; set; }

        public ICollection<CongViec> DSCongViec_Nhom { get; set; }

        public NhomCongViec(string nhomCongViecID, 
            string tenNhomCongViec, ICollection<CongViec> dSCongViec_Nhom)
        {
            NhomCongViecID = nhomCongViecID;
            TenNhomCongViec = tenNhomCongViec;
            DSCongViec_Nhom = dSCongViec_Nhom;
        }
    }
}
