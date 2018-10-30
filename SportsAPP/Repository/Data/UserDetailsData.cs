using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsAPP.Repository.Lib;
using SportsAPP.Models;

namespace SportsAPP.Repository.Data
{
    public class UserDetailsData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();

        public List<dynamic> AddUserDetails(UserDetailsDTO userDetailsDTO)
        {
            string insertProcedure = "[CRUD_UserMaster]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();
            input_parameters.Add("@Pkey_User_id", 1 + "#bigint#" + userDetailsDTO.Pkey_User_id);
            input_parameters.Add("@User_name", 1 + "#varchar#" + userDetailsDTO.User_name);
            input_parameters.Add("@Password", 1 + " #varchar# " + userDetailsDTO.Password);
            input_parameters.Add("@First_name", 1 + " #varchar# " + userDetailsDTO.First_name);
            input_parameters.Add("@Last_name", 1 + " #varchar# " + userDetailsDTO.Last_name);
            input_parameters.Add("@Mobile_no", 1 + "#bigint#" + userDetailsDTO.Mobile_no);
            input_parameters.Add("@Email_id", 1 + "#varchar#" + userDetailsDTO.Email_id);


            input_parameters.Add("@UserID ", 1 + " #bigint# " + userDetailsDTO.UserID);
            input_parameters.Add("@IsDeleted ", 1 + " #int# " + userDetailsDTO.IsDeleted);
            input_parameters.Add("@Type", 1 + " #int# " + userDetailsDTO.Type);
            input_parameters.Add("@Pkey_User_idout", 2 + " #int# " + null);
            input_parameters.Add("@ReturnValue", 2 + " #int# " + null);

            return obj.SqlCRUD(insertProcedure, input_parameters);


        }
    }
}