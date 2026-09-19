using System;
using System.Collections.Generic;
using System.Text;

namespace Module3.Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<QuanLyHangHoa> danhSachHangHoa = new List<QuanLyHangHoa>();

            QuanLyHangHoa.ThemListHangHoa(
                danhSachHangHoa,
                new ThucPham(
                    "TP01",
                    "Sữa",
                    20000,
                    "10",
                    "Vinamilk",
                    new DateTime(2026, 9, 1),
                    new DateTime(2026, 9, 15)
                )
            );

            QuanLyHangHoa.ThemListHangHoa(
                danhSachHangHoa,
                new DienMay(
                    "DM01",
                    "Tivi",
                    10000000,
                    "2",
                    24,
                    150
                )
            );

            QuanLyHangHoa.ThemListHangHoa(
                danhSachHangHoa,
                new SanhSu(
                    "SS01",
                    "Chén",
                    50000,
                    "60",
                    new DateTime(2026, 9, 1),
                    "Minh Long"
                )
            );

            int luaChon;

            do
            {
                Console.Clear();

                Console.WriteLine("========== MENU QUẢN LÝ HÀNG HÓA ==========");
                Console.WriteLine("1. Hiển thị danh sách hàng hóa");
                Console.WriteLine("2. Thêm hàng hóa");
                Console.WriteLine("3. Tìm hàng hóa theo mã");
                Console.WriteLine("4. Sắp xếp theo tên tăng dần");
                Console.WriteLine("5. Sắp xếp theo số lượng tồn giảm dần");
                Console.WriteLine("6. Hiển thị thực phẩm khó bán");
                Console.WriteLine("7. Xóa hàng hóa theo mã");
                Console.WriteLine("8. Sửa đơn giá");
                Console.WriteLine("9. Hiển thị tổng giá từng hàng hóa");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("============================================");
                Console.Write("Nhập lựa chọn: ");

                if (!int.TryParse(Console.ReadLine(), out luaChon))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();

                switch (luaChon)
                {
                    case 1:
                        HienThiDanhSach(danhSachHangHoa);
                        break;

                    case 2:
                        ThemHangHoa(danhSachHangHoa);
                        break;

                    case 3:
                        TimHangHoa(danhSachHangHoa);
                        break;

                    case 4:
                        SapXepTheoTen(danhSachHangHoa);
                        break;

                    case 5:
                        SapXepTheoSoLuong(danhSachHangHoa);
                        break;

                    case 6:
                        HienThiThucPhamKhoBan(danhSachHangHoa);
                        break;

                    case 7:
                        XoaHangHoa(danhSachHangHoa);
                        break;

                    case 8:
                        SuaDonGia(danhSachHangHoa);
                        break;

                    case 9:
                        HienThiTongGia(danhSachHangHoa);
                        break;

                    case 0:
                        Console.WriteLine("Đã thoát chương trình.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

                if (luaChon != 0)
                {
                    Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                    Console.ReadKey();
                }

            } while (luaChon != 0);
        }

        // 1. Hiển thị danh sách
        static void HienThiDanhSach(List<QuanLyHangHoa> danhSach)
        {
            Console.WriteLine("========== DANH SÁCH HÀNG HÓA ==========");

            if (danhSach.Count == 0)
            {
                Console.WriteLine("Danh sách đang trống.");
                return;
            }

            foreach (QuanLyHangHoa hangHoa in danhSach)
            {
                Console.WriteLine(hangHoa.DanhGiaHangHoa());
            }
        }

        // 2. Thêm hàng hóa
        static void ThemHangHoa(List<QuanLyHangHoa> danhSach)
        {
            Console.WriteLine("========== THÊM HÀNG HÓA ==========");
            Console.WriteLine("1. Thực phẩm");
            Console.WriteLine("2. Điện máy");
            Console.WriteLine("3. Sành sứ");
            Console.Write("Chọn loại: ");

            int loai;

            if (!int.TryParse(Console.ReadLine(), out loai))
            {
                Console.WriteLine("Loại hàng không hợp lệ.");
                return;
            }

            try
            {
                Console.Write("Mã hàng: ");
                string maHang = Console.ReadLine();

                Console.Write("Tên hàng: ");
                string tenHang = Console.ReadLine();

                Console.Write("Đơn giá: ");
                double donGia = double.Parse(Console.ReadLine());

                Console.Write("Số lượng tồn kho: ");
                string soLuong = Console.ReadLine();

                QuanLyHangHoa hangHoa;

                switch (loai)
                {
                    case 1:
                        Console.Write("Nhà cung cấp: ");
                        string nhaCungCap = Console.ReadLine();

                        Console.Write("Ngày sản xuất (dd/MM/yyyy): ");
                        DateTime ngaySanXuat =
                            DateTime.ParseExact(
                                Console.ReadLine(),
                                "dd/MM/yyyy",
                                null
                            );

                        Console.Write("Ngày hết hạn (dd/MM/yyyy): ");
                        DateTime ngayHetHan =
                            DateTime.ParseExact(
                                Console.ReadLine(),
                                "dd/MM/yyyy",
                                null
                            );

                        hangHoa = new ThucPham(
                            maHang,
                            tenHang,
                            donGia,
                            soLuong,
                            nhaCungCap,
                            ngaySanXuat,
                            ngayHetHan
                        );

                        break;

                    case 2:
                        Console.Write("Thời gian bảo hành (tháng): ");
                        int baoHanh = int.Parse(Console.ReadLine());

                        Console.Write("Công suất (W): ");
                        int congSuat = int.Parse(Console.ReadLine());

                        hangHoa = new DienMay(
                            maHang,
                            tenHang,
                            donGia,
                            soLuong,
                            baoHanh,
                            congSuat
                        );

                        break;

                    case 3:
                        Console.Write("Ngày nhập kho (dd/MM/yyyy): ");
                        DateTime ngayNhapKho =
                            DateTime.ParseExact(
                                Console.ReadLine(),
                                "dd/MM/yyyy",
                                null
                            );

                        Console.Write("Nhà sản xuất: ");
                        string nhaSanXuat = Console.ReadLine();

                        hangHoa = new SanhSu(
                            maHang,
                            tenHang,
                            donGia,
                            soLuong,
                            ngayNhapKho,
                            nhaSanXuat
                        );

                        break;

                    default:
                        Console.WriteLine("Loại hàng không hợp lệ.");
                        return;
                }

                QuanLyHangHoa.ThemListHangHoa(danhSach, hangHoa);

                Console.WriteLine("Thêm hàng hóa thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }

        // 3. Tìm theo mã
        static void TimHangHoa(List<QuanLyHangHoa> danhSach)
        {
            Console.WriteLine("========== TÌM HÀNG HÓA ==========");

            Console.Write("Nhập mã hàng cần tìm: ");
            string maHang = Console.ReadLine();

            QuanLyHangHoa hangHoa =
                QuanLyHangHoa.TimKiemHangHoaTheoMa(danhSach, maHang);

            if (hangHoa == null)
            {
                Console.WriteLine("Không tìm thấy hàng hóa.");
            }
            else
            {
                Console.WriteLine("Tìm thấy:");
                Console.WriteLine(hangHoa.DanhGiaHangHoa());
            }
        }

        // 4. Sắp xếp theo tên
        static void SapXepTheoTen(List<QuanLyHangHoa> danhSach)
        {
            List<QuanLyHangHoa> ketQua =
                QuanLyHangHoa.SapXepHangHoaTheoTenTangDan(danhSach);

            Console.WriteLine("========== SẮP XẾP THEO TÊN ==========");

            foreach (QuanLyHangHoa hangHoa in ketQua)
            {
                Console.WriteLine(hangHoa.DanhGiaHangHoa());
            }
        }

        // 5. Sắp xếp theo số lượng
        static void SapXepTheoSoLuong(List<QuanLyHangHoa> danhSach)
        {
            List<QuanLyHangHoa> ketQua =
                QuanLyHangHoa.SapXepHangHoaTheoSoLuongTonGiamDan(danhSach);

            Console.WriteLine("========== SẮP XẾP SỐ LƯỢNG ==========");

            foreach (QuanLyHangHoa hangHoa in ketQua)
            {
                Console.WriteLine(hangHoa.DanhGiaHangHoa());
            }
        }

        // 6. Thực phẩm khó bán
        static void HienThiThucPhamKhoBan(List<QuanLyHangHoa> danhSach)
        {
            List<string> ketQua =
                QuanLyHangHoa.LayThongTinHangThucPhamKhoBan(danhSach);

            Console.WriteLine("========== THỰC PHẨM KHÓ BÁN ==========");

            if (ketQua.Count == 0)
            {
                Console.WriteLine("Không có thực phẩm khó bán.");
                return;
            }

            foreach (string item in ketQua)
            {
                Console.WriteLine(item);
            }
        }

        // 7. Xóa
        static void XoaHangHoa(List<QuanLyHangHoa> danhSach)
        {
            Console.WriteLine("========== XÓA HÀNG HÓA ==========");

            Console.Write("Nhập mã hàng cần xóa: ");
            string maHang = Console.ReadLine();

            QuanLyHangHoa hangHoa =
                QuanLyHangHoa.TimKiemHangHoaTheoMa(danhSach, maHang);

            if (hangHoa == null)
            {
                Console.WriteLine("Không tìm thấy hàng hóa.");
                return;
            }

            QuanLyHangHoa.XoaHangHoa(danhSach, maHang);

            Console.WriteLine("Xóa hàng hóa thành công!");
        }

        // 8. Sửa đơn giá
        static void SuaDonGia(List<QuanLyHangHoa> danhSach)
        {
            Console.WriteLine("========== SỬA ĐƠN GIÁ ==========");

            Console.Write("Nhập mã hàng: ");
            string maHang = Console.ReadLine();

            QuanLyHangHoa hangHoa =
                QuanLyHangHoa.TimKiemHangHoaTheoMa(danhSach, maHang);

            if (hangHoa == null)
            {
                Console.WriteLine("Không tìm thấy hàng hóa.");
                return;
            }

            Console.WriteLine("Thông tin hiện tại:");
            Console.WriteLine(hangHoa.DanhGiaHangHoa());

            Console.Write("Nhập đơn giá mới: ");

            if (!double.TryParse(Console.ReadLine(), out double donGiaMoi))
            {
                Console.WriteLine("Đơn giá không hợp lệ.");
                return;
            }

            try
            {
                QuanLyHangHoa.SuaThongTinDonGia(
                    danhSach,
                    maHang,
                    donGiaMoi
                );

                Console.WriteLine("Sửa đơn giá thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }

        // 9. Tính tổng giá
        static void HienThiTongGia(List<QuanLyHangHoa> danhSach)
        {
            Console.WriteLine("========== TỔNG GIÁ HÀNG HÓA ==========");

            foreach (QuanLyHangHoa hangHoa in danhSach)
            {
                Console.WriteLine(
                    $"Mã: {hangHoa.maHang} | " +
                    $"Tên: {hangHoa.tenHang} | " +
                    $"Tổng giá: {hangHoa.TinhTongGia():N0}"
                );
            }
        }
    }
}