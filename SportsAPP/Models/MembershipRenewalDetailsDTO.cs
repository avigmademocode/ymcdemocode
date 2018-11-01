using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
    public class MembershipRenewalDetailsDTO
    {
        public Int64 pkey_renewal_receiptId { get; set; }
        public String member_name { get; set; }
        public Boolean is_service_tax { get; set; }
        public DateTime? date_of_birth { get; set; }
        public int age { get; set; }
        public int previous_experience { get; set; }
        public int category { get; set; }
        public decimal entrance_fee { get; set; }
        public decimal amount { get; set; }
        public int paid_by { get; set; }
        public String cheque_no { get; set; }
        public DateTime? cheque_date { get; set; }
        public String bank_name { get; set; }
        public Int64 receipt_no { get; set; }
        public String GST_NO { get; set; }
        public DateTime? start_date { get; set; }
        public DateTime? expiry_date { get; set; }
        public Int64 UserID { get; set; }
        public int Type { get; set; }
        public int is_delete { get; set; }
    }
}