using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai2
{
    public class SKT : QuanLySach
    {
        private double Thue { get; }

        public SKT(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, double thue) : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            Thue = thue;
        }

        public override double TinhThanhTien()
        {
            return base.TinhThanhTien() + Thue;
        }
    }
}
