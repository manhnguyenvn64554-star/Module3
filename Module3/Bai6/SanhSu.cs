using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai6
{
    internal class SanhSu : QuanLyHangHoa
    {
        public string nhaSanXuat { get; set; }
        private DateTime _ngayNhapKho { get; set; }
        public DateTime ngayNhapKho
        {
            get { return _ngayNhapKho; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Ngày nhập kho phải trước ngày hiện tại.");
                }
                _ngayNhapKho = value;
            }
        }

        public SanhSu(string maHang, string tenHang = "xxx", double donGia = 0, string soLuongTonKho = "0", DateTime? ngayNhapKho = null, string nhaSanXuat = "xxx") : base(maHang, tenHang, donGia, soLuongTonKho)
        {
            this.nhaSanXuat = nhaSanXuat;
            this.ngayNhapKho = ngayNhapKho ?? DateTime.Now;
        }

        public override string DanhGiaHangHoa()
        {
            if (soLuongTonKho != "0" && int.TryParse(soLuongTonKho, out int soLuong) && soLuong > 50 && (DateTime.Now - ngayNhapKho).TotalDays > 10)
            {
                return $"Mã hàng: {maHang}, Tên hàng: {tenHang}, Đơn giá: {donGia}, Số lượng tồn kho: {soLuongTonKho}, Nhà sản xuất: {nhaSanXuat}, Ngày nhập kho: {ngayNhapKho.ToShortDateString()} - Bán chậm";
            }
            else
            {
                return base.DanhGiaHangHoa() + $", Nhà sản xuất: {nhaSanXuat}, Ngày nhập kho: {ngayNhapKho.ToShortDateString()} - Không đánh giá";
            }
        }

        public override double TinhTongGia()
        {
            return base.TinhTongGia() * 1.1; 
        }
    }
}
