using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer_Object
{
    public class NguoiDungTO
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string PhanQuyen { get; set; }

        public NguoiDungTO(string tenDangNhap, string matKhau, string phanQuyen)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            PhanQuyen = phanQuyen;
        }
    }
}
