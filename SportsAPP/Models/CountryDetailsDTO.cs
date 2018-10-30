using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
    public class CountryDetailsDTO
    {
        public Int64 pkey_country_id { get; set; }
        public String country_name { get; set; }
        public Int64 UserID { get; set; }
        public int is_delete { get; set; }

        public int Type { get; set; }
    }
}