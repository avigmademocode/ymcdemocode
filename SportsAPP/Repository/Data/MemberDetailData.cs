using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SportsAPP.Models;
using SportsAPP.Repository.Lib;

namespace SportsAPP.Repository.Data
{
    public class MemberDetailData
    {
        MyDataSourceFactory obj = new MyDataSourceFactory();
        public List<dynamic> AddMember(MemberDetails Member)
        {
            string insertProcedure = "[CRUD_MemberMaster]";

            DateTime now = DateTime.Now;

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();
            input_parameters.Add("@pkey_member_id", 1 + "#bigint#" + Member.pkey_member_id);
            input_parameters.Add("@exist_memberId", 1 + "#nvarchar#" + Member.exist_memberId);
            input_parameters.Add("@receiptNo", 1 + "#bigint#" + Member.receiptNo);
            input_parameters.Add("@BranchId", 1 + "#bigint#" + Member.BranchId);
            input_parameters.Add("@first_name", 1 + "#varchar#" + Member.first_name);
            input_parameters.Add("@last_name", 1 + "#varchar#" + Member.last_name);
            input_parameters.Add("@mobile_number", 1 + "#bigint#" + Member.mobile_number);
            input_parameters.Add("@email_id", 1 + "#varchar#" + Member.email_id);
            input_parameters.Add("@office_tel_no", 1 + "#bigint#" + Member.office_tel_no);
            input_parameters.Add("@residential_tel_no", 1 + "#bigint#" + Member.residential_tel_no);
            input_parameters.Add("@special_interest", 1 + "#nvarchar#" + Member.special_interest);
            input_parameters.Add("@pan_no", 1 + "#varchar#" + Member.pan_no);
            input_parameters.Add("@date_of_birth", 1 + "#datetime#" + Member.date_of_birth);
            //input_parameters.Add("@date_of_birth", 1 + "#datetime#" + Member.date_of_birth);
            input_parameters.Add("@renewal", 1 + "#int#" + Member.renewal);
            input_parameters.Add("@age", 1 + "#int#" + Member.age);
            input_parameters.Add("@qualification", 1 + "#int#" + Member.qualification);
            input_parameters.Add("@religion", 1 + "#int#" + Member.religion);
            input_parameters.Add("@marital_Status", 1 + "#int#" + Member.marital_Status);
            input_parameters.Add("@gender", 1 + "#int#" + Member.gender);
            input_parameters.Add("@profession", 1 + "#int#" + Member.profession);
            input_parameters.Add("@category", 1 + "#int#" + Member.category);
            input_parameters.Add("@GST_No", 1 + "#varchar#" + Member.GST_No);
            input_parameters.Add("@siblings", 1 + "#varchar#" + Member.siblings);
            input_parameters.Add("@relation", 1 + "#varchar#" + Member.relation);
            input_parameters.Add("@relationship_name", 1 + "#int#" + Member.relationship_name);
            input_parameters.Add("@amount", 1 + "#decimal#" + Member.amount);
            input_parameters.Add("@paid_by", 1 + "#int#" + Member.paid_by);
            input_parameters.Add("@cheque_no", 1 + "#bigint#" + Member.cheque_no);
            input_parameters.Add("@cheque_date", 1 + "#datetime#" + Member.cheque_date);
            input_parameters.Add("@bank_name", 1 + "#varchar#" + Member.bank_name);
            input_parameters.Add("@image_name", 1 + "#nvarchar#" + Member.image_name);
            input_parameters.Add("@image_path", 1 + "#nvarchar#" + Member.image_path);
            input_parameters.Add("@PermAddress1", 1 + "#varchar#" + Member.PermAddress1);
            input_parameters.Add("@PermAddress2", 1 + "#varchar#" + Member.PermAddress2);
            input_parameters.Add("@PermAddress3", 1 + "#varchar#" + Member.PermAddress3);
            input_parameters.Add("@Perm_pincode", 1 + "#bigint#" + Member.Perm_pincode);
            input_parameters.Add("@Perm_city", 1 + "#int#" + Member.Perm_city);
            input_parameters.Add("@Perm_state", 1 + "#int#" + Member.Perm_state);
            input_parameters.Add("@Perm_country", 1 + "#int#" + Member.Perm_country);
            input_parameters.Add("@SameAsPermAdd_Loc", 1 + "#bit#" + Member.SameAsPermAdd_Loc);
            input_parameters.Add("@LocalAddress1", 1 + "#varchar#" + Member.LocalAddress1);
            input_parameters.Add("@LocalAddress2", 1 + "#varchar#" + Member.LocalAddress2);
            input_parameters.Add("@LocalAddress3", 1 + "#varchar#" + Member.LocalAddress3);
            input_parameters.Add("@Local_pincode", 1 + "#bigint#" + Member.Local_pincode);
            input_parameters.Add("@Local_city", 1 + "#int#" + Member.Local_city);
            input_parameters.Add("@Local_state", 1 + "#int#" + Member.Local_state);
            input_parameters.Add("@Local_country", 1 + "#int#" + Member.Local_country);
            input_parameters.Add("@SameAsPermAdd_Offi", 1 + "#bit#" + Member.SameAsPermAdd_Offi);
            input_parameters.Add("@OfficeAddress1", 1 + "#varchar#" + Member.OfficeAddress1);
            input_parameters.Add("@OfficeAddress2", 1 + "#varchar#" + Member.OfficeAddress2);
            input_parameters.Add("@OfficeAddress3", 1 + "#varchar#" + Member.OfficeAddress3);
            input_parameters.Add("@Off_pincode", 1 + "#bigint#" + Member.Off_pincode);
            input_parameters.Add("@Off_city", 1 + "#int#" + Member.Off_city);
            input_parameters.Add("@Off_state", 1 + "#int#" + Member.Off_state);
            input_parameters.Add("@Off_country", 1 + "#int#" + Member.Off_country);
            input_parameters.Add("@CorresAddr", 1 + "#int#" + Member.CorresAddr);
            //input_parameters.Add("@start_date", 1 + "#datetime#" + now);
            //input_parameters.Add("@expiry_date", 1 + "#datetime#" + now);

            input_parameters.Add("@start_date", 1 + "#datetime#" + Member.StartDate);
            input_parameters.Add("@expiry_date", 1 + "#datetime#" + Member.ExpiryDate);
            input_parameters.Add("@is_blacklist_member", 1 + "#bit#" + Member.is_blacklist_member);
            input_parameters.Add("@is_delete", 1 + "#int#" + Member.is_delete);
            input_parameters.Add("@UserID", 1 + "#bigint#" + Member.UserID);
            input_parameters.Add("@Type", 1 + "#int#" + Member.Type);
            input_parameters.Add("@pkey_member_idOut", 2 + "#int#" + null);
            input_parameters.Add("@ReturnValue", 2 + "#int#" + null);

            return obj.SqlCRUD(insertProcedure, input_parameters);

        }

       
        public List<dynamic> GetMemberData(MemberDetails memberDetails)
        {
            List<dynamic> objDynamic = new List<dynamic>();

            string insertProcedure = "[Get_Member_MasterByID]";
            Dictionary<string, string> input_parameters = new Dictionary<string, string>();

            input_parameters.Add("@pkey_member_id", 1 + "#bigint#" + memberDetails.pkey_member_id);

            DataSet ds = obj.SelectSql(insertProcedure, input_parameters);

            var myEnumerable = ds.Tables[0].AsEnumerable();

            List<MemberDetails> ordtl =
               (from item in myEnumerable
                select new MemberDetails
                {
                    pkey_member_id=item.Field<Int64>("pkey_member_id"),
                    receiptNo = item.Field<Int64>("receiptNo"),
                    exist_memberId = item.Field<String>("exist_memberId"),
                    BranchId=item.Field<Int64>("BranchId"),
                    Branch_name=item.Field<String>("Branch_name"),
                    first_name =item.Field<String>("first_name"),
                    last_name=item.Field<String>("last_name"),
                    mobile_number=item.Field<Int64>("mobile_number"),
                    email_id=item.Field<String>("email_id"),
                    office_tel_no=item.Field<Int64>("office_tel_no"),
                    residential_tel_no=item.Field<Int64>("residential_tel_no"),
                    special_interest=item.Field<String>("special_interest"),
                    pan_no=item.Field<String>("pan_no"),
                    date_of_birth=item.Field<DateTime>( "date_of_birth"),
                    age = item.Field<int?>("age"),
                    qualification=item.Field<int>("qualification"),
                    religion=item.Field<int>("religion"),
                    marital_Status=item.Field<int>("marital_Status"),
                    gender=item.Field<int>("gender"),
                    profession=item.Field<int>("profession"),
                    category=item.Field<int>("category"),
                    GST_No=item.Field<String>("GST_No"),
                    amount=item.Field<decimal>("amount"),
                    paid_by=item.Field<int>("paid_by"),
                    cheque_no=item.Field<Int64>("cheque_no"),
                    cheque_date=item.Field<DateTime>("cheque_date"),
                    bank_name=item.Field<String>("bank_name"),
                      // image_name=item.Field<String> ("image_name"),
                      // image_path=item.Field<String>("image_path"),
                    PermAddress1=item.Field<String>("PermAddress1"),
                    PermAddress2=item.Field<String>("PermAddress2"),
                    PermAddress3=item.Field<String>("PermAddress3"),
                    Perm_pincode=item.Field<Int64>("Perm_pincode"),
                    Perm_city =item.Field<int>("Perm_city"),
                    Perm_state=item.Field<int>("Perm_state"),
                    Perm_country=item.Field<int>("Perm_country"),
                    SameAsPermAdd_Loc=item.Field<Boolean>("SameAsPermAdd_Loc"),
                    LocalAddress1=item.Field<String>("LocalAddress1"),
                    LocalAddress2=item.Field<String>("LocalAddress2"),
                    LocalAddress3=item.Field<String>("LocalAddress3"),
                    Local_pincode=item.Field<Int64>("Local_pincode"),
                    Local_city=item.Field<int>("Local_city"),
                    Local_state=item.Field<int>("Local_state"),
                    Local_country=item.Field<int>("Local_country"),
                    SameAsPermAdd_Offi=item.Field<Boolean>("SameAsPermAdd_Offi"),
                    OfficeAddress1=item.Field<String>("OfficeAddress1"),
                    OfficeAddress2=item.Field<String>("OfficeAddress2"),
                    OfficeAddress3=item.Field<String>("OfficeAddress3"),
                    Off_pincode=item.Field<Int64>("Off_pincode"),
                    Off_city=item.Field<int>("Off_city"),
                    Off_state=item.Field<int>("Off_state"),
                    Off_country=item.Field<int>("Off_country"),
                    CorresAddr=item.Field<int>("CorresAddr"),
                    StartDate=item.Field<DateTime>("start_date"),
                    ExpiryDate=item.Field<DateTime>("expiry_date"),
                    is_blacklist_member=item.Field<Boolean>("is_blacklist_member"),
                                                    
                }).ToList();
            objDynamic.Add(ordtl);
            return objDynamic;
        }


        public List<dynamic> GetMemberDetailData()
        {
            List<dynamic> objDynamic = new List<dynamic>();

            string insertProcedure = "[Get_Member_Master]";

            Dictionary<string, string> input_parameters = new Dictionary<string, string>();

            DataSet ds = obj.SelectSql(insertProcedure, input_parameters);

            var myEnumerable = ds.Tables[0].AsEnumerable();

            List<MemberDetails> ordtl =
               (from item in myEnumerable
                select new MemberDetails
                {
                    pkey_member_id = item.Field<Int64>("pkey_member_id"),
                    receiptNo = item.Field<Int64>("receiptNo"),
                    exist_memberId = item.Field<String>("exist_memberId"),
                    BranchId=item.Field<Int64>("BranchId"),
                    Branch_name = item.Field<String>("Branch_name"),
                    first_name = item.Field<String>("first_name"),
                    last_name = item.Field<String>("last_name"),
                    mobile_number = item.Field<Int64>("mobile_number"),
                    email_id = item.Field<String>("email_id"),
                    office_tel_no = item.Field<Int64>("office_tel_no"),
                    residential_tel_no = item.Field<Int64>("residential_tel_no"),
                    special_interest = item.Field<String>("special_interest"),
                    pan_no = item.Field<String>("pan_no"),
                    date_of_birth = item.Field<DateTime>("date_of_birth"),
                    age = item.Field<int?>("age"),
                    qualification = item.Field<int>("qualification"),
                    religion = item.Field<int>("religion"),
                    marital_Status = item.Field<int>("marital_Status"),
                    gender = item.Field<int>("gender"),
                    profession = item.Field<int>("profession"),
                    category = item.Field<int>("category"),
                    GST_No = item.Field<String>("GST_No"),
                    amount = item.Field<decimal>("amount"),
                    paid_by = item.Field<int>("paid_by"),
                    cheque_no = item.Field<Int64>("cheque_no"),
                    cheque_date = item.Field<DateTime>("cheque_date"),
                    bank_name = item.Field<String>("bank_name"),
                    // image_name=item.Field<String> ("image_name"),
                    // image_path=item.Field<String>("image_path"),
                    PermAddress1 = item.Field<String>("PermAddress1"),
                    PermAddress2 = item.Field<String>("PermAddress2"),
                    PermAddress3 = item.Field<String>("PermAddress3"),
                    Perm_pincode = item.Field<Int64>("Perm_pincode"),
                    Perm_city = item.Field<int>("Perm_city"),
                    Perm_state = item.Field<int>("Perm_state"),
                    Perm_country = item.Field<int>("Perm_country"),
                    SameAsPermAdd_Loc = item.Field<Boolean>("SameAsPermAdd_Loc"),
                    LocalAddress1 = item.Field<String>("LocalAddress1"),
                    LocalAddress2 = item.Field<String>("LocalAddress2"),
                    LocalAddress3 = item.Field<String>("LocalAddress3"),
                    Local_pincode = item.Field<Int64>("Local_pincode"),
                    Local_city = item.Field<int>("Local_city"),
                    Local_state = item.Field<int>("Local_state"),
                    Local_country = item.Field<int>("Local_country"),
                    SameAsPermAdd_Offi = item.Field<Boolean>("SameAsPermAdd_Offi"),
                    OfficeAddress1 = item.Field<String>("OfficeAddress1"),
                    OfficeAddress2 = item.Field<String>("OfficeAddress2"),
                    OfficeAddress3 = item.Field<String>("OfficeAddress3"),
                    Off_pincode = item.Field<Int64>("Off_pincode"),
                    Off_city = item.Field<int>("Off_city"),
                    Off_state = item.Field<int>("Off_state"),
                    Off_country = item.Field<int>("Off_country"),
                    CorresAddr = item.Field<int>("CorresAddr"),
                    StartDate = item.Field<DateTime>("start_date"),
                    ExpiryDate = item.Field<DateTime>("expiry_date"),
                    is_blacklist_member = item.Field<Boolean>("is_blacklist_member"),

                }).ToList();
            objDynamic.Add(ordtl);
            return objDynamic;
        }


    }


        ////get Member
        //    public DataSet GetMember()
        //    {
        //    string insertProcedure = "[MemberMasterSelectAll]";

        //    Dictionary<string, string> input_parameters = new Dictionary<string, string>();

        //    input_parameters.Add("@ReturnValue", 2 + "#int#" + null);

        //    return obj.SelectSql(insertProcedure, input_parameters);


        //     }
    }
