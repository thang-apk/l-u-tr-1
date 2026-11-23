using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    internal class ketnoi
    {
        SqlConnection conn;

        public SqlConnection MoKetNoi()
        {
            string connStr =
                @"Data Source=DESKTOP-AS239TS\MSSQLSERVERNEW;
                  Initial Catalog=winform;
                  User ID=thang;
                  Password=21810310364";

            conn = new SqlConnection(connStr);

            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;
        }

        public void DongKetNoi()
        {
            if (conn != null &&
                conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }

        }
    }
}
