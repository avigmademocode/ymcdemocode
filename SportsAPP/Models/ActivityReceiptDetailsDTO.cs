using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
   
     public class  ActivityReceiptDetails
    {
        public Int64 pkey_ActivityReceipt_id { get; set; }
        public Int64 receipt_id { get; set; }
        public Int64 member_id { get; set; }
        public String curr_date { get; set; }
        public String from_date { get; set; }
        public String to_date { get; set; }
        public String member_name { get; set; }
        public Int64 activity_id { get; set; }
        public Int64 branch_id { get; set; }
        public Int64 city_id { get; set; }
        public decimal amount { get; set; }
        public int paid_by { get; set; }
        public String cheque_no { get; set; }
        public String cheque_date { get; set; }
        public String bank_name { get; set; }
        public String description { get; set; }
        public int Is_MemeberRegister { get; set; }

        public Int64 UserID { get; set; }
        public int is_delete { get; set; }
        public int Type { get; set; }
    }
}