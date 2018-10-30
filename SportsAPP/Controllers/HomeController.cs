using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsAPP.Models;
using SportsAPP.Repository.Data;

namespace SportsAPP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //Login here login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string userid, string password)
        {
            if (userid == "admin" && password == "admin")
            {
                //FormsAuthentication.RedirectFromLoginPage(uid, false);
                // Response.Redirect("/AngularDB.html");
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.errormsg = "Invalid user and password";
            }
            return View();
        }


        public ActionResult NotFound()
        {
            return View();
        }
       
        public ActionResult Activity()
        {
            return View();
        }
        public ActionResult CreateActivity()
        {
            return View();
        }
        public ActionResult Setting()
        {
            return View();
        }

    }
}