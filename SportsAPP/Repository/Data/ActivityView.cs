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
    public class ActivityView
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();
        //get branch
        public DataSet GetActivity()
        {
            string insertProcedure = "[Get_ActivityMasterTEMP]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();

            input_parameters.Add("@ReturnValue", 2 + "#int#" + null);

            return obj.SelectSql(insertProcedure, input_parameters);


        }
    }
}