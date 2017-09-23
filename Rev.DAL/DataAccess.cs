using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Rev.DAL
{
    public class DataAccess
    {
        public SqlConnection connection = new SqlConnection("CONNECTION STRING");

        public SqlConnection Connect()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public int DMLQuery(SqlCommand cmd)
        {
            cmd.Connection = Connect();
            int rowsaffected = -1;
            rowsaffected = cmd.ExecuteNonQuery();
            connection.Close();
            return rowsaffected;
        }

        public object ScalarQuery(SqlCommand cmd)
        {
            cmd.Connection = Connect();
            object obj = -1;
            obj = cmd.ExecuteScalar();
            connection.Close();
            return obj;
        }

        public DataTable ReaderQuery(SqlCommand cmd)
        {
            cmd.Connection = Connect();
            SqlDataReader sdr;
            DataTable dt = new DataTable();

            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            connection.Close();
            return dt;
        }
    }
  }
