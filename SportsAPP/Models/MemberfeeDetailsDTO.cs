using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
    public class MemberfeeDetailsDTO
    {
        public Int64 pkey_memberFee_id { get; set; }
        public Int64 categoryId { get; set; }
        public decimal entrance_fee { get; set; }
        public decimal infrastructure_fee { get; set; }
        public decimal Admission_fee { get; set; }
        public decimal total { get; set; }

        public Int64 UserID { get; set; }
        public int is_delete { get; set; }

        public int Type { get; set; }
    }
}