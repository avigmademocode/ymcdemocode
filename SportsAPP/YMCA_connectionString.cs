using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SportsAPP
{
    public class YMCA_connectionString
    {
        public static string connectionString;

        public static SqlConnection GetConnection()
        {
            connectionString = ConfigurationManager.ConnectionStrings["YMCA_dBcon"].ToString();

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
       
    }
}