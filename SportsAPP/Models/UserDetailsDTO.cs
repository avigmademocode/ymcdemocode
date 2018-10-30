using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
    public class UserDetailsDTO
    {
        public Int64 Pkey_User_id { get; set; }
        public String User_name { get; set; }
        public String Password { get; set; }
        public String First_name { get; set; }
        public String Last_name { get; set; }
        public Int64 Mobile_no { get; set; }
        public String Email_id { get; set; }

        public int Type { get; set; }
        public int UserID { get; set; }
        public int IsDeleted { get; set; }
    }
}