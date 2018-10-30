using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
    public class MemberReceiptDetailsDTO
    {
        public Int64 pkey_MemberReceipt_id { get; set; }
        public Int64 member_id { get; set; }
        public Int64 receipt_id { get; set; }
        public Int64 receipt_no { get; set; }
        public Int64 activity_id { get; set; }
        public DateTime receipt_date { get; set; }
        public decimal amount { get; set; }
        public int paid_by { get; set; }
        public String cheque_no { get; set; }
        public DateTime cheque_date { get; set; }
        public DateTime from_date { get; set; }
        public DateTime to_date { get; set; }
        public int Type { get; set; }
        public Int64 UserID { get; set; }

        public int is_delete { get; set; }
    }
}