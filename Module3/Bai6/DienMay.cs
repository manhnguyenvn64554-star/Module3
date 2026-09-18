using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai6
{
    internal class DienMay : QuanLyHangHoa
    {
        private int _thoiGianBaoHanh { get; set; }
        public int thoiGianBaoHanh
        {
            get { return _thoiGianBaoHanh; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Thời gian bảo hành không được âm.");
                }
                _thoiGianBaoHanh = value;
            }
        }
        private int _congSuat { get; set; }
        public int congSuat
        {
            get { return _congSuat; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Công suất không được âm.");
                }
                _congSuat = value;
            }
        }

        public DienMay(string maHang, string tenHang = "xxx", double donGia = 0, string soLuongTonKho = "0", int thoiGianBaoHanh = 0, int congSuat = 0) : base(maHang, tenHang, donGia, soLuongTonKho)
        {
            this.thoiGianBaoHanh = thoiGianBaoHanh;
            this.congSuat = congSuat;
        }

        public override string DanhGiaHangHoa()
        {
            if (soLuongTonKho != "0" && int.TryParse(soLuongTonKho, out int soLuong) && soLuong < 3)
            {
                return $"Mã hàng: {maHang}, Tên hàng: {tenHang}, Đơn giá: {donGia}, Số lượng tồn kho: {soLuongTonKho}, Thời gian bảo hành: {thoiGianBaoHanh} tháng, Công suất: {congSuat} W - Bán được";
            }
            else
            {
                return base.DanhGiaHangHoa() + $", Thời gian bảo hành: {thoiGianBaoHanh} tháng, Công suất: {congSuat} W - Không đánh giá";
            }
        }

        public override double TinhTongGia()
        {
            return base.TinhTongGia() * 1.1;
        }
    }
}
