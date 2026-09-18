using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai2
{
    public class SGK : QuanLySach
    {
        private string TinhTrang { get; }

        public SGK(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, string tinhTrang) : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            TinhTrang = tinhTrang;
        }

        public override double TinhThanhTien()
        {
            if (TinhTrang.ToLower() == "mới")
            {
                return base.TinhThanhTien();
            }
            else if (TinhTrang.ToLower() == "cũ")
            {
                return base.TinhThanhTien() * 0.5;
            }
            else
            {
                throw new ArgumentException("Tình trạng sách không hợp lệ. Vui lòng nhập 'mới' hoặc 'cũ'.");
            }
        }
    }
}
