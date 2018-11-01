using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
    public class CategoryDTO
    {
        public Int64  pkey_category_id { get; set; }
        public string categoryname { get; set; }
        public decimal? Amount { get; set; }
    }
}