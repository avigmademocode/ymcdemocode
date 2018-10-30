using SportsAPP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SportsAPP.Repository.Data
{
    public class userData
    {
        public static DataTable SelectAll()
        {
            SqlConnection connection = YMCA_connectionString.GetConnection();
            string selectProcedure = "[UserMasterSelectAll]";
            SqlCommand selectCommand = new SqlCommand(selectProcedure, connection);
            selectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            List<UserMaster> lst = new List<UserMaster>();
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                return dt;
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}