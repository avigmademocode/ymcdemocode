using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
    public class RoleDetailsDTO
    {

        public Int64 Pkey_role_id { get; set; }
        public String role_name { get; set; }

        public int Type { get; set; }
        public int UserID { get; set; }
        public int is_delete { get; set; }
    }
}