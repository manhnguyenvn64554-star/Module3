using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<QuanLySach> danhSachSach = new List<QuanLySach>
            {
                new SGK("SGK001", new DateTime(2023, 1, 1), 100000, 10, "NXB A", "mới"),
                new SGK("SGK002", new DateTime(2023, 2, 1), 120000, 5, "NXB B", "cũ"),
                new SGK("SGK003", new DateTime(2023, 3, 1), 150000, 8, "NXB K", "mới"),
                new SKT("SKT001", new DateTime(2023, 1, 15), 200000, 7, "NXB C", 50000),
                new SKT("SKT002", new DateTime(2023, 2, 20), 250000, 4, "NXB D", 60000),
                new SKT("SKT003", new DateTime(2023, 3, 25), 300000, 6, "NXB E", 70000)
            };

            //Menu bài 4
            Console.WriteLine("Chọn chức năng: \n 1. Hiển thị danh sách sách\n 2. Tính tổng thành tiền của tất cả sách\n 3. Tính trung bình thành tiền của sách giáo khoa\n 4. Hiển thị danh sách sách xuất bản bởi NXB");

            int choice = int.Parse(Console.ReadLine());
            switch(choice)             {
                case 1:
                    Console.WriteLine("Danh sách sách:");
                    foreach (var sach in danhSachSach)
                    {
                        Console.WriteLine($"Mã sách: {sach.MaSach}, Ngày nhập: {sach.NgayNhap.ToShortDateString()}, Đơn giá: {sach.DonGia}, Số lượng: {sach.SoLuong}, Nhà xuất bản: {sach.NhaXuatBan}, Thành tiền: {sach.TinhThanhTien()}");
                    }
                    break;
                case 2:
                    double tongThanhTien = danhSachSach.Sum(s => s.TinhThanhTien());
                    Console.WriteLine($"Tổng thành tiền của tất cả sách: {tongThanhTien}");
                    break;
                case 3:
                    var sgkList = danhSachSach.OfType<SGK>().ToList();
                    if (sgkList.Count > 0)
                    {
                        double trungBinhThanhTien = sgkList.Average(s => s.TinhThanhTien());
                        Console.WriteLine($"Trung bình thành tiền của sách giáo khoa: {trungBinhThanhTien}");
                    }
                    else
                    {
                        Console.WriteLine("Không có sách giáo khoa trong danh sách.");
                    }
                    break;
                case 4:
                    Console.WriteLine("Nhập tên nhà xuất bản:");
                    string nxb = Console.ReadLine();
                    var sachTheoNXB = danhSachSach.Where(s => s.NhaXuatBan.Equals(nxb, StringComparison.OrdinalIgnoreCase)).ToList();
                    if (sachTheoNXB.Count > 0)
                    {
                        Console.WriteLine($"Danh sách sách xuất bản bởi {nxb}:");
                        foreach (var sach in sachTheoNXB)
                        {
                            Console.WriteLine($"Mã sách: {sach.MaSach}, Ngày nhập: {sach.NgayNhap.ToShortDateString()}, Đơn giá: {sach.DonGia}, Số lượng: {sach.SoLuong}, Thành tiền: {sach.TinhThanhTien()}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Không có sách nào xuất bản bởi {nxb}.");
                    }
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}
