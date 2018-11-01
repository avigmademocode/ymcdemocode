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
    public class BranchController : Controller
    {
        BranchDetailsUI BranchDetailsUI = new BranchDetailsUI();
        // GET: Branch
        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
        //getbranch data
        public JsonResult GetBranch()
        {
            BranchCRUDData obj = new BranchCRUDData();
            DataSet ds = new DataSet();
            ds = obj.GetBranches();
            string Data = Newtonsoft.Json.JsonConvert.SerializeObject(ds);
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        //add batch data
        public JsonResult AddNewBrach(BranchDetailsUI Model)
        {
            BranchDetailsData obj = new BranchDetailsData();
            var Data = obj.AddBranches(Model);
            //var Data = RepoData.AddBranches(Model);
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        public JsonResult GetBranchCityData()
        {
            CityDetailsData cityDetailsData = new CityDetailsData();
            var Data = cityDetailsData.GetCityDetailData();
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        public JsonResult GetBarchStateData()
        {
            StateDetailsData stateDetailsData = new StateDetailsData();
            var Data = stateDetailsData.GetStateData();
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        //get branch data by id
        public JsonResult GetBranchDetailData(BranchDetailsUI branchDetailsUI)
        {
            BranchDetailsData branchDetailsData = new BranchDetailsData();
            var Data =branchDetailsData.GetBranchDataByID(branchDetailsUI);
            return new JsonResult { Data = Data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}