using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace QuanLySuaChuXe
{
    public class Program
    {
        /*------------------------------Table--------------------------------*/

        public static List<NhomTho> DSNhomTho= new List<NhomTho>();
        public static List<Tho> DSTho= new List<Tho>();

        public static List<NhomCongViec> DSNhomCongViec = new List<NhomCongViec>();
        public static List<CongViec> DSCongViec = new List<CongViec>();
        
        public static List<KhachHang> DSKhachHang = new List<KhachHang>();
        public static List<Xe> DSXe = new List<Xe>();
        public static List<HopDong> DSHopDong = new List<HopDong>();
        public static List<PhieuThu> DSPhieuThu = new List<PhieuThu>();

        public static List<KhaNang> DSKhaNang = new List<KhaNang>();
        public static List<ChiTietHopDong> DSChiTietHopDong = new List<ChiTietHopDong>();

        /*------------------------------Data---------------------------------*/

        public static void TaoDanhSachNhomTho()
        {
            DSNhomTho.Add(new NhomTho("NT01", "Nhóm số 1", "", null, new List<Tho>()));
            DSNhomTho.Add(new NhomTho("NT02", "Nhóm số 2", "", null, new List<Tho>()));
            DSNhomTho.Add(new NhomTho("NT03", "Nhóm số 3", "", null, new List<Tho>()));
        }
        public static void TaoDanhSachTho()
        {
            DSTho.Add(new Tho("T01", "Nguyễn Văn Đức",
                new DateTime(1998, 8, 8), EGioiTinh.Nam, 
                "Quận 9", 3400, 
                DSNhomTho[0].NhomThoID, DSNhomTho[0]));
            DSTho.Add(new Tho("T02", "Lê Xuân Hùng", 
                new DateTime(1999, 9, 9), EGioiTinh.Nam,
                "Quận 8", 1900, 
                DSNhomTho[0].NhomThoID, DSNhomTho[0]));
            DSTho.Add(new Tho("T03", "Vũ Trọng Dũng", 
                new DateTime(2001, 1, 1), EGioiTinh.Nam, 
                "Quận 7", 1600, 
                DSNhomTho[0].NhomThoID, DSNhomTho[0]));

            DSNhomTho[0].TruongNhomID = DSTho[0].ThoID;
            DSNhomTho[0].TruongNhom = DSTho[0];
            DSNhomTho[0].DSTho_Nhom.Add(DSTho[0]);
            DSNhomTho[0].DSTho_Nhom.Add(DSTho[1]);
            DSNhomTho[0].DSTho_Nhom.Add(DSTho[2]);

            DSTho.Add(new Tho("T04", "Hoàng Anh Tài",
                new DateTime(2000, 4, 4), EGioiTinh.Nam, 
                "Quận 6", 2600, 
                DSNhomTho[1].NhomThoID, DSNhomTho[1]));
            DSTho.Add(new Tho("T05", "Lê Đức Dũng", 
                new DateTime(1996, 6, 6), EGioiTinh.Nam, 
                "Quận 5", 2600,
                DSNhomTho[1].NhomThoID, DSNhomTho[1]));
            DSTho.Add(new Tho("T06", "Trần Trọng Mạnh",
                new DateTime(2002, 2, 2), EGioiTinh.Nam, 
                "Quận 4", 1600,
                DSNhomTho[1].NhomThoID, DSNhomTho[1]));

            DSNhomTho[1].TruongNhomID = DSTho[3].ThoID;
            DSNhomTho[1].TruongNhom = DSTho[3];
            DSNhomTho[1].DSTho_Nhom.Add(DSTho[3]);
            DSNhomTho[1].DSTho_Nhom.Add(DSTho[4]);
            DSNhomTho[1].DSTho_Nhom.Add(DSTho[5]);

            DSTho.Add(new Tho("T07", "Võ Tấn Sơn",
                new DateTime(2003, 3, 3), EGioiTinh.Nam, 
                "Quận 3", 2600, 
                DSNhomTho[2].NhomThoID, DSNhomTho[2]));
            DSTho.Add(new Tho("T08", "Nguyễn Anh Tài", 
                new DateTime(1997, 7, 7), EGioiTinh.Nam, 
                "Quận 2", 1700,
                DSNhomTho[2].NhomThoID, DSNhomTho[2]));
            DSTho.Add(new Tho("T09", "Lưu Viết Vũ",
                new DateTime(1995, 5, 5), EGioiTinh.Nam, 
                "Quận 1", 2500,
                DSNhomTho[2].NhomThoID, DSNhomTho[2]));

            DSNhomTho[2].TruongNhomID = DSTho[6].ThoID;
            DSNhomTho[2].TruongNhom = DSTho[6];
            DSNhomTho[2].DSTho_Nhom.Add(DSTho[6]);
            DSNhomTho[2].DSTho_Nhom.Add(DSTho[7]);
            DSNhomTho[2].DSTho_Nhom.Add(DSTho[8]);
        }

        public static void TaoDanhSachNhomCongViec()
        {
            DSNhomCongViec.Add(new NhomCongViec("NCV01", 
                "Nhóm công việc bảo dưỡng, bảo trì và sữa chữa"
                , new List<CongViec>()));
            DSNhomCongViec.Add(new NhomCongViec("NCV02", 
                "Nhóm công việc thiết kế, chế tạo và lắp đặt"
                , new List<CongViec>()));
        }
        public static void TaoDanhSachCongViec()
        {
            DSCongViec.Add(new CongViec("CV01", 
                "Bảo dưỡng, bảo trì và sữa chữa chữa động cơ", 
                DSNhomCongViec[0].NhomCongViecID, DSNhomCongViec[0]));
            DSCongViec.Add(new CongViec("CV02", 
                "Bảo dưỡng, bảo trì và sữa chữa nội thất, phụ tùng",
                DSNhomCongViec[0].NhomCongViecID, DSNhomCongViec[0]));
            DSCongViec.Add(new CongViec("CV03", 
                "Thiết kế và nâng cấp động cơ",
                DSNhomCongViec[1].NhomCongViecID, DSNhomCongViec[1]));
            DSCongViec.Add(new CongViec("CV04", 
                "Thiết kế, chế tạo và lắp đặt nội thất, phụ tùng",
                DSNhomCongViec[1].NhomCongViecID, DSNhomCongViec[1]));
        }

        public static void TaoDanhSachKhachHang()
        {
            DSKhachHang.Add(new KhachHang("KH01", "Dương Mai Xuân", 
                new DateTime(1978, 3, 18), EGioiTinh.Nu, 
                "0999888777", new List<Xe>()));
            DSKhachHang.Add(new KhachHang("KH02", "Hoàng Hùng Dũng",
                new DateTime(1988, 9, 27), EGioiTinh.Nam,
                "0888777666", new List<Xe>()));
            DSKhachHang.Add(new KhachHang("KH03", "Triệu Lệ Mai",
                new DateTime(1988, 12, 12), EGioiTinh.Nu,
                "0666555444", new List<Xe>()));
        }
        public static void TaoDanhSachXe()
        {
            DSXe.Add(new Xe("X01", ELoaiXe.Motorbike, 
                EHangXe.Yamaha, "KH01"
                , DSKhachHang[0], new List<HopDong>()));
            DSXe.Add(new Xe("X02", ELoaiXe.Car,
                EHangXe.Toyota, "KH01"
                , DSKhachHang[0], new List<HopDong>()));

            DSKhachHang[0].DSXe_KhachHang.Add(DSXe[0]);
            DSKhachHang[0].DSXe_KhachHang.Add(DSXe[1]);

            DSXe.Add(new Xe("X03", ELoaiXe.Motorbike,
                EHangXe.Honda, "KH02", 
                DSKhachHang[1], new List<HopDong>()));
            DSXe.Add(new Xe("X04", ELoaiXe.Motorbike,
                EHangXe.Kawasaki, "KH02", 
                DSKhachHang[1], new List<HopDong>()));
            DSXe.Add(new Xe("X05", ELoaiXe.Car,
                EHangXe.SYM, "KH02",
                DSKhachHang[1], new List<HopDong>()));

            DSKhachHang[1].DSXe_KhachHang.Add(DSXe[2]);
            DSKhachHang[1].DSXe_KhachHang.Add(DSXe[3]);
            DSKhachHang[1].DSXe_KhachHang.Add(DSXe[4]);

            DSXe.Add(new Xe("X06", ELoaiXe.Motorbike,
                EHangXe.Suzuki, "KH03",
                DSKhachHang[2], new List<HopDong>()));

            DSKhachHang[2].DSXe_KhachHang.Add(DSXe[5]);
        }
        public static void TaoDanhSachHopDong()
        {
            DSHopDong.Add(new HopDong("HD01",
                "Hợp đồng bảo trì và sữa chữa động cơ",
                new DateTime(2022, 1, 1), new DateTime(2022, 7, 1), 
                5000, "X01",
                DSXe[0], new List<PhieuThu>()));

            DSXe[0].DSHopDong_Xe.Add(DSHopDong[0]);

            DSHopDong.Add(new HopDong("HD02",
                "Hợp đồng bảo dưỡng và sữa chữa nội thất",
                new DateTime(2022, 2, 1), new DateTime(2022, 8, 1), 
                4000, "X02",
                DSXe[1], new List<PhieuThu>()));
            DSHopDong.Add(new HopDong("HD03",
                "Hợp đồng thiết kế và nâng cấp động cơ, thiết và nâng cấp nội thất",
                new DateTime(2022, 2, 1), new DateTime(2022, 8, 1),
                8000, "X02",
                DSXe[1], new List<PhieuThu>()));

            DSXe[1].DSHopDong_Xe.Add(DSHopDong[1]);
            DSXe[1].DSHopDong_Xe.Add(DSHopDong[2]);

            DSHopDong.Add(new HopDong("HD04", 
                "Hợp đồng thiết kế và nâng cấp động cơ", 
                new DateTime(2022, 3, 1), new DateTime(2022, 9, 1),
                4500, "X03",
                DSXe[2], new List<PhieuThu>()));

            DSXe[2].DSHopDong_Xe.Add(DSHopDong[3]);

            DSHopDong.Add(new HopDong("HD05",
                "Hợp đồng bảo dưỡng và nâng cấp nội thất",
                new DateTime(2022, 4, 1), new DateTime(2022, 10, 1),
                7500, "X04",
                DSXe[3], new List<PhieuThu>()));

            DSXe[3].DSHopDong_Xe.Add(DSHopDong[4]);

            DSHopDong.Add(new HopDong("HD06", 
                "Hợp đồng bảo trì và sữa chữa phụ tùng", 
                new DateTime(2022, 5, 1), new DateTime(2022, 11, 1), 
                4000, "X05",
                DSXe[4], new List<PhieuThu>()));
            
            DSXe[4].DSHopDong_Xe.Add(DSHopDong[5]);

            DSHopDong.Add(new HopDong("HD07", 
                "Hợp đồng thiết kế và nâng cấp động cơ", 
                new DateTime(2022, 6, 1), new DateTime(2022, 12, 1),
                4500, "X06",
                DSXe[5], new List<PhieuThu>()));
            DSHopDong.Add(new HopDong("HD08",
                "Hợp đồng bảo trì sữa chữa, thiết kế và nâng cấp và lắp nội thất",
                new DateTime(2022, 7, 1), new DateTime(2023, 1, 1),
                7500, "X06",
                DSXe[5], new List<PhieuThu>()));
            DSHopDong.Add(new HopDong("HD09",
                "Hợp đồng bảo trì và sữa chữa động cơ, thiết kế, nâng cấp và lắp đặt phụ tùng",
                new DateTime(2022, 8, 1), new DateTime(2023, 2, 1),
                8500, "X06",
                DSXe[5], new List<PhieuThu>()));

            DSXe[5].DSHopDong_Xe.Add(DSHopDong[6]);
            DSXe[5].DSHopDong_Xe.Add(DSHopDong[7]);
            DSXe[5].DSHopDong_Xe.Add(DSHopDong[8]);

        }
        public static void TaoDanhSachPhieuThu()
        {
            DSPhieuThu.Add(new PhieuThu("PT01", "Dương Xuân Mai",
                "Nguyễn Phương Ngọc", new DateTime(2022, 1, 1),
                1000, "HD01", DSHopDong[0]));
            DSPhieuThu.Add(new PhieuThu("PT02", "Trần Cẩm Ánh",
                "Nguyễn Hồng Nhung", new DateTime(2022, 2, 22),
                3000, "HD01", DSHopDong[0]));

            DSHopDong[0].DSPhieuThu_HopDong.Add(DSPhieuThu[0]);
            DSHopDong[0].DSPhieuThu_HopDong.Add(DSPhieuThu[1]);

            DSPhieuThu.Add(new PhieuThu("PT03", "Dương Xuân Mai",
                "Mai Thảo Hương", new DateTime(2022, 2, 1),
                4000, "HD02", DSHopDong[1]));

            DSHopDong[1].DSPhieuThu_HopDong.Add(DSPhieuThu[2]);

            DSPhieuThu.Add(new PhieuThu("PT04", "Dương Xuân Mai",
                "Nguyễn Phương Ngọc", new DateTime(2022, 2, 1),
                3000, "HD03", DSHopDong[2]));
            DSPhieuThu.Add(new PhieuThu("PT05", "Triệu Lệ Mai",
                "Mai Thảo Hương", new DateTime(2022, 3, 5),
                500, "HD03", DSHopDong[2]));
            DSPhieuThu.Add(new PhieuThu("PT06", "Đỗ Mỹ Duyên",
                "Nguyễn Hồng Nhung", new DateTime(2022, 3, 25),
                1000, "HD03", DSHopDong[2]));
            DSPhieuThu.Add(new PhieuThu("PT07", "Triệu Lệ Mai",
                "Mai Thảo Hương", new DateTime(2022, 4, 7),
                2500, "HD03", DSHopDong[2]));

            DSHopDong[2].DSPhieuThu_HopDong.Add(DSPhieuThu[3]);
            DSHopDong[2].DSPhieuThu_HopDong.Add(DSPhieuThu[4]);
            DSHopDong[2].DSPhieuThu_HopDong.Add(DSPhieuThu[5]);
            DSHopDong[2].DSPhieuThu_HopDong.Add(DSPhieuThu[6]);

            DSPhieuThu.Add(new PhieuThu("PT08", "Hoàng Hùng Dũng",
                "Nguyễn Phương Ngọc", new DateTime(2022, 3, 1),
                4500, "HD04", DSHopDong[3]));

            DSHopDong[3].DSPhieuThu_HopDong.Add(DSPhieuThu[7]);

            DSPhieuThu.Add(new PhieuThu("PT09", "Hoàng Hùng Dũng",
                "Mai Thảo Hương", new DateTime(2022, 4, 1),
                4000, "HD05", DSHopDong[4]));
            DSPhieuThu.Add(new PhieuThu("PT10", "Vũ Đình Huế",
                "Nguyễn Hồng Nhung", new DateTime(2022, 7, 23),
                3500, "HD05", DSHopDong[4]));

            DSHopDong[4].DSPhieuThu_HopDong.Add(DSPhieuThu[8]);
            DSHopDong[4].DSPhieuThu_HopDong.Add(DSPhieuThu[9]);

            DSPhieuThu.Add(new PhieuThu("PT11", "Hoàng Hùng Dũng",
                "Mai Thảo Hương", new DateTime(2022, 5, 1),
                4000, "HD06", DSHopDong[5]));

            DSHopDong[5].DSPhieuThu_HopDong.Add(DSPhieuThu[10]);

            DSPhieuThu.Add(new PhieuThu("PT12", "Triệu Lệ Mai",
                "Mai Thảo Hương", new DateTime(2022, 6, 1),
                4500, "HD07", DSHopDong[6]));

            DSHopDong[6].DSPhieuThu_HopDong.Add(DSPhieuThu[11]);

            DSPhieuThu.Add(new PhieuThu("PT13", "Triệu Lệ Mai",
                "Nguyễn Phương Ngọc", new DateTime(2022, 7, 1),
                3500, "HD08", DSHopDong[7]));
            DSPhieuThu.Add(new PhieuThu("PT14", "Triệu Lệ Mai",
                "Mai Thảo Hương", new DateTime(2022, 8, 19),
                2500, "HD08", DSHopDong[7]));
            DSPhieuThu.Add(new PhieuThu("PT15", "Võ Sương Kim",
                "Nguyễn Hồng Nhung", new DateTime(2022, 11, 8),
                1500, "HD08", DSHopDong[7]));

            DSHopDong[7].DSPhieuThu_HopDong.Add(DSPhieuThu[12]);
            DSHopDong[7].DSPhieuThu_HopDong.Add(DSPhieuThu[13]);
            DSHopDong[7].DSPhieuThu_HopDong.Add(DSPhieuThu[14]);

            DSPhieuThu.Add(new PhieuThu("PT16", "Triệu Lệ Mai",
                "Nguyễn Hồng Nhung", new DateTime(2022, 8, 1),
                5500, "HD09", DSHopDong[8]));
            DSPhieuThu.Add(new PhieuThu("PT17", "Võ Sương Kim",
                "Nguyễn Hồng Nhung", new DateTime(2023, 1, 24),
                2500, "HD09", DSHopDong[8]));
            DSPhieuThu.Add(new PhieuThu("PT18", "Trần Bá Phong",
                "Nguyễn Hồng Nhung", new DateTime(2023, 2, 1),
                500, "HD09", DSHopDong[8]));
            
            DSHopDong[8].DSPhieuThu_HopDong.Add(DSPhieuThu[15]);
            DSHopDong[8].DSPhieuThu_HopDong.Add(DSPhieuThu[16]);
            DSHopDong[8].DSPhieuThu_HopDong.Add(DSPhieuThu[17]);
        }

        public static void TaoDanhSachKhaNang()
        {
            DSKhaNang.Add(new KhaNang("T01", "CV1", DSTho[0], DSCongViec[0]));
            DSKhaNang.Add(new KhaNang("T01", "CV2", DSTho[0], DSCongViec[1]));
            DSKhaNang.Add(new KhaNang("T02", "CV3", DSTho[1], DSCongViec[2]));
            DSKhaNang.Add(new KhaNang("T03", "CV4", DSTho[2], DSCongViec[3]));
            DSKhaNang.Add(new KhaNang("T04", "CV1", DSTho[3], DSCongViec[0]));
            DSKhaNang.Add(new KhaNang("T05", "CV2", DSTho[4], DSCongViec[1]));
            DSKhaNang.Add(new KhaNang("T06", "CV3", DSTho[5], DSCongViec[2]));
            DSKhaNang.Add(new KhaNang("T06", "CV4", DSTho[5], DSCongViec[3]));
            DSKhaNang.Add(new KhaNang("T07", "CV1", DSTho[6], DSCongViec[0]));
            DSKhaNang.Add(new KhaNang("T08", "CV2", DSTho[7], DSCongViec[1]));
            DSKhaNang.Add(new KhaNang("T08", "CV3", DSTho[7], DSCongViec[2]));
            DSKhaNang.Add(new KhaNang("T09", "CV4", DSTho[8], DSCongViec[3]));

        }
        public static void TaoDanhSachChiTietHopDong()
        {
            DSChiTietHopDong.Add(new ChiTietHopDong("T01", "CV01", "HD01",
                DSTho[0], DSCongViec[0], DSHopDong[0]));
            DSChiTietHopDong.Add(new ChiTietHopDong("T08", "CV02", "HD02",
                DSTho[7], DSCongViec[1], DSHopDong[1]));
            DSChiTietHopDong.Add(new ChiTietHopDong("T02", "CV03", "HD03",
                DSTho[1], DSCongViec[2], DSHopDong[2]));
            DSChiTietHopDong.Add(new ChiTietHopDong("T06", "CV04", "HD03",
                DSTho[5], DSCongViec[3], DSHopDong[2]));
            DSChiTietHopDong.Add(new ChiTietHopDong("T08", "CV03", "HD04",
                DSTho[7], DSCongViec[2], DSHopDong[3]));
            DSChiTietHopDong.Add(new ChiTietHopDong("T05", "CV02", "HD05",
                DSTho[4], DSCongViec[1], DSHopDong[4]));
            DSChiTietHopDong.Add(new ChiTietHopDong("T09", "CV04", "HD05",
                DSTho[8], DSCongViec[3], DSHopDong[4]));
            DSChiTietHopDong.Add(new ChiTietHopDong("T01", "CV02", "HD06",
                DSTho[0], DSCongViec[1], DSHopDong[5]));
            DSChiTietHopDong.Add(new ChiTietHopDong("T02", "CV03", "HD07",
                DSTho[1], DSCongViec[2], DSHopDong[6]));
            DSChiTietHopDong.Add(new ChiTietHopDong("T04", "CV02", "HD08",
                DSTho[3], DSCongViec[1], DSHopDong[7]));
            DSChiTietHopDong.Add(new ChiTietHopDong("T03", "CV04", "HD08",
                DSTho[2], DSCongViec[3], DSHopDong[7]));
            DSChiTietHopDong.Add(new ChiTietHopDong("T07", "CV01", "HD09",
                DSTho[6], DSCongViec[0], DSHopDong[8]));
            DSChiTietHopDong.Add(new ChiTietHopDong("T03", "CV04", "HD09",
                DSTho[2], DSCongViec[3], DSHopDong[8]));
        }

        /*------------------------------Query--------------------------------*/

        public static void Cau1()
        {
            /*
             * 1. Lấy ra ID, tên, giới tính, tuổi, lương 
             * của thợ
             * có lương lớn hơn 2500,
             * sắp xếp tăng dần theo tên, tuổi, lương, ID
             */

            var kq =
                from tho in DSTho
                where tho.LuongTho > 2500
                let lhoten = tho.HoTenTho.Split(' ')
                let ltuoi = DateTime.Now.Year - tho.NgaySinhTho.Year
                orderby lhoten[lhoten.Length - 1],
                    ltuoi,
                    tho.LuongTho,
                    tho.ThoID
                select new
                {
                    id = tho.ThoID,
                    gioitinh = tho.GioiTinhTho,
                    hoten = tho.HoTenTho,
                    tuoi = ltuoi,
                    luong = tho.LuongTho
                };

            foreach (var t in kq)
            {
                Console.WriteLine("ID thợ: {0}", t.id);
                Console.WriteLine("\t họ tên thợ: {0},", t.hoten);
                Console.WriteLine("\t giới tính thợ: {0},", t.gioitinh);
                Console.WriteLine("\t tuổi thợ: {0},", t.tuoi);
                Console.WriteLine("\t lương thợ: {0}", t.luong);
            }
        }

        public static void Cau2()
        {
            /*
             * 2. khách hàng tên: Dũng, giới tính: Nam, có số điện thoại: 0888777666
             * muốn biết thông tin xe mà khách hàng đã và đang sửa chữa hay nâng cấp
             */

            var kq =
                from kh in DSKhachHang
                let lhoten = kh.HoTenKhachHang.Split(' ')
                where lhoten[lhoten.Length - 1].Equals("Dũng") 
                    && kh.GioiTinhKhachHang == EGioiTinh.Nam
                    && kh.SoDienThoaiKhachHang.Equals("0888777666")
                select new
                {
                    id = kh.KhachHangID,
                    hoten = kh.HoTenKhachHang,
                    gioitinh = kh.GioiTinhKhachHang,
                    tuoi = DateTime.Now.Year - kh.NgaySinh.Year,
                    sodienthoai = kh.SoDienThoaiKhachHang,
                    danhsachxe =
                        from x in kh.DSXe_KhachHang
                        select new
                        {
                            id = x.XeID,
                            loai = x.LoaiXe,
                            hang = x.HangXe,
                        }

                };

            foreach (var kh in kq)
            {
                Console.WriteLine("ID khách hàng: {0}", kh.id);
                Console.WriteLine("\t họ tên khách hàng: {0},", kh.hoten);
                Console.WriteLine("\t giới tính khách hàng: {0},", kh.gioitinh);
                Console.WriteLine("\t tuổi khách hàng: {0},", kh.tuoi);
                Console.WriteLine("\t số điện thoại khách hàng: {0}", kh.sodienthoai);
                foreach (var x in kh.danhsachxe)
                {
                    Console.WriteLine("\t\t ID xe: {0}", x.id);
                    Console.WriteLine("\t\t\t loại xe: {0},", x.loai);
                    Console.WriteLine("\t\t\t hãng xe: {0}", x.hang);
                }
            }
        }

        public static void Cau3()
        {
            /*
             * 3. Lấy ra ID, tên, giới tính, tuổi, số điện thoại, tổng giá trị tất cả hợp đồng 
             * của khách hàng 
             * sắp xếp giảm dần theo tổng giá trị tất cả hợp đồng,
             *         tăng dần theo tên, ID 
             */

            var kq =
                from kh in DSKhachHang
                let lsotien =
                    kh.DSXe_KhachHang
                        .SelectMany(x => x.DSHopDong_Xe)
                        .Sum(hd => hd.GiaTriHopDong)
                let lten = kh.HoTenKhachHang.Split(' ')
                orderby lsotien descending, lten[lten.Length - 1], kh.KhachHangID 
                select new
                {
                    id = kh.KhachHangID,
                    hoten = kh.HoTenKhachHang,
                    gioitinh = kh.GioiTinhKhachHang,
                    tuoi = DateTime.Now.Year - kh.NgaySinh.Year,
                    sodienthoai = kh.SoDienThoaiKhachHang,
                    sotien = lsotien
                };

            foreach(var kh in kq)
            {
                Console.WriteLine("ID khách hàng: {0}", 
                    kh.id);
                Console.WriteLine("\t họ tên khách hàng: {0},", 
                    kh.hoten);
                Console.WriteLine("\t giới tính khách hàng: {0},", 
                    kh.gioitinh);
                Console.WriteLine("\t tuổi khách hàng: {0},", 
                    kh.tuoi);
                Console.WriteLine("\t số điện thoại khách hàng: {0}", 
                    kh.sodienthoai);
                Console.WriteLine("\t tổng giá trị tất cả hợp đồng của khách hàng: {0}", 
                    kh.sotien);
            }
        }

        public static void Cau4()
        {
            /*
             * 4. Lấy ra thông ID, loại, hãng, số lượng hợp đồng 
             * của xe
             * có số lượng hợp đồng > 1
             * sắp xếp theo xe giảm dần theo số lượng hợp đồng, loại, hãng, ID
             */

            var kq =
                from x in DSXe
                let lsoluonghopdong = x.DSHopDong_Xe.Count()
                where lsoluonghopdong > 1
                orderby lsoluonghopdong descending,
                       x.LoaiXe descending,
                       x.HangXe descending,
                       x.XeID descending
                select new
                {
                    idxe = x.XeID,
                    loai = x.LoaiXe,
                    hang = x.HangXe,
                    soluonghopdong = lsoluonghopdong
                };

            foreach (var x in kq)
            {
                Console.WriteLine("ID xe: {0}", x.idxe);
                Console.WriteLine("\t loại xe: {0},", x.loai);
                Console.WriteLine("\t hãng xe: {0},", x.hang);
                Console.WriteLine("\t số lượng hợp đồng: {0}", x.soluonghopdong);
            }
        }

        public static void Cau5()
        {
            /*
             * 5. Khách hàng tên chỉ biết mình tên là: Xuân, giới tính: Nữ,
             * đến hỏi mình còn nợ bao nhiêu tiền sửa, nâng cấp cho các chiếc xe
             */

            var kq =
                from kh in DSKhachHang
                let lhoten = kh.HoTenKhachHang.Split(' ')
                where lhoten[lhoten.Length - 1].Equals("Xuân") 
                    && kh.GioiTinhKhachHang == EGioiTinh.Nu
                let ldanhsachhopdong = kh.DSXe_KhachHang.SelectMany(x => x.DSHopDong_Xe)
                let lsotienhopdong = ldanhsachhopdong.Sum(hd => hd.GiaTriHopDong)
                let lsotiendatra = ldanhsachhopdong
                    .SelectMany(hd => hd.DSPhieuThu_HopDong)
                    .Sum(pt => pt.SoTienThuPhieuThu)
                select new
                {
                    id = kh.KhachHangID,
                    hoten = kh.HoTenKhachHang,
                    gioitinh = kh.GioiTinhKhachHang,
                    tuoi = DateTime.Now.Year - kh.NgaySinh.Year,
                    sodienthoai = kh.SoDienThoaiKhachHang,
                    sotienconno = lsotienhopdong - lsotiendatra,
                    lsotiendatra
                };

            foreach (var kh in kq)
            {
                Console.WriteLine("ID khách hàng: {0}", kh.id);
                Console.WriteLine("\t họ tên khách hàng: {0},", kh.hoten);
                Console.WriteLine("\t giới tính khách hàng: {0},", kh.gioitinh);
                Console.WriteLine("\t tuổi khách hàng: {0},", kh.tuoi);
                Console.WriteLine("\t số điện thoại khách hàng: {0},", kh.sodienthoai);
                Console.WriteLine("\t số tiền khách hàng còn nợ: {0}", kh.sotienconno);
            }

        }

        public static void Cau6()
        {
            /*
             * 6. Nhóm các hợp đồng theo số lượng phiếu thu,
             * sắp xếp các nhóm tăng dần theo theo số lượng phiếu thu,
             * sắp xếp các hợp đồng trong nhóm tăng dần theo giá trị hợp đồng
             */

            var kq =
                from hd in DSHopDong
                let lsoluonghopdong = hd.DSPhieuThu_HopDong.Count()
                group hd by lsoluonghopdong into g
                orderby g.Key
                select new
                {
                    sophieuthu = g.Key,
                    hopdong = g
                        .OrderBy(hd => hd.GiaTriHopDong)
                        .ThenBy(hd => hd.HopDongID)
                };

            foreach (var g in kq)
            {
                Console.WriteLine("Số lượng phiếu thu: {0}, các hợp đồng: ", 
                    g.sophieuthu);
                foreach(var hd in g.hopdong)
                {
                    Console.WriteLine("\t ID hợp đồng: {0}", 
                        hd.HopDongID);
                    Console.WriteLine("\t\t tên hợp đồng: {0},", 
                        hd.TenHopDong);
                    Console.WriteLine("\t\t ngày bắt đầu hợp đồng: {0:dd-MM-yyyy},", 
                        hd.NgayBatDauHopDong);
                    Console.WriteLine("\t\t ngày kết thúc hợp đồng: {0:dd-MM-yyyy},",
                        hd.NgayKetThucHopDong);
                    Console.WriteLine("\t\t giá trị hợp đồng: {0}", 
                        hd.GiaTriHopDong);
                }
            }
        }

        public static void Cau7()
        {
            /*
             * 7. Cho biết ID, tên hợp đồng, giá trị hợp đồng,
             * của loại xe nào,
             * họ tên của chủ nhân chiếc xe,
             * sắp xếp theo giá trị hợp đồng tăng dần, loại xe, tên khách hàng
             */

            var kq =
                from hd in DSHopDong
                join xe in DSXe on hd.XeID equals xe.XeID
                join kh in DSKhachHang on xe.KhachHangID equals kh.KhachHangID
                let lhotenkhachhang = kh.HoTenKhachHang.Split(' ')
                orderby hd.GiaTriHopDong, xe.LoaiXe, lhotenkhachhang[lhotenkhachhang.Length - 1]
                select new
                {
                    idhopdong = hd.HopDongID,
                    tenhopdong = hd.TenHopDong,
                    giatrihopdong = hd.GiaTriHopDong,
                    loaixe = xe.LoaiXe,
                    hotenkhachhang = kh.HoTenKhachHang
                };

            foreach(var x in kq)
            {
                Console.WriteLine("ID hợp đồng: {0}", 
                    x.idhopdong);
                Console.WriteLine("\t tên hợp đồng: {0},", 
                    x.tenhopdong);
                Console.WriteLine("\t giá trị hợp đồng: {0},", 
                    x.giatrihopdong);
                Console.WriteLine("\t loại xe: {0},", 
                    x.loaixe);
                Console.WriteLine("\t họ tên khách hàng: {0}",
                    x.hotenkhachhang);
            }
        }

        public static void Cau8()
        {
            /*
             * 8. Lấy ra tên những người thực hiện thu tiền cho các phiếu thu,
             * biết những người thu phiếu có họ tên giống nhau thì là cùng 1 người,
             * với mỗi phiếu thu trên hợp đồng khác nhau họ được thưởng thêm tiền là 200, 
             * hãy cho biết thêm số tiền mỗi người được trả thêm
             * sắp xếp giảm dần theo số tiền thưởng
             */

            var kq =
                from pt in DSPhieuThu
                group pt by pt.HoTenNguoiThuPhieuThu into g
                let lsotienthuong = 200 * g
                        .Select(pt => pt.HopDongID)
                        .Distinct()
                        .Count()
                orderby lsotienthuong descending
                select new
                {
                    hotennguoithuphieuthu = g.Key,
                    sotienthuong = lsotienthuong
                };

            foreach(var x in kq)
            {
                Console.WriteLine("Họ tên người thu phiếu thu: {0}, " +
                    "số tiền thưởng: {1}", 
                    x.hotennguoithuphieuthu, x.sotienthuong);
            }
        }

        public static void Cau9()
        {
            /* 9. Cuối năm cửa hàng sữa chữa, nâng cấp xe muốn tri ân khách hàng,
             * ông chủ muốn lấy ra 1 khách hàng,
             * trong những khách hàng đã thanh toán xong giá tri hợp đồng sữa chữa, nâng cấp,
             * có tổng giá trị hợp đồng cao nhất trong nhóm khách hàng trên 
             * hãy cho biết ID, họ tên, giới tính, tuổi và số điện thoại của người đó 
             */

            var kq =
                (from kh in DSKhachHang
                 let ldanhsachhopdong = kh.DSXe_KhachHang.SelectMany(x => x.DSHopDong_Xe)
                 let lsotienhopdong = ldanhsachhopdong.Sum(hd => hd.GiaTriHopDong)
                 let lsotiendatra = ldanhsachhopdong
                     .SelectMany(hd => hd.DSPhieuThu_HopDong)
                     .Sum(pt => pt.SoTienThuPhieuThu)
                 where (lsotienhopdong - lsotiendatra) == 0
                 select new
                 {
                     id = kh.KhachHangID,
                     hoten = kh.HoTenKhachHang,
                     gioitinh = kh.GioiTinhKhachHang,
                     tuoi = DateTime.Now.Year - kh.NgaySinh.Year,
                     sodienthoai = kh.SoDienThoaiKhachHang
                 })
                 .FirstOrDefault();

            if (kq != null)
            {
                Console.WriteLine("Thông tin khách hàng thân thiết: ");
                Console.WriteLine("\t ID khách hàng: {0}", kq.id);
                Console.WriteLine("\t\t họ tên khách hàng: {0},", kq.hoten);
                Console.WriteLine("\t\t giới tính khách hàng: {0},", kq.gioitinh);
                Console.WriteLine("\t\t tuổi khách hàng: {0},", kq.tuoi);
                Console.WriteLine("\t\t số điện thoại khách hàng: {0}", kq.sodienthoai);
            }
            else 
                Console.WriteLine("Không có khách hàng nào thoả mãn điều kiện ");

        }

        public static void Cau10()
        {
            /* 
             * 10. Ông chủ muốn biết cửa hàng sữa chữa, nâng cấp xe 
             * của mình hiện tại đã lời hay lỗ bao nhiêu
             * từ việc thu phiếu thu từ những người đã sửa xe
             * và trả lương, thưởng 
             * cho nhân viên sửa chữa, nâng cấp và nhân viên thu phiếu thu
             * biết nhân viên thu phiếu không có lương 
             * chỉ có thưởng tiền trên những hóa đơn thu được từ những hợp đồng khác nhau là 200 
             */

            var tienthuphieuthu = DSPhieuThu.Sum(pt => pt.SoTienThuPhieuThu);
            var tienluong = DSTho.Sum(t => t.LuongTho);
            var tienthuong =
                (from pt in DSPhieuThu
                 group pt by pt.HoTenNguoiThuPhieuThu into g
                 let lsotienthuong = 200 * g
                         .Select(pt => pt.HopDongID)
                         .Distinct()
                         .Count()
                 select lsotienthuong)
                 .Sum();

            Console.WriteLine("Số tiền lời từ việc kinh doanh cửa hàng là: {0}",
                tienthuphieuthu - tienluong - tienthuong);
        }

        /*------------------------------Main--------------------------------*/

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            TaoDanhSachNhomTho();
            TaoDanhSachTho();

            TaoDanhSachNhomCongViec();
            TaoDanhSachCongViec();

            TaoDanhSachKhachHang();
            TaoDanhSachXe();
            TaoDanhSachHopDong();
            TaoDanhSachPhieuThu();

            TaoDanhSachKhaNang();
            TaoDanhSachChiTietHopDong();

            Cau1();
            Console.WriteLine();
            Console.WriteLine();
            Cau2();
            Console.WriteLine();
            Console.WriteLine();
            Cau3();
            Console.WriteLine();
            Console.WriteLine();
            Cau4();
            Console.WriteLine();
            Console.WriteLine();
            Cau5();
            Console.WriteLine();
            Console.WriteLine();
            Cau6();
            Console.WriteLine();
            Console.WriteLine();
            Cau7();
            Console.WriteLine();
            Console.WriteLine();
            Cau8();
            Console.WriteLine();
            Console.WriteLine();
            Cau9();
            Console.WriteLine();
            Console.WriteLine();
            Cau10();
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
