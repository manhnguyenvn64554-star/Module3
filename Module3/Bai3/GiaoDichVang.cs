using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai3
{
    internal class GiaoDichVang : QuanLiGiaoDich
    {
        private string LoaiVang { get; set; }

        public GiaoDichVang(string maGiaoDich, DateTime ngayGiaoDich, double donGia, int soLuong, string loaiVang)
            : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        {
            LoaiVang = loaiVang;
        }

        public override double ThanhTien()
        {
            return base.ThanhTien();
        }
    }
}
