using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
 
    public class ActivityDetailsUI
    {
        public Int64 Pkey_activity_id { get; set; }
        public String activity_name { get; set; }
        public decimal amount { get; set; }


        public Int64 branch_id { get; set; }
        public Int64 city_id { get; set; }
       public  Int64 state_id { get; set; }

         public Int64 UserID { get; set; }
        public int IsDeleted { get; set; }

        public int Type { get; set; }
    }

   
}