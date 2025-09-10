using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transfer_Object;

namespace Data_Layer
{
    public class SuKienDL : DataProvider
    {
        public List<SuKien> LayDanhSachSuKien()
        {
            List<SuKien> ds = new List<SuKien>();
            string sql = "SELECT * FROM SuKien"; // Tùy tên bảng trong CSDL của bạn
            Connect();

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SuKien sk = new SuKien
                    {
                        ma_su_kien = reader[0].ToString(),
                        ngay_dat = reader[1] == DBNull.Value ? null : (DateTime?)reader[1],
                        ngay_bat_dau = reader[2] == DBNull.Value ? null : (DateTime?)reader[2],
                        trang_thai = reader[3].ToString(),
                        ma_khach_hang = reader[4].ToString(),
                        ma_nhan_vien = reader[5].ToString(),
                        ma_loai = reader[6].ToString()
                    };
                    ds.Add(sk);
                }
                reader.Close();
            }
            finally
            {
                Disconnect();
            }

            return ds;
        }


    }
}
