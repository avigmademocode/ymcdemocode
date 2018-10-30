using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsAPP.Repository.Data;
using SportsAPP.Models;
using SportsAPP.Repository.DAL;
using System.Data;

namespace SportsAPP.Controllers
{
    public class ActivityController : Controller
    {
        // GET: Activity
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Activity()
        {
            return View();
        }
        public JsonResult AddActivityData(ActivityDetailsUI activityDetailsUI)
        {
            IActivityDetails activityDetailsData  = new ActivityDetailsData();
           
            try
            {
              var  Data = activityDetailsData.AddActivity(activityDetailsUI);
                return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
            catch(Exception ex)
            {
                return new JsonResult { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }



        //getActivity data
        public JsonResult GetActivity()
        {
            ActivityView obj = new ActivityView();
            DataSet ds = new DataSet();
            ds = obj.GetActivity();
            string Data = Newtonsoft.Json.JsonConvert.SerializeObject(ds);
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }



        public JsonResult GetActivityBranchData()
        {
            BranchDetailsData branchDetailsData = new BranchDetailsData();

            var Data = branchDetailsData.GetBranchData();
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


        public JsonResult GetActivityCityData()
        {
            CityDetailsData cityDetailsData = new CityDetailsData();
            var Data = cityDetailsData.GetCityDetailData();
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        public JsonResult GetActivityStateData()
        {
            StateDetailsData stateDetailsData = new StateDetailsData();
            var Data = stateDetailsData.GetStateData();
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}