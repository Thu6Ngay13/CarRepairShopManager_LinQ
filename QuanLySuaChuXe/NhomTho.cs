using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySuaChuXe
{
    public class NhomTho
    {
        public string NhomThoID { get; set; } 
        public string TenNhom { get; set; }

        public string TruongNhomID { get; set; }
        public Tho TruongNhom { get; set; }
        public ICollection<Tho> DSTho_Nhom { get; set; }

        public NhomTho(string nhomThoID, 
            string tenNhom, string truongNhomID,
            Tho truongNhom, ICollection<Tho> dSTho_Nhom)
        {
            NhomThoID = nhomThoID;
            TenNhom = tenNhom;
            TruongNhomID = truongNhomID;
            TruongNhom = truongNhom;
            DSTho_Nhom = dSTho_Nhom;
        }
    }
}
