using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Common;
using SportsAPP;
using SportsAPP.Models;
using SportsAPP.Repository.Lib;

namespace SportsAPP.Repository.Data
{
    public class BranchCRUDData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();
        public List<dynamic> AddBranches(BranchDetailsUI Branches)
        {
            string insertProcedure = "[BranchMasterInsert]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();
            //input_parameters.Add("@Pkey_Branch_id", 1 + "#int#" + Branches.BranchId);
            input_parameters.Add("@Pkey_Branch_id", 1 + "#int#" + Branches.Pkey_Branch_id);
            input_parameters.Add("@Branch_name", 1 + "#varchar#" + Branches.BranchName);
            input_parameters.Add("@address3", 1 + "#varchar#" + Branches.BranchEmail);
            input_parameters.Add("@address1", 1 + "#varchar#" + Branches.Address1);
            input_parameters.Add("@address2", 1 + "#varchar#" + Branches.Address2);
            input_parameters.Add("@city", 1 + "#varchar#" + Branches.City);
            input_parameters.Add("@state", 1 + "#varchar#" + Branches.State);
            input_parameters.Add("@country", 1 + "#varchar#" + Branches.country);
            input_parameters.Add("@pincode", 1 + "#int#" + Branches.Zip);
            input_parameters.Add("@UserID", 1 + "#int#" + Branches.UserID);
            input_parameters.Add("@is_delete", 1 + "#int#" + Branches.is_delete);
            input_parameters.Add("@Type", 1 + "#int#" + Branches.Type);
            input_parameters.Add("@Pkey_Branch_idout", 2 + "#int#" + null );
            input_parameters.Add("@ReturnValue", 2 + "#int#" + null);

            return obj.SqlCRUD(insertProcedure, input_parameters);

        }


        //get branch
        public DataSet GetBranches()
        {
            string insertProcedure = "[Get_Branch_Master]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();
           
            input_parameters.Add("@ReturnValue", 2 + "#int#" + null);

            return obj.SelectSql(insertProcedure, input_parameters);
            

        }


    }
}