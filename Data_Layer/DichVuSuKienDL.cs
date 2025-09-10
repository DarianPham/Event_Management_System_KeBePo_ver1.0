using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transfer_Object;
namespace Data_Layer
{
    public class DichVuSuKienDL : DataProvider
    { 
        public void ThemDichVuSuKien(DichVuSuKien item)
        {
            string sql = "INSERT INTO DichVuSuKien(ma_su_kien, ma_dich_vu, gia) VALUES (@ma_su_kien, @ma_dich_vu, @gia)";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@ma_su_kien", item.ma_su_kien);
            cmd.Parameters.AddWithValue("@ma_dich_vu", item.ma_dich_vu);
            cmd.Parameters.AddWithValue("@gia", item.gia);

            Connect();
            cmd.ExecuteNonQuery();
            Disconnect();
        }

        public List<DichVuSuKien> LayTheoMaSuKien(string ma_su_kien)
        {
            List<DichVuSuKien> ds = new List<DichVuSuKien>();
            string sql = "SELECT ma_su_kien, ma_dich_vu, gia FROM DichVuSuKien WHERE ma_su_kien = @ma_su_kien";

            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@ma_su_kien", ma_su_kien);

            Connect();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ds.Add(new DichVuSuKien()
                {
                    ma_su_kien = reader["ma_su_kien"].ToString(),
                    ma_dich_vu = reader["ma_dich_vu"].ToString(),
                    gia = reader.GetDecimal(reader.GetOrdinal("gia"))
                });
            }
            reader.Close();
            Disconnect();
            return ds;
        }
    }
}
