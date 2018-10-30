using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
    public class BranchActivityRelationDetailsDTO
    {
        public Int64 Pkey_branch_activity_id { get; set; }
        public Int64 activity_id { get; set; }
        public Int64 branch_id { get; set; }
        public Int64 UserID { get; set; }
        public int IsDeleted { get; set; }
        public int Type { get; set; }
    }
}