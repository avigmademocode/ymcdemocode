using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsAPP.Models;
using SportsAPP.Repository.Data;

namespace SportsAPP.Controllers
{
    public class ActivityReceiptController : Controller
    {
        ActivityReceiptDetailsData activityReceiptDetailsData = new ActivityReceiptDetailsData();
        // GET: ActivityReceipt
        public ActionResult Index()
        {
            return View();
        }

        public  JsonResult  AddReceiptData(ActivityReceiptDetails activityReceiptDetails)
        {
            var Data = activityReceiptDetailsData.AddActivityReceiptData(activityReceiptDetails);
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}