using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsAPP.Repository.Lib;
using SportsAPP.Models;
using System.Data;

namespace SportsAPP.Repository.Data
{
    public class CityDetailsData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();
        public List<dynamic> AddCityDetails(CityDetailsDTO cityDetailsDTO)
        {
            string insertProcedure = "[CRUD_CityMaster] ";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();

            input_parameters.Add("@pkey_CityId", 1 + "#bigint#" + cityDetailsDTO.pkey_CityId);
            input_parameters.Add("@CityName ", 1 + " # nvarchar #" + cityDetailsDTO.CityName);


            input_parameters.Add("@UserID ", 1 + " #bigint# " + cityDetailsDTO.UserID);
            input_parameters.Add("@IsDeleted ", 1 + "#int#" + cityDetailsDTO.IsDeleted);
            input_parameters.Add("@Type", 1 + "#int#" + cityDetailsDTO.Type);
            input_parameters.Add("@pkey_CityIdout", 2 + "#int#" + null);
            input_parameters.Add("@ReturnValue", 2 + "#int#" + null);

            return obj.SqlCRUD(insertProcedure,input_parameters);

        }

        public List<dynamic> GetCityDetailById(CityDetailsDTO cityDetailsDTO)
        {
            List<dynamic> objDynamic = new List<dynamic>();
            string insertProcedure = "[Get_CityMasterByID]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();


            input_parameters.Add("@pkey_CityId", 1 + "#bigint#" + cityDetailsDTO.pkey_CityId);

            DataSet ds = obj.SelectSql(insertProcedure, input_parameters);
            var myEnumerable = ds.Tables[0].AsEnumerable();

            List<CityDetailsDTO> ordtl =
              (from item in myEnumerable
               select new CityDetailsDTO
               {
                   pkey_CityId = item.Field<Int64>("pkey_city_id"),
                   CityName = item.Field<String>("city_name"),


               }).ToList();
            objDynamic.Add(ordtl);
            return objDynamic;

        }

        public List<dynamic> GetCityDetailData()
        {
            List<dynamic> objDynamic = new List<dynamic>();
            string insertProcedure = "[Get_CityMaster]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();

            DataSet ds = obj.SelectSql(insertProcedure, input_parameters);
            var myEnumerable = ds.Tables[0].AsEnumerable();

            List<CityDetailsDTO> ordtl =
              (from item in myEnumerable
               select new CityDetailsDTO
               {
                   pkey_CityId = item.Field<Int64>("pkey_city_id"),
                   CityName = item.Field<String>("city_name"),


               }).ToList();
            objDynamic.Add(ordtl);
            return objDynamic;

        }
    }
}