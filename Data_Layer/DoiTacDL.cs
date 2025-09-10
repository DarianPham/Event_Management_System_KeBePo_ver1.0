using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transfer_Object;
using System.Data;
using System.Linq.Expressions;
using Krypton.Toolkit;

namespace Data_Layer
{
    public class DoiTacDL : DataProvider
    {
        public List<DoiTac> GetDoiTacs()
        {
            List<DoiTac> doiTacs = new List<DoiTac>();
            string sql = "SELECT * FROM DoiTac";
            string ma_doi_tac, ten_doi_tac, email, so_dien_thoai, dia_chi, loai_hinh;
            try
            {
                Connect();
                SqlDataReader reader = MyExcuteReader(sql, CommandType.Text);
                while (reader.Read())
                {

                    ma_doi_tac = reader[0].ToString();
                    ten_doi_tac = reader[1].ToString();
                    email = reader[2].ToString();
                    so_dien_thoai = reader[3].ToString();
                    dia_chi = reader[4].ToString();
                    loai_hinh = reader[5].ToString();

                    DoiTac doiTac = new DoiTac(ma_doi_tac, ten_doi_tac, email, so_dien_thoai, dia_chi, loai_hinh);
                    doiTacs.Add(doiTac);
                }
                reader.Close();
                return doiTacs;
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

        public List<DoiTac> TimKiemVaLoc(string keyword, string loaiHinh)
        {
            List<DoiTac> doiTacs = new List<DoiTac>();
            string sql = "SELECT * FROM DoiTac WHERE ten_doi_tac LIKE @keyword";
            string ma_doi_tac, ten_doi_tac, email, so_dien_thoai, dia_chi, loai_hinh;
            try
            {
                Connect();
                if (!string.IsNullOrEmpty(loaiHinh) && loaiHinh != "Tất cả")
                {
                    sql += " AND loai_hinh = @loaiHinh";
                }

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                if (!string.IsNullOrEmpty(loaiHinh) && loaiHinh != "Tất cả")
                {
                    cmd.Parameters.AddWithValue("@loaiHinh", loaiHinh);
                }

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    ma_doi_tac = reader[0].ToString();
                    ten_doi_tac = reader[1].ToString();
                    email = reader[2].ToString();
                    so_dien_thoai = reader[3].ToString();
                    dia_chi = reader[4].ToString();
                    loai_hinh = reader[5].ToString();

                    DoiTac doiTac = new DoiTac(ma_doi_tac, ten_doi_tac, email, so_dien_thoai, dia_chi, loai_hinh);
                    doiTacs.Add(doiTac);
                }
                return doiTacs;
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
        public List<DoiTac> LayThongTinDoiTac(string maDoiTac)
        {
            List<DoiTac> doiTacs = new List<DoiTac>();
            string ma_doi_tac, ten_doi_tac, email, so_dien_thoai, dia_chi, loai_hinh;
            try
            {
                string sql = "SELECT * FROM DoiTac WHERE ma_doi_tac = @ma";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@ma", maDoiTac);
                Connect();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    ma_doi_tac = reader[0].ToString();
                    ten_doi_tac = reader[1].ToString();
                    email = reader[2].ToString();
                    so_dien_thoai = reader[3].ToString();
                    dia_chi = reader[4].ToString();
                    loai_hinh = reader[5].ToString();

                    DoiTac doiTac = new DoiTac(ma_doi_tac, ten_doi_tac, email, so_dien_thoai, dia_chi, loai_hinh);
                    doiTacs.Add(doiTac);
                }
                return doiTacs;
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
        public List<DoiTac> LayTatCaDoiTac()
        {
            List<DoiTac> danhSach = new List<DoiTac>();
            try
            {
                string sql = "SELECT * FROM DoiTac"; // thay tên bảng nếu khác
                SqlCommand cmd = new SqlCommand(sql, cn);
                Connect();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DoiTac dt = new DoiTac
                    {
                        ma_doi_tac = reader[0].ToString(),
                        ten_doi_tac = reader[1].ToString(),
                        email = reader[2].ToString(),
                        so_dien_thoai = reader[3].ToString(),
                        dia_chi = reader[4].ToString(),
                        loai_hinh = reader[5].ToString() // nếu có cột
                    };
                    danhSach.Add(dt);
                }
            }
            catch(SqlException ex){
                throw ex;
            }
            finally {

                Disconnect() ;  
            }

            return danhSach;
        }
        public List<DoiTac> LayDoiTacTheoLoaiHinh(string loaiHinh)
        {
            List<DoiTac> danhSach = new List<DoiTac>();
            string sql = "SELECT * FROM DoiTac WHERE loai_hinh = @loaiHinh";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@loaiHinh", loaiHinh);
            try
            {
                Connect();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DoiTac dt = new DoiTac(
                        reader["ma_doi_tac"].ToString(),
                        reader["ten_doi_tac"].ToString(),
                        reader["email"].ToString(),
                        reader["so_dien_thoai"].ToString(),
                        reader["dia_chi"].ToString(),
                        reader["loai_hinh"].ToString()
                    );
                    danhSach.Add(dt);
                }
            }
            finally
            {
                Disconnect();
            }
            return danhSach;
        }
        public List<string> LayDanhSachLoaiHinh()
        {
            List<string> danhSach = new List<string>();
            try
            {
                string sql = "SELECT DISTINCT loai_hinh FROM DoiTac"; 
                SqlCommand cmd = new SqlCommand(sql, cn);
                Connect();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    danhSach.Add(reader["loai_hinh"].ToString());
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
            return danhSach;
        }
        public string TaoMaDoiTacMoi(SqlConnection cn, SqlTransaction tran)
        {
            string sql = @"
            SELECT TOP 1 ma_doi_tac 
            FROM DoiTac 
            WHERE ISNUMERIC(SUBSTRING(ma_doi_tac, 3, LEN(ma_doi_tac)-2)) = 1
            ORDER BY CAST(SUBSTRING(ma_doi_tac, 3, LEN(ma_doi_tac)-2) AS INT) DESC";

            SqlCommand cmd = new SqlCommand(sql, cn, tran);
            object result = cmd.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                string lastID = result.ToString(); // Ví dụ: DT010
                int number = int.Parse(lastID.Substring(2)); // Lấy số
                return "DT" + (number + 1).ToString("D2");   // DT011
            }
            else
            {
                return "DT011"; // Khởi tạo ban đầu
            }
        }       

        public string ThemDoiTac(DoiTac dt)
        {
            Connect();
            SqlTransaction tran = cn.BeginTransaction();

            try
            {
                // 1. Sinh mã đối tác mới
                string maDT = TaoMaDoiTacMoi(cn, tran);
                dt.ma_doi_tac = maDT; // cập nhật lại cho danh sách dịch vụ dùng

                // 2. Thêm đối tác vào bảng DoiTac
                string queryDT = "INSERT INTO DoiTac (ma_doi_tac, ten_doi_tac, so_dien_thoai, email, dia_chi, loai_hinh) " +
                                 "VALUES (@MaDT, @Ten, @SDT, @Email, @DiaChi, @LoaiHinh)";
                SqlCommand cmdDT = new SqlCommand(queryDT, cn, tran);
                cmdDT.Parameters.AddWithValue("@MaDT", maDT);
                cmdDT.Parameters.AddWithValue("@Ten", dt.ten_doi_tac);
                cmdDT.Parameters.AddWithValue("@SDT", dt.so_dien_thoai);
                cmdDT.Parameters.AddWithValue("@Email", dt.email);
                cmdDT.Parameters.AddWithValue("@DiaChi", dt.dia_chi);
                cmdDT.Parameters.AddWithValue("@LoaiHinh", dt.loai_hinh);
                cmdDT.ExecuteNonQuery();
                tran.Commit();
                return maDT;
            }
            catch(SqlException ex) 
            {
                tran.Rollback();
                throw ex;
            }
            finally
            {
                Disconnect();
            }

        }
        public void Delete(string maDoiTac)
        {
            try
            {
                Connect();

                // Xóa tất cả dịch vụ có mã đối tác
                string sqlDeleteDV = "DELETE FROM DichVu WHERE ma_doi_tac = @maDoiTac";
                SqlCommand cmdDV = new SqlCommand(sqlDeleteDV, cn);
                cmdDV.Parameters.AddWithValue("@maDoiTac", maDoiTac);
                cmdDV.ExecuteNonQuery();

                // Xóa đối tác
                string sqlDeleteDT = "DELETE FROM DoiTac WHERE ma_doi_tac = @maDoiTac";
                SqlCommand cmdDT = new SqlCommand(sqlDeleteDT, cn);
                cmdDT.Parameters.AddWithValue("@maDoiTac", maDoiTac);
                cmdDT.ExecuteNonQuery();
            }
            finally
            {
                Disconnect();
            }
        }
        public void CapNhatDoiTac(DoiTac dt)
        {
            try
            {
                string sql = @"UPDATE DoiTac
                SET ten_doi_tac = @ten, email = @mail, so_dien_thoai = @sdt, dia_chi = @diachi, loai_hinh = @loaihinh
                WHERE ma_doi_tac = @ma";
                    SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@ten", dt.ten_doi_tac);
                cmd.Parameters.AddWithValue("@mail", dt.email);
                cmd.Parameters.AddWithValue("@sdt", dt.so_dien_thoai);
                cmd.Parameters.AddWithValue("@diachi", dt.dia_chi);
                cmd.Parameters.AddWithValue("@loaihinh", dt.loai_hinh);
                cmd.Parameters.AddWithValue("@ma", dt.ma_doi_tac);

                Connect();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi cập nhật đối tác: " + ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }


    }
}



    
