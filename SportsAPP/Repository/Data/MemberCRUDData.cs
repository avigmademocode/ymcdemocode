using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SportsAPP.Models;
using SportsAPP.Repository.Lib;

namespace SportsAPP.Repository.Data
{
    public class MemberCRUDData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();
        public List<dynamic> AddMember(MemberDetailsDTO Member)
        {
            string insertProcedure = "[MemberMasterInsert]";

            DateTime now = DateTime.Now;

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();
            input_parameters.Add("@pkey_member_id", 1 + "#int#" + Member.MemberId);
            //input_parameters.Add("@Branch_name", 1 + "#varchar#" + Member.BranchName);
            input_parameters.Add("@first_name", 1 + "#varchar#" + Member.FirstName);
            input_parameters.Add("@last_name", 1 + "#varchar#" + Member.LastName);
            input_parameters.Add("@mobile_number", 1 + "#varchar#" + Member.Phone);
            input_parameters.Add("@email_id", 1 + "#varchar#" + Member.Email);
            input_parameters.Add("@address1", 1 + "#varchar#" + Member.Address1);
            input_parameters.Add("@address2", 1 + "#varchar#" + Member.Address2);
            input_parameters.Add("@address3", 1 + "#varchar#" + Member.Address3);
            input_parameters.Add("@pincode", 1 + "#int#" + Member.Zip);
            input_parameters.Add("@city", 1 + "#varchar#" + Member.City);
            input_parameters.Add("@state", 1 + "#varchar#" + Member.State);
            input_parameters.Add("@country", 1 + "#varchar#" + Member.Country);
            input_parameters.Add("@start_date", 1 + "#datetime#" + now);
            input_parameters.Add("@expiry_date", 1 + "#datetime#" + now);
            //input_parameters.Add("@is_delete", 1 + "#int#" + Member.is_delete);
            //input_parameters.Add("@UserID", 1 + "#int#" + Member.UserID);
            input_parameters.Add("@Type", 1 + "#int#" + Member.Type);
            input_parameters.Add("@pkey_member_idOut", 2 + "#int#" + null);
            input_parameters.Add("@ReturnValue", 2 + "#int#" + null);

            return obj.SqlCRUD(insertProcedure, input_parameters);

        }



        //get Member
        public DataSet GetMember()
        {
            string insertProcedure = "[Get_Member_Master]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();

            input_parameters.Add("@ReturnValue", 2 + "#int#" + null);

            return obj.SelectSql(insertProcedure, input_parameters);


        }
    }
}