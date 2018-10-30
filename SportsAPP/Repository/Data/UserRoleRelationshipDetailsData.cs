using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsAPP.Repository.Lib;
using SportsAPP.Models;

namespace SportsAPP.Repository.Data
{
    public class UserRoleRelationshipDetailsData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();
        public List<dynamic> AddUserRoleRelationshipDetails(UserRoleRelationshipDetailsDTO userRoleRelationshipDetailsDTO)
        {
            string insertProcedure = "[CRUD_UserRoleRelationship]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();
            input_parameters.Add("@pkey_user_role_relationship", 1 + "#bigint#" + userRoleRelationshipDetailsDTO.pkey_user_role_relationship);
            input_parameters.Add("@user_id", 1 + " #bigint# " + userRoleRelationshipDetailsDTO.user_id);
            input_parameters.Add("@role_id", 1 + "#bigint#" + userRoleRelationshipDetailsDTO.role_id);


            input_parameters.Add("@UserID ", 1 + " #bigint# " + userRoleRelationshipDetailsDTO.UserID);
            input_parameters.Add("@IsDeleted ", 1 + " #int# " + userRoleRelationshipDetailsDTO.IsDeleted);
            input_parameters.Add("@Type", 1 + " #int# " + userRoleRelationshipDetailsDTO.Type);
            input_parameters.Add("@pkey_user_role_relationshipOut", 2 + " #int# " + null);
            input_parameters.Add("@ReturnValue", 2 + " #int# " + null);

            return obj.SqlCRUD(insertProcedure, input_parameters);


        }

    }
}