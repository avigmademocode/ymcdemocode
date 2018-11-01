using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Common;
using SportsAPP;
using SportsAPP.Models;
using SportsAPP.Repository.Lib;
using System.Linq;

namespace SportsAPP.Repository.Data
{
    public class BranchDetailsData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();
        public List<dynamic> AddBranches(BranchDetailsUI Branches)
        {
            string insertProcedure = "[CRUD_BranchMaster]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();
           // input_parameters.Add("@Pkey_Branch_id", 1 + "#bigint#" + Branches.BranchId);
            input_parameters.Add("@Pkey_Branch_id", 1 + "#bigint#" + Branches.Pkey_Branch_id);
            input_parameters.Add("@Branch_name", 1 + "#varchar#" + Branches.BranchName);
            input_parameters.Add("@address3", 1 + "#varchar#" + Branches.BranchEmail);
            input_parameters.Add("@address1", 1 + "#varchar#" + Branches.Address1);
            input_parameters.Add("@address2", 1 + "#varchar#" + Branches.Address2);
            input_parameters.Add("@city", 1 + "#int#" + Branches.City);
            input_parameters.Add("@state", 1 + "#int#" + Branches.State);
            input_parameters.Add("@country", 1 + "#int#" + Branches.country);
            input_parameters.Add("@pincode", 1 + "#int#" + Branches.Zip);
            input_parameters.Add("@UserID", 1 + "#int#" + Branches.UserID);
            input_parameters.Add("@is_delete", 1 + "#int#" + Branches.is_delete);
            input_parameters.Add("@Type", 1 + "#int#" + Branches.Type);
            input_parameters.Add("@Pkey_Branch_idout", 2 + "#int#" + null );
            input_parameters.Add("@ReturnValue", 2 + "#int#" + null);

            return obj.SqlCRUD(insertProcedure, input_parameters);

        }

        public List<dynamic> GetBranchDataByID(BranchDetailsUI branchdata)
        {
            List<dynamic> objDynamic = new List<dynamic>();

            string insertProcedure = "[Get_BranchMasterByID]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();
            input_parameters.Add("@Pkey_Branch_id", 1 + "#bigint#" + branchdata.Pkey_Branch_id);


            DataSet ds = obj.SelectSql(insertProcedure, input_parameters);

            var myEnumerable = ds.Tables[0].AsEnumerable();

            List<BranchDetailsUI> ordtl =
               (from item in myEnumerable
                select new BranchDetailsUI
                {
                    BranchName=item.Field<String>("Branch_name"),
                    Address1=item.Field<String>("address1"),
                    Address2=item.Field<String>("address2"),
                    FullAddress=item.Field<String>("address3"),
                    Zip=item.Field<int>("pincode"),
                    City=item.Field<int>("city"),
                    State=item.Field<int>("state"),
                    country=item.Field<int>("country"),


                }).ToList();
            objDynamic.Add(ordtl);
            return objDynamic;
        }


        public List<dynamic> GetBranchData()
        {
            List<dynamic> objDynamic = new List<dynamic>();
            string insertProcedure = "[Get_Branch_Master]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();


            DataSet ds = obj.SelectSql(insertProcedure, input_parameters);

            var myEnumerable = ds.Tables[0].AsEnumerable();

            List<BranchDetailsUI> ordtl =
                      (from item in myEnumerable
                       select new BranchDetailsUI
                       {

                           Pkey_Branch_id = item.Field<Int64>("Pkey_Branch_id"),
                           BranchName = item.Field<String>("Branch_name"),
                           Address1 = item.Field<String>("address1"),
                           Address2 = item.Field<String>("address2"),
                           FullAddress = item.Field<String>("address3"),
                           Zip = item.Field<Int64>("pincode"),
                           City = item.Field<int>("city"),
                           State = item.Field<int>("state"),
                           country = item.Field<int>("country"),
                           city_name=item.Field<String>("city_name"),
                           state_name=item.Field<String>("state_name"),


                       }).ToList();
            objDynamic.Add(ordtl);
            return objDynamic;

        }


        //////
        public List<dynamic> GetCategoryData()
        {
            List<dynamic> objDynamic = new List<dynamic>();
            string insertProcedure = "[Get_Category_Master]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();


            DataSet ds = obj.SelectSql(insertProcedure, input_parameters);

            var myEnumerablex = ds.Tables[0].AsEnumerable();

            List<CategoryDTO> ordtlx =
                      (from item in myEnumerablex
                       select new CategoryDTO
                       {
                           pkey_category_id = item.Field<Int64>("pkey_category_id"),
                           categoryname = item.Field<String>("categoryname"),
                           Amount = item.Field<decimal>("Amount"),
                       }).ToList();
            objDynamic.Add(ordtlx);
            return objDynamic;

        }
    }
 }
