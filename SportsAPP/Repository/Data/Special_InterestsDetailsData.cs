using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsAPP.Repository.Lib;
using SportsAPP.Models;
using System.Data;

namespace SportsAPP.Repository.Data
{
    public class Special_InterestsDetailsData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();
        public List<dynamic> AddSpecial_InterestsDetails(Special_InterestsDetailsDTO special_InterestsDTO)
        {
            string insertProcedure = "[CRUD_Special _Interests_Master]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();
            input_parameters.Add("@pkey_special_interests_id", 1 +"#bigint#"+special_InterestsDTO.pkey_special_interests_id);
            input_parameters.Add("@special_interests", 1 + "#varchar#" + special_InterestsDTO.special_interests);

            input_parameters.Add("@UserID ", 1 + " #bigint# " + special_InterestsDTO.UserID);
            input_parameters.Add("@IsDeleted", 1 + " #int# " + special_InterestsDTO.is_delete);
            input_parameters.Add("@Type", 1 + " #int# " + special_InterestsDTO.Type);
            input_parameters.Add("@pkey_special_interests_idout", 2 + " #int# " + null);
            input_parameters.Add("@ReturnValue", 2 + " #int# " + null);

            return obj.SqlCRUD(insertProcedure, input_parameters);
        }

        public List<dynamic> GetSpecial_InterestsDetailsData()
        {
            List<dynamic> objDynamic = new List<dynamic>();

            string insertProcedure = "[Get_SpecialInterestsMaster]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();
            DataSet ds = obj.SelectSql(insertProcedure, input_parameters);

            var myEnumerable = ds.Tables[0].AsEnumerable();

            List<Special_InterestsDetailsDTO> ordtl =
               (from item in myEnumerable
                select new Special_InterestsDetailsDTO
                {

                    pkey_special_interests_id = item.Field<Int64>("pkey_special_interests_id"),
                    special_interests = item.Field<String>("special_interests"),

                }).ToList();
            objDynamic.Add(ordtl);
            return objDynamic;
        }

        }
}