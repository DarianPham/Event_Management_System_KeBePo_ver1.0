using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer_Object
{
    public class TaiKhoan
    {
        public string Ten_dang_nhap { get; set; }
        public string Mat_khau { get; set; }
        public string Phan_quyen {  get; set; }

        // Constructor
        public TaiKhoan(string username, string password, string phan_quyen)
        {
            Ten_dang_nhap = username;
            Mat_khau = password;
            Phan_quyen = phan_quyen;
        }
    }
}
