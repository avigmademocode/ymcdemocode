using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using SportsAPP.Models;
using SportsAPP.Repository.Lib;

namespace SportsAPP.Repository.Data
{
    public class GST_PercentageDetailsData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();
        public List<dynamic> AddGST_PercentageDetailsDetails(GST_PercentageDetailsDTO GST_PercentageDTO )
        {
            string insertProcedure = "[CRUD_GST_Percentage_Master]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();

            input_parameters.Add("@pkey_GSTPercent_id", 1 + "#bigint#" +GST_PercentageDTO.pkey_GSTPercent_id );
            input_parameters.Add("@GST_No", 1 + "#varchar#" + GST_PercentageDTO.GST_No);
            input_parameters.Add("@GST_Percentage", 1 + "#int#" + GST_PercentageDTO.GST_Percentage);

            input_parameters.Add("@UserID ", 1 + " #bigint# " + GST_PercentageDTO.UserID);
            input_parameters.Add("@IsDeleted", 1 + " #int# " + GST_PercentageDTO.is_delete);
            input_parameters.Add("@Type", 1 + " #int# " + GST_PercentageDTO.Type);
            input_parameters.Add("@pkey_GSTPercent_idout", 2 + " #int# " + null);
            input_parameters.Add("@ReturnValue", 2 + " #int# " + null);


            return obj.SqlCRUD(insertProcedure, input_parameters);
        }
        }
    }