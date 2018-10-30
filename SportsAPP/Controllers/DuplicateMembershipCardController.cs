using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsAPP.Repository.Data;
using SportsAPP.Models;

namespace SportsAPP.Controllers
{
    public class DuplicateMembershipCardController : Controller
    {
        // GET: DuplicateMembershipCard
        public ActionResult DuplicateCard()
        {
            return View();
        }

        public JsonResult AddDuplicateMembershipData(DuplicateCardDetailsDTO duplicateCardDTO)
        {
            DuplicateCardDetailsData duplicateCardDetailsData = new DuplicateCardDetailsData();
            var Data = duplicateCardDetailsData.AddDuplicateCardDetails(duplicateCardDTO);
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}