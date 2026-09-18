using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai2
{
    public class QuanLySach
    {
        public string MaSach { get; }
        public DateTime NgayNhap { get; }
        public double DonGia { get; }
        public int SoLuong { get; }
        public string NhaXuatBan { get; }

        public QuanLySach(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan)
        {
            MaSach = maSach;
            NgayNhap = ngayNhap;
            DonGia = donGia;
            SoLuong = soLuong;
            NhaXuatBan = nhaXuatBan;
        }

        public virtual double TinhThanhTien()
        {
            return SoLuong * DonGia;
        }
    }
}
