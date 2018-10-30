using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsAPP.Repository.Lib;
using SportsAPP.Models;
using System.Data;

namespace SportsAPP.Repository.Data
{
    public class MemberReceiptDetailsData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();

        public List<dynamic> AddMemberReceiptData(MemberReceiptDetailsDTO memberReceiptDetailsDTO)
        {
            string insertProcedure = "[CRUD_Member_Receipt]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();
            input_parameters.Add("@pkey_MemberReceipt_id", 1 +"#bigint#"+memberReceiptDetailsDTO.pkey_MemberReceipt_id);
            input_parameters.Add("@member_id", 1+"#bigint#"+memberReceiptDetailsDTO.member_id);
            input_parameters.Add("@receipt_id", 1+"#bigint#"+memberReceiptDetailsDTO.receipt_id);
            input_parameters.Add("@receipt_no", 1 + "#bigint#" + memberReceiptDetailsDTO.receipt_no);
            input_parameters.Add("@activity_id", 1+"#bigint#"+memberReceiptDetailsDTO.activity_id);
            input_parameters.Add("@receipt_date", 1+"#datetime#"+memberReceiptDetailsDTO.receipt_date);
            input_parameters.Add("@amount", 1 + "#decimal#" + memberReceiptDetailsDTO.amount);
            input_parameters.Add("@paid_by", 1 +"#int#"+ memberReceiptDetailsDTO.paid_by);
            input_parameters.Add("@cheque_no", 1 +"#varchar#" + memberReceiptDetailsDTO.cheque_no);
            input_parameters.Add("@cheque_date", 1 +"#datetime#"+ memberReceiptDetailsDTO.cheque_date);
            input_parameters.Add("@from_date", 1 + "#datetime#" + memberReceiptDetailsDTO.from_date);
            input_parameters.Add("@to_date",1+"#datetime#"+ memberReceiptDetailsDTO.to_date);

            input_parameters.Add("@UserID ", 1 + " #bigint# " + memberReceiptDetailsDTO.UserID);
            input_parameters.Add("@IsDeleted", 1 + "#int#" + memberReceiptDetailsDTO.is_delete);
            input_parameters.Add("@Type", 1 + "#int#" + memberReceiptDetailsDTO.Type);
            input_parameters.Add("@pkey_MemberReceipt_idOut", 2 + "#int#" + null);
            input_parameters.Add("@ReturnValue", 2 + "#int#" + null);

            return obj.SqlCRUD(insertProcedure, input_parameters);



        }
        public List<dynamic> GetMemberData(MemberReceiptDetailsDTO memberReceipt)
        {


            List<dynamic> objDynamic = new List<dynamic>();
            String insertProcedure = "[Get_Member_ReceiptByID]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();

            input_parameters.Add("@pkey_MemberReceipt_id", 1 + "#bigint#" + memberReceipt.pkey_MemberReceipt_id);


            DataSet ds = obj.SelectSql(insertProcedure, input_parameters);

            var myEnumerable = ds.Tables[0].AsEnumerable();


            List<MemberReceiptDetailsDTO> ordtl =
                (from item in myEnumerable
                 select new MemberReceiptDetailsDTO
                 {
                     member_id = item.Field<Int64>("member_id"),
                     receipt_id = item.Field<Int64>("receipt_id"),
                     receipt_no = item.Field<Int64>("receipt_no"),
                     activity_id=item.Field<Int64>("activity_id"),
                     receipt_date=item.Field<DateTime>("receipt_date"),
                     amount=item.Field<decimal>("amount"),
                     paid_by=item.Field<int>("paid_by"),
                     cheque_no=item.Field<String>("cheque_no"),
                     cheque_date=item.Field<DateTime>("cheque_date"),
                     from_date=item.Field<DateTime>("from_date"),
                     to_date=item.Field<DateTime>("to_date"),
                     
                 }).ToList();
            objDynamic.Add(ordtl);
            return objDynamic;
        }
    }
}