using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai3
{
    internal class GiaoDichTienTe : QuanLiGiaoDich
    {
        private string LoaiTienTe { get; set; }
        private int ti = 23000; 

        public GiaoDichTienTe(string maGiaoDich, DateTime ngayGiaoDich, double donGia, int soLuong, string loaiTienTe)
            : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        {
            LoaiTienTe = loaiTienTe;
        }

        public override double ThanhTien()
        {
            if (LoaiTienTe == "USD" || LoaiTienTe == "EUR")
            {
                return base.ThanhTien() * ti; 
            }
            return base.ThanhTien();
        }
    }
}
