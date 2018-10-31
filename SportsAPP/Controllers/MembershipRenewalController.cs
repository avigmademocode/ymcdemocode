using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsAPP.Models;
using SportsAPP.Repository.Data;

namespace SportsAPP.Controllers
{
    public class MembershipRenewalController : Controller
    {
        // GET: MembershipRenewal
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult AddMembershipRenewalDataDetail(MembershipRenewalDetailsDTO Model)

        {
            MembershipRenewalDetailsData memberDetails = new MembershipRenewalDetailsData();

             var Data = memberDetails.AddMembershipRenewalData(Model);
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

        public JsonResult GetMemberDataById()
        {
            MemberDetailData memberDetailData = new MemberDetailData();
            var Data = memberDetailData.GetMemberDetailData();
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
    }
}