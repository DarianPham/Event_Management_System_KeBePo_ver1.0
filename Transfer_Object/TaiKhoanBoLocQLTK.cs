using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer_Object
{
    public class TaiKhoanBoLocQLTK
    {
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }

        public TaiKhoanBoLocQLTK(string hoTen, string email, string soDienThoai, string diaChi)
        {
            HoTen = hoTen;
            Email = email;
            SoDienThoai = soDienThoai;
            DiaChi = diaChi;
        }
    }
}
