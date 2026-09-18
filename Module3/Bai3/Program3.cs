using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module3.Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<QuanLiGiaoDich> danhSachGiaoDich = new List<QuanLiGiaoDich>
            {
                new GiaoDichVang("GDV001", new DateTime(2024, 1, 15), 50000000, 2, "99.99%"),
                new GiaoDichVang("GDV002", new DateTime(2024, 2, 10), 60000000, 1, "99.99%"),
                new GiaoDichVang("GDV003", new DateTime(2024, 3, 5), 70000000, 3, "99.99%"),
                new GiaoDichTienTe("GDT001", new DateTime(2024, 1, 20), 1500000000, 5, "USD"),
                new GiaoDichTienTe("GDT002", new DateTime(2024, 2, 15), 2000000000, 3, "EUR"),
                new GiaoDichTienTe("GDT003", new DateTime(2024, 3, 12), 2500000000, 2, "VND")
            };

            int TongSoLuongVang = danhSachGiaoDich.OfType<GiaoDichVang>().Sum(gd => gd.soLuong);
            int TongSoLuongTienTe = danhSachGiaoDich.OfType<GiaoDichTienTe>().Sum(gd => gd.soLuong);
            Console.WriteLine("Tổng số lượng giao dịch vàng: " + TongSoLuongVang);
            Console.WriteLine("Tổng số lượng giao dịch tiền tệ: " + TongSoLuongTienTe);
            Console.WriteLine("Cacs giao dịch có đơn giá > 1 tỷ:");
            foreach (var gd in danhSachGiaoDich.Where(gd => gd.donGia > 1000000000))
            {
                Console.WriteLine($"Mã giao dịch: {gd.maGiaoDich}, Ngày giao dịch: {gd.ngayGiaoDich.ToShortDateString()}, Đơn giá: {gd.donGia}, Số lượng: {gd.soLuong}, Thành tiền: {gd.ThanhTien()}");
            }
        }
    }
}
