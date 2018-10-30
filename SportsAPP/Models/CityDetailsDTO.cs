using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
    public class CityDetailsDTO
    {
        public Int64 pkey_CityId { get; set; }
        public String CityName { get; set; }
        public Int64 UserID { get; set; }
        public int IsDeleted { get; set; }
        public int Type { get; set; }
    }
}