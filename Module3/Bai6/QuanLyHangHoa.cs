using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai6
{
    internal class QuanLyHangHoa
    {
        public string maHang { get; }
        public string tenHang { get; }
        private double _donGia { get; set; }
        public double donGia
        {
            get { return _donGia; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Đơn giá không được âm.");
                }
                _donGia = value;
            }
        }
        private string _soLuongTonKho { get; set; }
        public string soLuongTonKho
        {
            get { return _soLuongTonKho; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Số lượng tồn kho không được để trống.");
                }
                _soLuongTonKho = value;
            }
        }

        public QuanLyHangHoa(string maHang, string tenHang = "xxx", double donGia = 0, string soLuongTonKho = "0")
        {
            if (string.IsNullOrWhiteSpace(maHang))
            {
                throw new ArgumentException("Mã hàng không được để trống.");
            }
            this.maHang = maHang;
            this.tenHang = string.IsNullOrWhiteSpace(tenHang) ? "xxx" : tenHang;
            this.donGia = donGia;
            this.soLuongTonKho = soLuongTonKho;
        }

        public virtual string DanhGiaHangHoa()
        {
            return $"Mã hàng: {maHang}, Tên hàng: {tenHang}, Đơn giá: {donGia}, Số lượng tồn kho: {soLuongTonKho}";
        }

        public virtual double TinhTongGia()
        {
            return (donGia * (double.TryParse(soLuongTonKho, out double soLuong) ? soLuong : 0));
        }

        public static void ThemListHangHoa(List<QuanLyHangHoa> danhSachHangHoa, QuanLyHangHoa hangHoaMoi)
        {
            if (danhSachHangHoa.Any(h => h.maHang == hangHoaMoi.maHang))
            {
                throw new ArgumentException($"Mã hàng {hangHoaMoi.maHang} đã tồn tại trong danh sách.");
            }
            danhSachHangHoa.Add(hangHoaMoi);
        }

        public static List<string> LayThongTinDanhSachHangHoa(List<QuanLyHangHoa> danhSachHangHoa)
        {
            return danhSachHangHoa.Select(h => h.DanhGiaHangHoa()).ToList();
        }

        public static List<string> LayThongTinHangHoaTheoLoai<T>(List<QuanLyHangHoa> danhSachHangHoa) where T : QuanLyHangHoa
        {
            return danhSachHangHoa.OfType<T>().Select(h => h.DanhGiaHangHoa()).ToList();
        }

        public static QuanLyHangHoa TimKiemHangHoaTheoMa(List<QuanLyHangHoa> danhSachHangHoa, string maHang)
        {
            return danhSachHangHoa.FirstOrDefault(h => h.maHang == maHang);
        }

        public static List<QuanLyHangHoa> SapXepHangHoaTheoTenTangDan(List<QuanLyHangHoa> danhSachHangHoa)
        {
            return danhSachHangHoa.OrderBy(h => h.tenHang).ToList();
        }

        public static List<QuanLyHangHoa> SapXepHangHoaTheoSoLuongTonGiamDan(List<QuanLyHangHoa> danhSachHangHoa)
        {
            return danhSachHangHoa.OrderByDescending(h => int.TryParse(h.soLuongTonKho, out int soLuong) ? soLuong : 0).ToList();
        }

        public static List<string> LayThongTinHangThucPhamKhoBan(List<QuanLyHangHoa> danhSachHangHoa)
        {
            return danhSachHangHoa.OfType<ThucPham>().Where(h => h.soLuongTonKho != "0" && h.ngayHetHan <= DateTime.Now).Select(h => h.DanhGiaHangHoa()).ToList();
        }

        public static void XoaHangHoa(List<QuanLyHangHoa> danhSachHangHoa, string maHang)
        {
            var hangHoa = TimKiemHangHoaTheoMa(danhSachHangHoa, maHang);
            if (hangHoa != null)
            {
                danhSachHangHoa.Remove(hangHoa);
            }
        }

        public static void SuaThongTinDonGia(List<QuanLyHangHoa> danhSachHangHoa, string maHang, double donGiaMoi)
        {
            var hangHoa = TimKiemHangHoaTheoMa(danhSachHangHoa, maHang);
            if (hangHoa != null)
            {
                hangHoa.donGia = donGiaMoi;
            }
        }

    }
}
