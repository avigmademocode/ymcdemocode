using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
    public class MemberDetailsDTO
    {
        public int MemberId { get; set; }
        public int BranchId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string gender { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        
        public string BranchName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Activity { get; set; }
        public string FullAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public DateTime start_date { get; set; }
        public DateTime expiry_date { get; set; }
        public int Zip { get; set; }
        public int Type { get; set; }
    }
    public class MemberDetails
    {
        public Int64 pkey_member_id { get; set; }
        public String exist_memberId { get; set; }
        public Int64 receiptNo { get; set; }
        public Int64 BranchId { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Int64 mobile_number { get; set; }
        public String email_id { get; set; }
        public Int64 office_tel_no { get; set; }
        public Int64 residential_tel_no { get; set; }
        public String special_interest { get; set; }
        public String pan_no { get; set; }
        public DateTime? date_of_birth { get; set; }
        public int renewal { get; set; }
        public int age { get; set; }
        public int qualification { get; set; }
        public int religion { get; set; }
        public int marital_Status { get; set; }
        public int gender { get; set; }
        public int profession { get; set; }
        public int category { get; set; }
        public String GST_No { get; set; }
        public string siblings { get; set; }
        public string relation { get; set; }

        public int relationship_name { get; set; }
        public decimal amount { get; set; }
        public int paid_by { get; set; }
        public Int64 cheque_no { get; set; }
        public DateTime? cheque_date { get; set; }
        public String bank_name { get; set; }

        public String image_name { get; set; }
        public String image_path { get; set; }

        // public string BranchName { get; set; }
        public string PermAddress1 { get; set; }
        public string PermAddress2 { get; set; }
        public string PermAddress3 { get; set; }

        public Int64 Perm_pincode { get; set; }

        // public string Activity { get; set; }
        //public string FullAddress { get; set; }
        public int Perm_city { get; set; }
        public int Perm_state { get; set; }
        public int Perm_country { get; set; }
        public Boolean SameAsPermAdd_Loc { get; set; }
        public String LocalAddress1 { get; set; }
        public String LocalAddress2 { get; set; }
        public String LocalAddress3 { get; set; }
        public Int64 Local_pincode { get; set; }
        public int Local_city { get; set; }
        public int Local_state { get; set; }
        public int Local_country { get; set; }

        public Boolean SameAsPermAdd_Offi { get; set; }
        public String OfficeAddress1 { get; set; }
        public String OfficeAddress2 { get; set; }
        public String OfficeAddress3 { get; set; }
        public Int64 Off_pincode { get; set; }
        public int Off_city { get; set; }
        public int Off_state { get; set; }
        public int Off_country { get; set; }
        public int CorresAddr { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public Boolean is_blacklist_member { get; set; }
        public int Type { get; set; }
        public Int64 UserID { get; set; }
        public int is_delete { get; set; }

    }
}