using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsAPP.Repository.Lib;
using SportsAPP.Models;

namespace SportsAPP.Repository.Data
{
    public class ActivityReceiptDetailsData
    {

        MyDataSourceFactory obj = new MyDataSourceFactory();
        public List<dynamic> AddActivityReceiptData(ActivityReceiptDetails activityReceiptDetails)
        {
            String insertProcedure = "[CRUD_Activity_Receipt_Master]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();

            input_parameters.Add("@pkey_ActivityReceipt_id", 1 + "#bigint#" + activityReceiptDetails.pkey_ActivityReceipt_id);
            input_parameters.Add("@receipt_id",1 +"#bigint#"+ activityReceiptDetails.receipt_id);
            input_parameters.Add("@member_id",1+"#bigint#"+ activityReceiptDetails.member_id);
            input_parameters.Add("@curr_date", 1 + "#datetime#" + activityReceiptDetails.curr_date); 
            input_parameters.Add("@from_date", 1 + "#datetime#" + activityReceiptDetails.from_date);
            input_parameters.Add("@to_date", 1 + "#datetime#" + activityReceiptDetails.to_date);
            input_parameters.Add("@member_name", 1 + "#varchar#" + activityReceiptDetails.member_name);
            input_parameters.Add("@activity_id", 1 + "#bigint#" + activityReceiptDetails.activity_id);
            input_parameters.Add("@branch_id", 1 + "#bigint#" + activityReceiptDetails.branch_id);
            input_parameters.Add("@city_id", 1 + "#bigint#" + activityReceiptDetails.city_id);
            input_parameters.Add("@amount", 1 + "#decimal#" + activityReceiptDetails.amount);
            input_parameters.Add("@paid_by", 1 + "#int#" + activityReceiptDetails.paid_by);
            input_parameters.Add("@cheque_no", 1 + "#varchar#" + activityReceiptDetails.cheque_no);
            input_parameters.Add("@cheque_date", 1 + "#datetime#" + activityReceiptDetails.cheque_date);
            input_parameters.Add("@bank_name", 1 + "#varchar#" + activityReceiptDetails.bank_name);
            input_parameters.Add("@description", 1 + "#varchar#" + activityReceiptDetails.description);
            input_parameters.Add("@Is_MemeberRegister", 1 + "#int#" + activityReceiptDetails.Is_MemeberRegister);

            input_parameters.Add("@UserID", 1 + "#bigint#" + activityReceiptDetails.UserID);
            input_parameters.Add("@is_delete ", 1 + "#int#" + activityReceiptDetails.is_delete);
            input_parameters.Add("@Type", 1 + "#int#" + activityReceiptDetails.Type);
            input_parameters.Add("@pkey_ActivityReceipt_idOut", 2 + "#int#" + null);
            input_parameters.Add("@ReturnValue", 2 + "#int#" + null);


            return obj.SqlCRUD(insertProcedure,input_parameters);

        }
        


    }
}