using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer_Object
{
    public class AdminTO
    {
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }

        public AdminTO(string hoTen, string email, string soDienThoai)
        {
            HoTen = hoTen;
            Email = email;
            SoDienThoai = soDienThoai;
        }
    }
}
