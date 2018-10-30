using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
    public class StateDetailsDTO
    {
        public Int64 pkey_state_id { get; set; }
        public String state_name { get; set; }

        public int Type { get; set; }
        public int UserID { get; set; }
        public int is_delete { get; set; }
    }
}