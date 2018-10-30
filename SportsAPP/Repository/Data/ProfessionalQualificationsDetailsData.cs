using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsAPP.Repository.Lib;
using SportsAPP.Models;


namespace SportsAPP.Repository.Data
{
    public class ProfessionalQualificationsDetailsData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();
        public List<dynamic> AddProfQualificationDetails(ProfessionalQualificationsDetailsDTO professionalDTO)
        {
            string insertProcedure = "[CRUD_professional_qualifications_Master]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();

            input_parameters.Add("@Pkey_Prof_QualificationId", 1 + "#bigint#" + professionalDTO.Pkey_Professional_QualificationId);
            input_parameters.Add("@prof_qualifications", 1 + "#varchar#" + professionalDTO.professional_qualifications);

            input_parameters.Add("@UserID ", 1 + " #bigint# " + professionalDTO.UserID);
            input_parameters.Add("@IsDeleted", 1 + " #int# " + professionalDTO.is_delete);
            input_parameters.Add("@Type", 1 + " #int# " + professionalDTO.Type);
            input_parameters.Add("@Pkey_Prof_QualificationIdout", 2 + " #int# " + null);
            input_parameters.Add("@ReturnValue", 2 + " #int# " + null);

            return obj.SqlCRUD(insertProcedure, input_parameters);

        }
    }
}