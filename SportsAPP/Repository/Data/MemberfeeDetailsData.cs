using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportsAPP.Models;
using SportsAPP.Repository.Lib;
using System.Data;

namespace SportsAPP.Repository.Data
{
    public class MemberfeeDetailsData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();

        public List<dynamic> AddMemberfeeDetail(MemberfeeDetailsDTO memberfeeDetailsDTO)
        {
            string insertProcedure = "[CRUD_MemberFee_Master]";

            Dictionary<string, string> input_parameters  = new Dictionary<string, string>();
            input_parameters.Add("@pkey_memberFee_id", 1 + "#bigint#" + memberfeeDetailsDTO.pkey_memberFee_id);
            input_parameters.Add("@categoryId", 1 +"#bigint#"+ memberfeeDetailsDTO.categoryId );
            input_parameters.Add("@entrance_fee" , 1 +"#decimal#"+ memberfeeDetailsDTO.entrance_fee);
            input_parameters.Add("@infrastructure_fee", 1 +"#decimal#"+ memberfeeDetailsDTO.infrastructure_fee);
            input_parameters.Add("@Admission_fee" , 1 +"#decimal#"+ memberfeeDetailsDTO.Admission_fee);
            input_parameters.Add("@total", 1 +"#decimal#"+ memberfeeDetailsDTO.total);

            input_parameters.Add("@UserID ", 1 + " #bigint# " + memberfeeDetailsDTO.UserID);
            input_parameters.Add("@IsDeleted ", 1 + "#int#" + memberfeeDetailsDTO.is_delete);
            input_parameters.Add("@Type", 1 + "#int#" + memberfeeDetailsDTO.Type);
            input_parameters.Add("@pkey_memberFee_idOut", 2 + "#int#" + null);
            input_parameters.Add("@ReturnValue", 2 + "#int#" + null);

            return obj.SqlCRUD(insertProcedure, input_parameters);


        }


        public List<dynamic> GetMemberFeeData() {
            List<dynamic> objDynamic = new List<dynamic>();
            string insertProcedure = "[Get_MemberFee_Master]";

            Dictionary<string,string> input_parameters = new Dictionary<string, string>();
            DataSet ds = obj.SelectSql(insertProcedure, input_parameters);

            var myEnumerable = ds.Tables[0].AsEnumerable();

            List<MemberfeeDetailsDTO> ordtl =
               (from item in myEnumerable
                select new MemberfeeDetailsDTO
                {
                    pkey_memberFee_id = item.Field<Int64>("pkey_memberFee_id"),
                    categoryId=item.Field<Int64>("categoryId"),
                    entrance_fee=item.Field<Decimal>("entrance_fee"),
                    infrastructure_fee=item.Field<Decimal>("infrastructure_fee"),
                    Admission_fee=item.Field<Decimal>("Admission_fee"),
                    total=item.Field<decimal>("total"),

                }).ToList();
            objDynamic.Add(ordtl);
            return objDynamic;
        }

    }
}