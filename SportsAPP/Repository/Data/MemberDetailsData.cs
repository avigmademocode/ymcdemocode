using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsAPP.Models;
using SportsAPP.Repository.Lib;

namespace SportsAPP.Repository.Data
{
    public class MemberDetailsData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();
        //public List<dynamic> AddMember(MemberDetailsUI Member)
        //{
        //    string insertProcedure = "[MemberMasterInsert]";

        //    DateTime now = DateTime.Now;

        //    Dictionary<string, string> input_parameters = new Dictionary<string, string>();
        //    input_parameters.Add("@pkey_member_id", 1 + "#int#" + Member.MemberId);
        //    //input_parameters.Add("@Branch_name", 1 + "#varchar#" + Member.BranchName);
        //    input_parameters.Add("@first_name", 1 + "#varchar#" + Member.FirstName);
        //    input_parameters.Add("@last_name", 1 + "#varchar#" + Member.LastName);
        //    input_parameters.Add("@mobile_number", 1 + "#varchar#" + Member.Phone);
        //    input_parameters.Add("@email_id", 1 + "#varchar#" + Member.Email);
        //    input_parameters.Add("@address1", 1 + "#varchar#" + Member.Address1);
        //    input_parameters.Add("@address2", 1 + "#varchar#" + Member.Address2);
        //    input_parameters.Add("@address3", 1 + "#varchar#" + Member.Address3);
        //    input_parameters.Add("@pincode", 1 + "#int#" + Member.Zip);
        //    input_parameters.Add("@city", 1 + "#varchar#" + Member.City);
        //    input_parameters.Add("@state", 1 + "#varchar#" + Member.State);
        //    input_parameters.Add("@country", 1 + "#varchar#" + Member.Country);
        // //   input_parameters.Add("@start_date", 1 + "#datetime#" + now);
        //   // input_parameters.Add("@expiry_date", 1 + "#datetime#" + now);
        //    input_parameters.Add("@is_delete", 1 + "#int#" + Member.is_delete);
        //    input_parameters.Add("@UserID", 1 + "#int#" + Member.UserID);
        //    input_parameters.Add("@Type", 1 + "#int#" + Member.Type);
        //    input_parameters.Add("@pkey_member_idOut", 2 + "#int#" + null);
        //    input_parameters.Add("@ReturnValue", 2 + "#int#" + null);

        //    return obj.SqlCRUD(insertProcedure, input_parameters);

        //}

        public List<dynamic> AddMemberDetails(memberUI memberUI)
        {
            string insertProcedure = "[CRUD_MemberMaster]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();
            input_parameters.Add("@pkey_member_id", 1 + "#bigint#" + memberUI.pkey_member_id);
            input_parameters.Add("@first_name", 1 + " #varchar# " + memberUI.first_name);
            input_parameters.Add("@last_name", 1 + "#varchar#" + memberUI.last_name);
            input_parameters.Add("@mobile_number", 1 + "#bigint#" + memberUI.mobile_number);
            input_parameters.Add("@email_id", 1 + "#varchar#" + memberUI.email_id);
            input_parameters.Add("@date_of_birth", 1 + "#datetime#" + memberUI.date_of_birth);
            input_parameters.Add("@age", 1 + "#bigint#" + memberUI.age);
            input_parameters.Add("@siblings", 1 + "#varchar#" + memberUI.siblings);
            input_parameters.Add("@relation", 1 + "#varchar#" + memberUI.relation);
            input_parameters.Add("@relationship_name", 1 + "#int#" + memberUI.relationship_name);
            input_parameters.Add("@amount", 1 + "#decimal#" + memberUI.amount);
            input_parameters.Add("@paid_by", 1 + "# int#" + memberUI.paid_by);
            input_parameters.Add("@cheque_no", 1 + "#bigint#" + memberUI.cheque_no);
            input_parameters.Add("@cheque_date", 1 + "#datetime#" + memberUI.cheque_date);
            input_parameters.Add("@bank_name", 1 + "#varchar#" + memberUI.bank_name);
            input_parameters.Add("@image_name", 1 + "#nvarchar#" + memberUI.image_name);
            input_parameters.Add("@image_path", 1 + " #nvarchar# " + memberUI.image_path);
            input_parameters.Add("@address1", 1 + "#varchar#" + memberUI.address1);
            input_parameters.Add("@address2", 1 + "varchar" + memberUI.address2);
            input_parameters.Add("@address3", 1 + "#varchar#" + memberUI.address3);
            input_parameters.Add("@pincode", 1 + "#bigint#" + memberUI.pincode);
            input_parameters.Add("@city", 1 + "#int#" + memberUI.city);
            input_parameters.Add("@state", 1 + "#int#" + memberUI.state);
            input_parameters.Add("@country", 1 + " #int#" + memberUI.country);
            input_parameters.Add("@start_date", 1 + "#datetime#" + memberUI.start_date);
            input_parameters.Add("@expiry_date", 1 + "#datetime#" + memberUI.expiry_date);
            input_parameters.Add("@is_blacklist_member", 1 + " #int# " + memberUI.is_blacklist_member);

            input_parameters.Add("@UserID ", 1 + " #bigint# " + memberUI.UserID);
            input_parameters.Add("@is_delete ", 1 + " #int# " + memberUI.is_delete);
            input_parameters.Add("@Type", 1 + " #int# " + memberUI.Type);
            input_parameters.Add("@pkey_member_idOut", 2 + " #int# " + null);
            input_parameters.Add("@ReturnValue", 2 + " #int# " + null);

            return obj.SqlCRUD(insertProcedure, input_parameters);
        }
    }
}