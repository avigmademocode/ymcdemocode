using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
    public class GST_PercentageDetailsDTO
    {
        public Int64 pkey_GSTPercent_id { get; set; }

        public String GST_No{ get; set; }
        public int GST_Percentage { get; set; }
        public int UserID { get; set; }
        public int is_delete { get; set; }
        public int Type { get; set; }
    }
}