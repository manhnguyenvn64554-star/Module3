using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3.Bai1
{
    public class ChuyenXe
    {
        private string MaSoChuyen { get; }
        private string HoTenTaiXe { get; }
        private string SoXe { get; }
        private double DoanhThu { get; }
        public ChuyenXe(string maSoChuyen, string hoTenTaiXe, string soXe, double doanhThu)
        {
            MaSoChuyen = maSoChuyen;
            HoTenTaiXe = hoTenTaiXe;
            SoXe = soXe;
            DoanhThu = doanhThu;
        }

        public virtual void XuatThongTin()
        {
            Console.WriteLine($"Mã số chuyến: {MaSoChuyen}, Họ tên tài xế: {HoTenTaiXe}, Số xe: {SoXe}, Doanh thu: {DoanhThu}");
        }

        public double GetDoanhThu()
        {
            return DoanhThu;
        }
    }
}
