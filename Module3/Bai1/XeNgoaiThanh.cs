using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai1
{
    public class XeNgoaiThanh : ChuyenXe 
    {
        private string noiDen;
        private int soNgayDi;

        public XeNgoaiThanh(string maSoChuyen, string hoTenTaiXe, string soXe, string noiDen, int soNgayDi, double doanhThu) : base(maSoChuyen, hoTenTaiXe, soXe, doanhThu) 
        {
            this.noiDen = noiDen;
            this.soNgayDi = soNgayDi;
        }

        public override void XuatThongTin() 
        {
            Console.WriteLine("Chuyến xe ngoại thành:");
            base.XuatThongTin();
            Console.WriteLine($"Nơi đến: {noiDen}, Số ngày đi: {soNgayDi}");
        }
    }
}
