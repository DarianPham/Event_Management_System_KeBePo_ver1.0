using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class DataProvider
    {
        protected SqlConnection cn;
        public DataProvider()
        {
            string cnStr = "Data Source=DANDK-KHOAPHAM;Initial Catalog=Event_Management_System;Integrated Security=True";
            cn = new SqlConnection(cnStr);
        }
        public void Connect()
        {
            try
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                }
            }

            catch (SqlException ex)
            {
                throw ex;
            }

        }
        public void Disconnect()
        {
            try
            {
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public SqlDataReader MyExcuteReader(string sql, CommandType type)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = type;

            try
            {
                return (cmd.ExecuteReader());

            }
            catch (SqlException ex)
            {

                throw ex;
            }

        }

        public object MyExecuteScalar(string sql, CommandType type)

        {
            object result = null;
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = type;

            Connect();
            try
            {
                result = cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
            return result;
        }

        public int MyExcuteNonQuery(string sql, CommandType type)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = type;
            try
            {
                Connect();
                return (cmd.ExecuteNonQuery());
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




    }

}
