using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai1
{
    public class XeNoiThanh : ChuyenXe 
    {
        private int soTuyen;
        private int soNgayDi;

        public XeNoiThanh(string maSoChuyen, string hoTenTaiXe, string soXe, int soTuyen, int soNgayDi, double doanhThu) : base(maSoChuyen, hoTenTaiXe, soXe, doanhThu)
        {
            this.soTuyen = soTuyen;
            this.soNgayDi = soNgayDi;
        }

        public override void XuatThongTin() 
        {
            Console.WriteLine("Chuyến xe nội thành:");
            base.XuatThongTin();
            Console.WriteLine($"Số tuyến: {soTuyen}, Số ngày đi: {soNgayDi}");
        }
    }
}
