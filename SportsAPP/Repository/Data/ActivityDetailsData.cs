using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsAPP.Repository.Lib;
using SportsAPP.Models;
using SportsAPP.Repository.DAL;
using System.Data;

namespace SportsAPP.Repository.Data
{
    public class ActivityDetailsData : IActivityDetails
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();

        List<dynamic> IActivityDetails.AddActivity(ActivityDetailsUI activityDetailsUI)
        {
            String insertProcedure = "[CRUD_ActivityMaster]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();

            input_parameters.Add("@Pkey_activity_id", 1 + "#bigint#" + activityDetailsUI.Pkey_activity_id);
            input_parameters.Add("@activity_name", 1 + "#varchar#" + activityDetailsUI.activity_name);
            input_parameters.Add("@amount", 1 + "#decimal#" + activityDetailsUI.amount);
            input_parameters.Add("@branch_id", 1 + "#bigint#" + activityDetailsUI.branch_id);
            input_parameters.Add("@city_id", 1 + "#bigint#" + activityDetailsUI.city_id);
            input_parameters.Add("@state_id", 1 + "#bigint#" + activityDetailsUI.state_id);

            input_parameters.Add("@UserID ", 1 + " #bigint# " + activityDetailsUI.UserID);
            input_parameters.Add("@IsDeleted ", 1 + "#int#" + activityDetailsUI.IsDeleted);
            input_parameters.Add("@Type", 1 + "#int#" + activityDetailsUI.Type);
            input_parameters.Add("@Pkey_activity_idout", 2 + "#int#" + null);
            input_parameters.Add("@ReturnValue", 2 + "#int#" + null);

            return obj.SqlCRUD(insertProcedure, input_parameters);
        }

        public List<dynamic> GetActivityData(ActivityDetailsUI activityData)
        {
            List<dynamic> objDynamic = new List<dynamic>();

            string insertProcedure = "[Get_BranchMasterByID]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();

            input_parameters.Add("@Pkey_activity_id", 1 + "#bigint#" + activityData.Pkey_activity_id);



            DataSet ds = obj.SelectSql(insertProcedure, input_parameters);

            var myEnumerable = ds.Tables[0].AsEnumerable();

            List<ActivityDetailsUI> ordtl =
               (from item in myEnumerable
                select new ActivityDetailsUI
                {
                    activity_name=item.Field<String>("activity_name"),
                    branch_id=item.Field<Int64>("branch_id"),
                    city_id=item.Field<Int64>("city_id"),
                    state_id =item.Field<Int64>("city_id"),
                    

                }).ToList();
            objDynamic.Add(ordtl);
            return objDynamic;
        }
    }
    }