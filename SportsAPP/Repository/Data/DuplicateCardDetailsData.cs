using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsAPP.Repository.Lib;
using SportsAPP.Models;

namespace SportsAPP.Repository.Data
{
    public class DuplicateCardDetailsData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();

        public List<dynamic> AddDuplicateCardDetails(DuplicateCardDetailsDTO duplicateCardDetailsDTO)
        {
            String insertProcedure = "[CRUD_Duplicate_CardMaster]";
            Dictionary<string, string> input_parameters = new Dictionary<string, string>();

            input_parameters.Add("@pkey_duplicate_id", 1 + " #bigint# " + duplicateCardDetailsDTO.pkey_duplicate_id);
            input_parameters.Add("@category", 1 +"#int#"+duplicateCardDetailsDTO.category);
            input_parameters.Add("@member_id", 1 +"#bigint#"+ duplicateCardDetailsDTO.member_id );
            input_parameters.Add("@receipt_id", 1 +"#bigint#"+ duplicateCardDetailsDTO.receipt_id);
            input_parameters.Add("@curr_date", 1 +"#datetime#" + duplicateCardDetailsDTO.curr_date);
            input_parameters.Add("@amount",1 +"#decimal#" + duplicateCardDetailsDTO.amount);
            input_parameters.Add("@paid_by", 1 +"#int#"+ duplicateCardDetailsDTO.paid_by);
            input_parameters.Add("@cheque_no", 1 +"#bigint#"+ duplicateCardDetailsDTO.cheque_no);
            input_parameters.Add("@cheque_date", 1 +"#datetime#"+duplicateCardDetailsDTO.cheque_date);
            input_parameters.Add("@bank_name", 1 +"#varchar#" +duplicateCardDetailsDTO.bank_name );
 
            input_parameters.Add("@UserID ", 1 + " #bigint# " + duplicateCardDetailsDTO.UserID);
            input_parameters.Add("@IsDeleted ", 1 + "#int#" + duplicateCardDetailsDTO.is_delete);
            input_parameters.Add("@Type", 1 + "#int#" + duplicateCardDetailsDTO.Type);
            input_parameters.Add("@pkey_duplicate_idout", 2 + "#int#" + null);
            input_parameters.Add("@ReturnValue", 2 + "#int#" + null);

            return obj.SqlCRUD(insertProcedure, input_parameters);


        }


    }
}