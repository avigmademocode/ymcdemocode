using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SportsAPP.Models;

namespace SportsAPP.Repository.Data
{
    public class BranchData
    {
      
        SqlConnection connection = YMCA_connectionString.GetConnection();
        //Log log = new Log();
        

        private int AddBranches(BranchDetailsDTO Brnches)
        {

            string insertProcedure = "[BranchMasterInsert]";

            SqlCommand insertCommand = new SqlCommand(insertProcedure, connection);
            insertCommand.CommandType = CommandType.StoredProcedure;
            int BranchId = 0;

            if (Brnches.BranchId != 0)
            {
                insertCommand.Parameters.AddWithValue("@Pkey_Branch_id", Brnches.BranchId);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Pkey_Branch_id", 0);
            }
           
            if (!string.IsNullOrEmpty(Brnches.BranchName))
            {
                insertCommand.Parameters.AddWithValue("@Branch_name", Brnches.BranchName);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@Branch_name", DBNull.Value);
            }
            if (!string.IsNullOrEmpty(Brnches.BranchEmail))
            {
                insertCommand.Parameters.AddWithValue("@address3", Brnches.BranchEmail);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@address3", DBNull.Value);
            }
            //if (Brnches.BranchPhone != 0) 
            //{
            //    insertCommand.Parameters.AddWithValue("@", Brnches.BranchPhone);
            //}
            //else
            //{
            //    insertCommand.Parameters.AddWithValue("@", 0);
            //}
            
            if (!string.IsNullOrEmpty(Brnches.FullAddress))
            {
                insertCommand.Parameters.AddWithValue("@address1", Brnches.FullAddress);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@address1", DBNull.Value);
            }
            if (!string.IsNullOrEmpty(Brnches.FullAddress))
            {
                insertCommand.Parameters.AddWithValue("@address2", Brnches.FullAddress);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@address2", DBNull.Value);
            }
            if (!string.IsNullOrEmpty(Brnches.City))
            {
                insertCommand.Parameters.AddWithValue("@city", Brnches.City);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@city", DBNull.Value);
            }
            if (!string.IsNullOrEmpty(Brnches.State))
            {
                insertCommand.Parameters.AddWithValue("@state", Brnches.State);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@state", DBNull.Value);
            }
            if (!string.IsNullOrEmpty(Brnches.country))
            {
                insertCommand.Parameters.AddWithValue("@country", Brnches.country);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@country", DBNull.Value);
            }
            if (Brnches.Zip != 0)
            {
                insertCommand.Parameters.AddWithValue("@pincode", Brnches.Zip);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@pincode", 0);
            }
            if (Brnches.UserID != 0)
            {
                insertCommand.Parameters.AddWithValue("@UserID", Brnches.UserID);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@UserID", 0);
            }
            insertCommand.Parameters.AddWithValue("@is_delete", 0);
            insertCommand.Parameters.AddWithValue("@Type", Brnches.Type);

            insertCommand.Parameters.Add("@Pkey_Branch_idout", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@Pkey_Branch_idout"].Direction = ParameterDirection.Output;

            insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@ReturnValue"].Direction = ParameterDirection.Output;


            try
            {
                int count = 0;
                connection.Open();
                insertCommand.ExecuteNonQuery();
                if (insertCommand.Parameters["@ReturnValue"].Value != DBNull.Value)
                {
                    count = System.Convert.ToInt32(insertCommand.Parameters["@ReturnValue"].Value);
                }
                if (count != 0 && Brnches.BranchId == 0)
                {
                    Brnches.BranchId = Convert.ToInt32(insertCommand.Parameters["@Pkey_Branch_idout"].Value);
                }

                return BranchId;

            }
            catch (Exception ex)
            {
                //log.logErrorMessage("");
                //log.logErrorMessage(ex.StackTrace);
                return BranchId;
            }
            finally
            {
                connection.Close();
            }

        }
        //branches insert
        public List<dynamic> AddBranches(BranchDetailsUI Branches)
        {
            List<dynamic> ObjDynamic = new List<dynamic>();
            BranchDetailsDTO BranchDTO = new BranchDetailsDTO();

            BranchDTO.BranchId = Branches.BranchId;
            BranchDTO.BranchName = Branches.BranchName;
            BranchDTO.City = Branches.City;
            BranchDTO.FullAddress = Branches.FullAddress;
            BranchDTO.State = Branches.State;
            BranchDTO.Zip = Branches.Zip;
            BranchDTO.country = Branches.country;
            BranchDTO.UserID = Branches.UserID;
            BranchDTO.Type = 1;
            AddBranches(BranchDTO);
            ObjDynamic.Add(BranchDTO);
            return ObjDynamic;
        }
       
    }
}