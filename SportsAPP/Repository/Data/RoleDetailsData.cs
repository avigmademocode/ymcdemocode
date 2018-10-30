
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsAPP.Repository.Lib;
using SportsAPP.Models;

namespace SportsAPP.Repository.Data
{
    public class RoleDetailsData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();

        public List<dynamic> AddRoleDetails(RoleDetailsDTO roleDetailsDTO)
        {
            string insertProcedure = "[CRUD_RoleMaster]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();
            input_parameters.Add("@Pkey_role_id", 1 + " #bigint# " + roleDetailsDTO.Pkey_role_id);
            input_parameters.Add("@role_name", 1 + " #varchar# " + roleDetailsDTO.role_name);

            input_parameters.Add("@UserID ", 1 + " #bigint# " + roleDetailsDTO.UserID);
            input_parameters.Add("@is_delete ", 1 + " #int# " + roleDetailsDTO.is_delete);
            input_parameters.Add("@Type", 1 + " #int# " + roleDetailsDTO.Type);
            input_parameters.Add("@Pkey_role_idOut", 2 + " #int# " + null);
            input_parameters.Add("@ReturnValue", 2 + " #int# " + null);

            return obj.SqlCRUD(insertProcedure, input_parameters);


        }
    }
}