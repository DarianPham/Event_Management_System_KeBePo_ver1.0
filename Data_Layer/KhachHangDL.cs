using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transfer_Object;

namespace Data_Layer
{
    public class KhachHangDL : DataProvider
    {
       

        public bool ThemKhachHang(KhachHangTO kh)
        {
            string query = "INSERT INTO KhachHang (ten_dang_nhap, ho_ten, dia_chi, email, so_dien_thoai) " +
                           "VALUES (@tenDangNhap, @hoTen, @diaChi, @email, @soDienThoai)";

            var prms = new Dictionary<string, object>
        {
            { "@tenDangNhap", kh.TenDangNhap },
            { "@hoTen", kh.HoTen },
            { "@diaChi", kh.DiaChi },
            { "@email", kh.Email },
            { "@soDienThoai", kh.SoDienThoai }
        };
            return MyExcuteNonQuery(query, CommandType.Text) > 0;
        }

        public string GetMaKhachHangByMaNguoiDung(string maNguoiDung)
        {
            string query = $"SELECT ma_khach_hang FROM KhachHang WHERE ma_nguoi_dung = '{maNguoiDung}'";
            object result = MyExecuteScalar(query, CommandType.Text);
            return result != null ? result.ToString() : null;
        }



    }
}
