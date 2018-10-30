using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
    public class UserRoleRelationshipDetailsDTO
    {
        public Int64 pkey_user_role_relationship { get; set; }
        public Int64 user_id { get; set; }
        public Int64 role_id { get; set; }

        public int Type { get; set; }
        public int UserID { get; set; }
        public int IsDeleted { get; set; }
    }
}