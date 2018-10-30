using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsAPP.Repository.Lib;
using SportsAPP.Models;

namespace SportsAPP.Repository.Data
{
    public class CountryDetailsData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();

        public List<dynamic> AddCountryDetails(CountryDetailsDTO countryDetailsDTO)
        {
            string insertProcedure = "[CRUD_CountryMaster]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();

            input_parameters.Add("@pkey_country_id ", 1 + "#bigint#" + countryDetailsDTO.pkey_country_id);
            input_parameters.Add("@country_name", 1 + "#varchar#" + countryDetailsDTO.country_name);

            input_parameters.Add("@UserID ", 1 + " #bigint# " + countryDetailsDTO.UserID);
            input_parameters.Add("@is_delete ", 1 + "#int#" + countryDetailsDTO.is_delete);
            input_parameters.Add("@Type", 1 + "#int#" + countryDetailsDTO.Type);
            input_parameters.Add("@pkey_country_idOut", 2 + "#int#" + null);
            input_parameters.Add("@ReturnValue", 2 + "#int#" + null);

            return obj.SqlCRUD(insertProcedure, input_parameters);

        }
    }
}