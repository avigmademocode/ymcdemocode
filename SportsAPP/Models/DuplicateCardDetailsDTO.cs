using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
    public class DuplicateCardDetailsDTO
    {
        public Int64 pkey_duplicate_id { get; set; }
        public int category { get; set; }
        public Int64 member_id { get; set; }
        public Int64 receipt_id { get; set; }
        public DateTime curr_date { get; set; }
        public decimal amount { get; set; }
        public int paid_by { get; set; }
        public Int64 cheque_no { get; set; }
        public DateTime cheque_date { get; set; }
        public String bank_name { get; set; }
        
        public Int64 UserID { get; set; }
        public int is_delete { get; set; }

        public int Type { get; set; }
    }
}