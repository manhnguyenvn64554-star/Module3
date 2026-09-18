using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<ChuyenXe> danhSachChuyenXe = new List<ChuyenXe>();
            
            XeNoiThanh xeNoiThanh1 = new XeNoiThanh("NT001", "Nguyen Van A", "29A-12345", 5, 10, 1000000);
            XeNoiThanh xeNoiThanh2 = new XeNoiThanh("NT002", "Tran Thi B", "29A-67890", 3, 8, 800000);
            
            XeNgoaiThanh xeNgoaiThanh1 = new XeNgoaiThanh("XT001", "Le Van C", "29B-54321", "Da Lat", 3, 1500000);
            XeNgoaiThanh xeNgoaiThanh2 = new XeNgoaiThanh("XT002", "Pham Thi D", "29B-98765", "Nha Trang", 4, 2000000);
            
            danhSachChuyenXe.Add(xeNoiThanh1);
            danhSachChuyenXe.Add(xeNoiThanh2);
            danhSachChuyenXe.Add(xeNgoaiThanh1);
            danhSachChuyenXe.Add(xeNgoaiThanh2);
            
            double tongDoanhThu = 0;
            double tongDoanhThuNoiThanh = 0;
            double tongDoanhThuNgoaiThanh = 0;
            foreach (var chuyenXe in danhSachChuyenXe)
            {
                chuyenXe.XuatThongTin();
                tongDoanhThu += chuyenXe.GetDoanhThu();
                if (chuyenXe is XeNoiThanh)
                {
                    tongDoanhThuNoiThanh += chuyenXe.GetDoanhThu();
                }
                else if (chuyenXe is XeNgoaiThanh)
                {
                    tongDoanhThuNgoaiThanh += chuyenXe.GetDoanhThu();
                }
            }
            Console.WriteLine($"Tổng doanh thu tất cả các chuyến xe: {tongDoanhThu}");
            Console.WriteLine($"Tổng doanh thu chuyến xe nội thành: {tongDoanhThuNoiThanh}");
            Console.WriteLine($"Tổng doanh thu chuyến xe ngoại thành: {tongDoanhThuNgoaiThanh}");
        }
    }
}
