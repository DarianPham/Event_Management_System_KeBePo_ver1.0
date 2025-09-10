using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transfer_Object
{
    public class NhanVienTO
    {
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public string SoDienThoai { get; set; }

        public NhanVienTO(string hoTen, string chucVu, string soDienThoai)
        {
            HoTen = hoTen;
            ChucVu = chucVu;
            SoDienThoai = soDienThoai;
        }
    }
}
