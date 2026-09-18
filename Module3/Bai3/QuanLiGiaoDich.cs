using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai3
{
    internal class QuanLiGiaoDich
    {
        public string maGiaoDich { get; set; }
        public DateTime ngayGiaoDich { get; set; }
        public double donGia { get; set; }
        public int soLuong { get; set; }

        public QuanLiGiaoDich(string maGiaoDich, DateTime ngayGiaoDich, double donGia, int soLuong)
        {
            this.maGiaoDich = maGiaoDich;
            this.ngayGiaoDich = ngayGiaoDich;
            this.donGia = donGia;
            this.soLuong = soLuong;
        }

        public virtual double ThanhTien()
        {
            return donGia * soLuong;
        } 
    }
}
