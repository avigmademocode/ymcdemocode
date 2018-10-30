using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsAPP.Repository.Lib;
using SportsAPP.Models;

namespace SportsAPP.Repository.Data
{
    public class MembershipRenewalDetailsData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();

        public List<dynamic> AddMembershipRenewalData(MembershipRenewalDetailsDTO memberdata)
        {
            string insertProcedure = "[CRUD_RenewalMembership_Master]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();
            input_parameters.Add("@pkey_renewal_receiptId", 1 +"#bigint#"+memberdata.pkey_renewal_receiptId);
            input_parameters.Add("@member_name", 1 + "#varchar#" + memberdata.member_name);
            input_parameters.Add("@is_service_tax", 1 + "#bit#" + memberdata.is_service_tax);
            input_parameters.Add("@date_of_birth", 1 + "#datetime#" + memberdata.date_of_birth);
            input_parameters.Add("@age", 1 +"#int#"+ memberdata.age);
            input_parameters.Add("@previous_experience", 1 + "#int#" + memberdata.previous_experience);
            input_parameters.Add("@category", 1 + "#int#" + memberdata.category);
            input_parameters.Add("@entrance_fee", 1 + "#decimal#" + memberdata.entrance_fee);
            input_parameters.Add("@amount", 1 + "#decimal#" + memberdata.amount);
            input_parameters.Add("@paid_by", 1 + "#int#" + memberdata.paid_by);
            input_parameters.Add("@cheque_no", 1 + "#varchar#" + memberdata.cheque_no);
            input_parameters.Add("@cheque_date", 1 + "#datetime#" + memberdata.cheque_date);
            input_parameters.Add("@bank_name", 1 + "#varchar#" + memberdata.bank_name);
            input_parameters.Add("@receipt_no", 1 + "#bigint#" + memberdata.receipt_no);
            input_parameters.Add("@GST_NO", 1 + "#nvarchar#" + memberdata.GST_NO);
            input_parameters.Add("@start_date", 1 + "#datetime#" + memberdata.start_date);
            input_parameters.Add("@expiry_date", 1 + "#datetime#" + memberdata.expiry_date);


            input_parameters.Add("@UserID ", 1 + " #bigint# " + memberdata.UserID);
            input_parameters.Add("@IsDeleted ", 1 + "#int#" + memberdata.is_delete);
            input_parameters.Add("@Type", 1 + "#int#" + memberdata.Type);
            input_parameters.Add("@pkey_renewal_receiptIdOut", 2 + "#int#" + null);
            input_parameters.Add("@ReturnValue", 2 + "#int#" + null);


            return obj.SqlCRUD(insertProcedure, input_parameters);
        }
    }
}