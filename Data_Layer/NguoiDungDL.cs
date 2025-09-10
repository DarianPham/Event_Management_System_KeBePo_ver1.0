using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transfer_Object;

namespace Data_Layer
{
    public class NguoiDungDL : DataProvider
    {

        public bool ThemNguoiDung(NguoiDungTO nd)
        {
            string query = "INSERT INTO NguoiDung (ten_dang_nhap, mat_khau, phan_quyen) " +
                           "VALUES (@tenDangNhap, @matKhau, @phanQuyen)";
            var prms = new Dictionary<string, object>
        {
            { "@tenDangNhap", nd.TenDangNhap },
            { "@matKhau", nd.MatKhau },
            { "@phanQuyen", nd.PhanQuyen }
        };
            return MyExcuteNonQuery(query, CommandType.Text) > 0;
        }
    }
}
