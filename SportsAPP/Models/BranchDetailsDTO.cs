using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
    //public class BranchDetailsDTO
    //{
    //    public int BranchId { get; set; }
    //    public string BranchName { get; set; }
    //    public string BranchEmail { get; set; }
    //    public int BranchPhone { get; set; }
    //    public string FullAddress { get; set; }
    //    public string Address1 { get; set; }
    //    public string Address2 { get; set; }
    //    public string City { get; set; }
    //    public string State { get; set; }
    //    public string country { get; set; }
    //    public int Zip { get; set; }
    //    public int Type { get; set; }
    //    public int UserID { get; set; }
    //}
    public class BranchDetailsUI
    {
       // public int BranchId { get; set; }
       public Int64 Pkey_Branch_id { get; set; }
        public string BranchName { get; set; }
        public string BranchEmail { get; set; }
        public int BranchPhone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string FullAddress { get; set; }
        public int City { get; set; }
        public int State { get; set; }
        public int country { get; set; }
        public Int64 Zip { get; set; }
        public String city_name { get; set; }
        public String state_name { get; set; }
        public int UserID { get; set; }
        public int is_delete { get; set; }
        public int Type { get; set; }

    }
}