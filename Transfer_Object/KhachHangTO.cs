using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer_Object
{
    public class KhachHangTO
    {
        public string TenDangNhap { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }

        public KhachHangTO(string tenDangNhap, string hoTen, string diaChi, string soDienThoai, string email)
        {
            TenDangNhap = tenDangNhap;
            HoTen = hoTen;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            Email = email;
        }
    }
}
