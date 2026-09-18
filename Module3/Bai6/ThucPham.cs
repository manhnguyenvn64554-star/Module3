using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module3.Bai6
{
    internal class ThucPham : QuanLyHangHoa
    {
        public string nhaCungCap { get; set; }
        private DateTime _ngaySanXuat;
        public DateTime ngaySanXuat
        {
            get { return _ngaySanXuat; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Ngày sản xuất phải trước ngày hiện tại.");
                }
                _ngaySanXuat = value;
            }
        }
        private DateTime _ngayHetHan;
        public DateTime ngayHetHan
        {
            get { return _ngayHetHan; }
            set
            {
                if (value <= ngaySanXuat)
                {
                    throw new ArgumentException("Ngày hết hạn phải sau ngày sản xuất.");
                }
                _ngayHetHan = value;
            }
        }

        public ThucPham(string maHang, string tenHang = "xxx", double donGia = 0, string soLuongTonKho = "0",
        string nhaCungCap = "", DateTime? ngaySanXuat = null, DateTime? ngayHetHan = null) : base(maHang, tenHang, donGia, soLuongTonKho)
        {
            this.nhaCungCap = nhaCungCap;
            this.ngaySanXuat = ngaySanXuat ?? DateTime.Now;
            this.ngayHetHan = ngayHetHan ?? this.ngaySanXuat.AddDays(1);
        }

        public override string DanhGiaHangHoa()
        {
            if (soLuongTonKho != "0" && ngayHetHan <= DateTime.Now)
            {
                return $"Mã hàng: {maHang}, Tên hàng: {tenHang}, Đơn giá: {donGia}, Số lượng tồn kho: {soLuongTonKho}, Nhà cung cấp: {nhaCungCap}, Ngày sản xuất: {ngaySanXuat.ToShortDateString()}, Ngày hết hạn: {ngayHetHan.ToShortDateString()} - Khó bán";
            }
            else
            {
                return base.DanhGiaHangHoa() + $", Nhà cung cấp: {nhaCungCap}, Ngày sản xuất: {ngaySanXuat.ToShortDateString()}, Ngày hết hạn: {ngayHetHan.ToShortDateString()} - Không đánh giá";
            }
        }

        public override double TinhTongGia()
        {
            return base.TinhTongGia() * 1.05;
        }
    }
}
