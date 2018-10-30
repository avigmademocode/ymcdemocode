using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SportsAPP.Models;

namespace SportsAPP.Repository.Data
{
    public class MemberData
    {
        SqlConnection connection = YMCA_connectionString.GetConnection();
        //Log log = new Log();


        private int AddMemberData(MemberDetailsDTO Member)
        {

            string insertProcedure = "[MemberMasterInsert]";

            SqlCommand insertCommand = new SqlCommand(insertProcedure, connection);
            insertCommand.CommandType = CommandType.StoredProcedure;
            int MemberId = 0;

            if (Member.MemberId != 0)
            {
                insertCommand.Parameters.AddWithValue("@pkey_member_id", Member.MemberId);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@pkey_member_id", 0);
            }
            //if (Member.BranchId != 0)
            //{
            //    insertCommand.Parameters.AddWithValue("@Pkey_Branch_id", Member.BranchId);
            //}
            //else
            //{
            //    insertCommand.Parameters.AddWithValue("@Pkey_Branch_id", 0);
            //}
            //if (!string.IsNullOrEmpty(Member.BranchName))
            //{
            //    insertCommand.Parameters.AddWithValue("@Branch_name", Member.BranchName);
            //}
            //else
            //{
            //    insertCommand.Parameters.AddWithValue("@Branch_name", DBNull.Value);
            //}
            if (!string.IsNullOrEmpty(Member.FirstName))
            {
                insertCommand.Parameters.AddWithValue("@first_name", Member.FirstName);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@first_name", DBNull.Value);
            }
            if (!string.IsNullOrEmpty(Member.LastName))
            {
                insertCommand.Parameters.AddWithValue("@last_name", Member.LastName);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@last_name", DBNull.Value);
            }
            if (Member.Phone != 0)
            {
                insertCommand.Parameters.AddWithValue("@mobile_number", Member.Phone);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@mobile_number", 0);
            }
            if (!string.IsNullOrEmpty(Member.Email))
            {
                insertCommand.Parameters.AddWithValue("@email_id", Member.Email);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@email_id", DBNull.Value);
            }
            if (!string.IsNullOrEmpty(Member.Address1))
            {
                insertCommand.Parameters.AddWithValue("@address1", Member.Address1);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@address1", DBNull.Value);
            }
            if (!string.IsNullOrEmpty(Member.Address2))
            {
                insertCommand.Parameters.AddWithValue("@address2", Member.Address2);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@address2", DBNull.Value);
            }
            if (!string.IsNullOrEmpty(Member.Address3))
            {
                insertCommand.Parameters.AddWithValue("@address3", Member.Address3);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@address3", DBNull.Value);
            }
            //if (!string.IsNullOrEmpty(Member.FullAddress))
            //{
            //    insertCommand.Parameters.AddWithValue("@", Member.FullAddress);
            //}
            //else
            //{
            //    insertCommand.Parameters.AddWithValue("@", DBNull.Value);
            //}
            if (Member.Zip != 0)
            {
                insertCommand.Parameters.AddWithValue("@pincode", Member.Zip);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@pincode", 0);
            }
            if (!string.IsNullOrEmpty(Member.City))
            {
                insertCommand.Parameters.AddWithValue("@city", Member.City);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@city", DBNull.Value);
            }
            if (!string.IsNullOrEmpty(Member.State))
            {
                insertCommand.Parameters.AddWithValue("@state", Member.State);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@state", DBNull.Value);
            }
            if (!string.IsNullOrEmpty(Member.Country))
            {
                insertCommand.Parameters.AddWithValue("@country", Member.Country);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@country", DBNull.Value);
            }

           
            //if (Member.UserID != 0)
            //{
            //    insertCommand.Parameters.AddWithValue("@UserID", Member.UserID);
            //}
            //else
            //{
            //    insertCommand.Parameters.AddWithValue("@UserID", 0);
            //}
            insertCommand.Parameters.AddWithValue("@start_date", Member.start_date);
            insertCommand.Parameters.AddWithValue("@expiry_date", Member.expiry_date);
            insertCommand.Parameters.AddWithValue("@UserID", 0);
            insertCommand.Parameters.AddWithValue("@is_delete", 0);
            insertCommand.Parameters.AddWithValue("@Type", Member.Type);

            insertCommand.Parameters.Add("@pkey_member_idOut", System.Data.SqlDbType.Int);
            insertCommand.Parameters["@pkey_member_idOut"].Direction = ParameterDirection.Output;

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
                if (count != 0 && Member.BranchId == 0)
                {
                    Member.BranchId = Convert.ToInt32(insertCommand.Parameters["@pkey_member_idOut"].Value);
                }

                return MemberId;

            }
            catch (Exception ex)
            {
                //log.logErrorMessage("");
                //log.logErrorMessage(ex.StackTrace);
                return MemberId;
            }
            finally
            {
                connection.Close();
            }

        }
        //branches insert
        public List<dynamic> AddMember(MemberDetailsUI MemberUI)
        {
            List<dynamic> ObjDynamic = new List<dynamic>();
            MemberDetailsDTO MemberDTO = new MemberDetailsDTO();

            MemberDTO.BranchId = MemberUI.BranchId;
            MemberDTO.BranchName = MemberUI.BranchName;
            MemberDTO.FirstName = MemberUI.FirstName;
            MemberDTO.LastName = MemberUI.LastName;
            MemberDTO.Phone = MemberUI.Phone;
            MemberDTO.Email = MemberUI.Email;
            MemberDTO.Address1 = MemberUI.Address1;
            MemberDTO.Address2 = MemberUI.Address2;
            MemberDTO.Address3 = MemberUI.Address3;
            MemberDTO.FullAddress = MemberUI.FullAddress;
            MemberDTO.City = MemberUI.City;
            MemberDTO.State = MemberUI.State;
            MemberDTO.Zip = MemberUI.Zip;
            MemberDTO.Country = MemberUI.Country;
            //MemberDTO.UserID = MemberUI.UserID;
            MemberDTO.Type = 1;
            DateTime now = DateTime.Now;
            MemberDTO.start_date = now;// DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
            MemberDTO.expiry_date = now;
            AddMemberData(MemberDTO);
            ObjDynamic.Add(MemberDTO);
            return ObjDynamic;
        }

    }
}