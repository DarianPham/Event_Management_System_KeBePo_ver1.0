using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transfer_Object;

namespace Data_Layer
{
    public class LoginDL : DataProvider
    {
        public bool Login(TaiKhoan acc)
        {
            string sql = " SELECT COUNT(ten_dang_nhap) FROM NguoiDung WHERE ten_dang_nhap = '" + acc.Ten_dang_nhap + "' AND mat_khau = '" + acc.Mat_khau+ "' AND phan_quyen = N'" + acc.Phan_quyen + "'";
            
            try
            {

                int num = (int)MyExecuteScalar(sql, CommandType.Text);
                return (num > 0);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string GetMaKhachHangByMaNguoiDung(string maNguoiDung)
        {
            string query = $"SELECT ma_khach_hang FROM KhachHang WHERE ma_nguoi_dung = '{maNguoiDung}'";
            object result = MyExecuteScalar(query, CommandType.Text);
            return result != null ? result.ToString() : null;
        }
    }

}
