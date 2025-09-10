using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transfer_Object;

namespace Data_Layer
{
    
    public class QLTK_DL : DataProvider
    {

        public List<string> LayTenTuBoLoc(string accountType)
        {
            List<string> Danhsach = new List<string>();

            {
                Connect();
                string query = " ";

                if (accountType == "Nhân viên")
                    query = "SELECT ho_ten FROM NhanVien";
                else if (accountType == "Khách hàng")
                    query = "SELECT ho_ten FROM KhachHang";
                else if (accountType == "Admin")
                    query = "SELECT ho_ten FROM Admin";

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Danhsach.Add(reader["ho_ten"].ToString());

                }
            }
            return Danhsach;
        }
        public TaiKhoanBoLocQLTK LayThongTinTaiKhoanTheoTen(string hoTen, string loaiTaiKhoan)
        {
            TaiKhoanBoLocQLTK taiKhoan = null;

            {
                Connect();

                string query;
                if (loaiTaiKhoan == "Khách hàng")
                {
                    query = "SELECT ho_ten, email, so_dien_thoai, dia_chi FROM KhachHang WHERE ho_ten = @hoTen";
                }
                else if (loaiTaiKhoan == "Nhân viên")
                {
                    query = "SELECT ho_ten, dia_chi FROM NhanVien WHERE ho_ten = @hoTen";
                }
                else // Mặc định nếu là Admin
                {
                    query = "SELECT ho_ten, email, so_dien_thoai FROM Admin WHERE ho_ten = @hoTen";
                }

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@hoTen", hoTen);


                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    taiKhoan = new TaiKhoanBoLocQLTK
                        (
                        reader["ho_ten"]?.ToString() ?? "Không có dữ liệu",
                        loaiTaiKhoan == "Nhân viên" ? "Không có dữ liệu" : reader["email"]?.ToString() ?? "Không có dữ liệu",
                        loaiTaiKhoan == "Nhân viên" ? "Không có dữ liệu" : reader["so_dien_thoai"]?.ToString() ?? "Không có dữ liệu",
                        loaiTaiKhoan == "Admin" ? "Không có dữ liệu" : reader["dia_chi"]?.ToString() ?? "Không có dữ liệu"
                        );
                }
                reader.Close();
                return taiKhoan;


            }
        }


    }
}
