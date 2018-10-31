using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsAPP.Models;
using SportsAPP.Repository.Data;


namespace SportsAPP.Controllers
{
    public class MemberController : Controller
    {
        MemberDetailData memberDetailData = new MemberDetailData();
        // GET: Member
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MemberReceipt()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Memberfee()
        {
            return View();
        }


        public JsonResult GetMemberDataId(MemberDetails id)
        {
            MemberDetailData memberDetailData = new MemberDetailData();
            var Response = memberDetailData.GetMemberData(id);
            return new JsonResult { Data = Response, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

        //public JsonResult Edit(Int64 id)
        //{
        //    MemberDetailData memberDetailData = new MemberDetailData();
        //   var Response =  memberDetailData.GetMemberData(id);
        //    return new JsonResult { Data = Response, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        //}


        public JsonResult AddMemberData(MemberDetails Model)
        {
            //MemberData obj = new MemberData();
           
              var Response = memberDetailData.AddMember(Model);
            return new JsonResult { Data = Response, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

        public JsonResult GetMemberData()
        {
            DataSet ds = new DataSet();
            MemberCRUDData obj = new MemberCRUDData();
            ds = obj.GetMember();
            string Data = Newtonsoft.Json.JsonConvert.SerializeObject(ds);
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetMemberBranchData()
        {
            BranchDetailsData branchDetailsData = new BranchDetailsData();
            var Data = branchDetailsData.GetBranchData();
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult AddSpecialInterestsDetailData(Special_InterestsDetailsDTO special_InterestsDTO)
        {
            Special_InterestsDetailsData special_Interests = new Special_InterestsDetailsData();
           var Data = special_Interests.AddSpecial_InterestsDetails(special_InterestsDTO);
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult AddProQulificationDetailData(ProfessionalQualificationsDetailsDTO professionalQualificationsDTO)
        {
            ProfessionalQualificationsDetailsData professionalQualifications = new ProfessionalQualificationsDetailsData();
            var Data = professionalQualifications.AddProfQualificationDetails(professionalQualificationsDTO);
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        public JsonResult AddGSTPerData(GST_PercentageDetailsDTO GST_PercentageDetailsDTO)
        {
            GST_PercentageDetailsData GST_PercentageDetailsData = new GST_PercentageDetailsData();
            var Data = GST_PercentageDetailsData.AddGST_PercentageDetailsDetails(GST_PercentageDetailsDTO);
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


        public JsonResult GetSpecialInterestData()
        {
            Special_InterestsDetailsData special_InterestsDetails = new Special_InterestsDetailsData();
            var Data = special_InterestsDetails.GetSpecial_InterestsDetailsData();
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


        public JsonResult GetProQulificationDetailData()
        {
            ProfessionalQualificationsDetailsData Objprofessional = new ProfessionalQualificationsDetailsData();
            var Data = Objprofessional.GetProQulificationDetail();
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetGSTPercentageDetailsData()
        {
            GST_PercentageDetailsData gST_PercentageDetails = new GST_PercentageDetailsData();
            var Data = gST_PercentageDetails.GetGSTPercentageDetails();
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult AddMemberFeeDetail(MemberfeeDetailsDTO memberfeeDetailsDTO)
        {
            MemberfeeDetailsData memberfeeDetails = new MemberfeeDetailsData();
            var Data = memberfeeDetails.AddMemberfeeDetail(memberfeeDetailsDTO);
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetMemberFeeDetailData()
        {
            MemberfeeDetailsData memberfeeDetails = new MemberfeeDetailsData();
            var Data = memberfeeDetails.GetMemberFeeData();
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
        public JsonResult GetMemberDatas(MemberDetails memberDetails)
        {
            MemberDetailData memberDetailData = new MemberDetailData();
            //var Data = memberDetailData.GetMemberDetailData();
            var Data = memberDetailData.GetMemberData(memberDetails);
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        //public JsonResult GetMemberReceiptData(MemberReceiptDetailsDTO memberReceiptDetailsDTO)
        //{
        //    MemberReceiptDetailsData memberReceiptDetailsData = new MemberReceiptDetailsData();
        //    var Data = memberReceiptDetailsData.GetMemberData(memberReceiptDetailsDTO);
        //    return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        //}
    }
}