using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsAPP.Repository.Lib;
using SportsAPP.Models;


namespace SportsAPP.Repository.Data
{
    public class BranchActivityRelationDetailsData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();

        public List<dynamic> AddBranchActivityRelationDetails(BranchActivityRelationDetailsDTO branchActivityRelationDetailsDTO)
        {
            String insertProcedure = "[CRUD_BranchActivityRelation]";
            Dictionary<string, string> input_parameters = new Dictionary<string, string>();
            input_parameters.Add("@Pkey_branch_activity_id", 1 + "#bigint#" + branchActivityRelationDetailsDTO.Pkey_branch_activity_id);
            input_parameters.Add("@activity_id ", 1 + "#bigint#" + branchActivityRelationDetailsDTO.activity_id);
            input_parameters.Add("@branch_id", 1 + "#bigint#" + branchActivityRelationDetailsDTO.branch_id);


            input_parameters.Add("@UserID ", 1 + " #bigint# " + branchActivityRelationDetailsDTO.UserID);
            input_parameters.Add("@IsDeleted ", 1 + "#int#" + branchActivityRelationDetailsDTO.IsDeleted);
            input_parameters.Add("@Type", 1 + "#int#" + branchActivityRelationDetailsDTO.Type);
            input_parameters.Add("@Pkey_branch_activity_idOut", 2 + "#int#" + null);
            input_parameters.Add("@ReturnValue", 2 + "#int#" + null);


            return obj.SqlCRUD(insertProcedure,input_parameters);
        }

    }
}