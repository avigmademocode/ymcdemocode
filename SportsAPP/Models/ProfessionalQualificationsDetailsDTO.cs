using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsAPP.Models
{
    public class ProfessionalQualificationsDetailsDTO
    {
        public Int64 Pkey_Professional_QualificationId { get; set; }
        public String professional_qualifications { get; set; }
        public int UserID { get; set; }
        public int is_delete { get; set; }
        public int Type { get; set; }

    }
}