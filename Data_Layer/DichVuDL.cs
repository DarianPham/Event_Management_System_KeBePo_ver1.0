using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transfer_Object;


namespace Data_Layer
{
    public class DichVuDL : DataProvider
    {

        public List<DichVu> LayDichVuTheoDoiTac(string maDoiTac)
        {
            List<DichVu> danhSach = new List<DichVu>();
            try
            {
                string sql = "SELECT * FROM DichVu WHERE ma_doi_tac = @maDoiTac";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@maDoiTac", maDoiTac);
                Connect();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    DichVu dv = new DichVu
                    {
                        ma_dich_vu = reader[0].ToString(),
                        ten_dich_vu = reader[1].ToString(),
                        gia = ((decimal)reader[2]).ToString(),
                        ma_doi_tac = reader[3].ToString()
                        // các trường khác nếu có
                    };
                    danhSach.Add(dv);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
            return danhSach;
        }
        public string TaoMaDichVuMoi()
        {
            try
            {
                string sql = "SELECT MAX(ma_dich_vu) FROM DichVu WHERE ma_dich_vu LIKE 'DV%'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                Connect();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    string maMax = result.ToString(); // ví dụ: "DV09"
                    int so = int.Parse(maMax.Substring(2)); // lấy "09"
                    return $"DV{(so + 1).ToString("D2")}";
                }
                else
                {
                    return "DV51";
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }

        public void ThemDichVu(List<DichVu> danhSachDV)
        {
            {
                Connect();
                try
                {
                    // Lấy mã lớn nhất
                    string sqlMax = "SELECT MAX(ma_dich_vu) FROM DichVu WHERE ma_dich_vu LIKE 'DV%'";
                    SqlCommand cmdMax = new SqlCommand(sqlMax, cn);
                    object result = cmdMax.ExecuteScalar();
                    int so = 0;
                    if (result != null && result != DBNull.Value)
                    {
                        string maMax = result.ToString(); // ví dụ: DV12
                        so = int.Parse(maMax.Substring(2));
                    }
                    else
                    {
                        so = 50; // Nếu chưa có, bắt đầu từ DV51 như bạn mong muốn
                    }

                    foreach (var dv in danhSachDV)
                    {
                        string maDV;
                        do
                        {
                            so++;
                            maDV = $"DV{so.ToString("D2")}";
                        } while (KiemTraMaDichVuTonTai(maDV)); // đảm bảo không trùng

                        string sqlInsert = "INSERT INTO DichVu (ma_dich_vu, ten_dich_vu, gia, ma_doi_tac) VALUES (@ma, @ten, @gia, @maDT)";
                        SqlCommand cmd = new SqlCommand(sqlInsert, cn);
                        cmd.Parameters.AddWithValue("@ma", maDV);
                        cmd.Parameters.AddWithValue("@ten", dv.ten_dich_vu);
                        cmd.Parameters.AddWithValue("@gia", dv.gia);
                        cmd.Parameters.AddWithValue("@maDT", dv.ma_doi_tac);
                        cmd.ExecuteNonQuery();
                    }
                }
                finally
                {
                    Disconnect();
                }
            }           
        }
        bool KiemTraMaDichVuTonTai(string maDV)
        {
            string sql = "SELECT COUNT(*) FROM DichVu WHERE ma_dich_vu = @ma";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@ma", maDV);
            return (int)cmd.ExecuteScalar() > 0;
        }
        public void CapNhatDanhSachDichVu(List<DichVu> danhSach)
        {
            try
            {
                Connect();
                foreach (var dv in danhSach)
                {
                    string sql = @"UPDATE DichVu 
                       SET ten_dich_vu = @ten, gia = @gia 
                       WHERE ma_dich_vu = @ma";

                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@ten", dv.ten_dich_vu);
                    cmd.Parameters.AddWithValue("@gia", dv.gia);
                    cmd.Parameters.AddWithValue("@ma", dv.ma_dich_vu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi cập nhật dịch vụ: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
