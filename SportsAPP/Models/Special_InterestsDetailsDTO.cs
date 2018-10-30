using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
    public class Special_InterestsDetailsDTO
    {
        public Int64 pkey_special_interests_id { get; set; }
        public String special_interests { get; set; }
        public int UserID { get; set; }
        public int is_delete { get; set; }
        public int Type { get; set; }
    }
}