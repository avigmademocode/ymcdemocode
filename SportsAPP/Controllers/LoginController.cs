using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsAPP.Repository.Data;

namespace SportsAPP.Controllers
{
    public class LoginController : Controller
    {
        DataTable dtusers = new DataTable();
        DataTable dtmenu = new DataTable();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ValidateUser(string username, string password)
        {
            if (dtusers != null || dtusers.Rows.Count <= 0)
            {
                dtusers = userData.SelectAll();
                try
                {
                    DataRow data = (from DataRow c in dtusers.Rows
                                    where c.Field<string>("username") == username && c.Field<string>("Pwd") == password
                                    select c).SingleOrDefault();
                    if (data != null && data.ItemArray.Count() > 0)
                    {

                        Session["FirstName"] = data["FirstName"].ToString();
                        Session["RoleName"] = data["RoleName"].ToString();
                        Session["CustId"] = data["CustId"].ToString();
                        Session["UserId"] = data["UserId"].ToString();
                        Session["RoleId"] = data["RoleId"].ToString();
                        //dtmenu = MenuData.MenuSelectForRole(Convert.ToInt64(data["RoleId"]));  //uncomment menu sathi
                        //Session["listMenu"] = dtmenu;
                        return Json(new { Success = true }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        ViewBag.message = "Invalid username/password.";
                        return Json(new { Success = false }, JsonRequestBehavior.AllowGet);
                    }

                }
                catch (Exception ex) { return Json(new { Success = false }, JsonRequestBehavior.AllowGet); }
            }
            else
            {
                //FormsAuthentication.SignOut();
                Session.Clear();
                Session.Abandon();
                Session.RemoveAll();
                return Json(new { Success = false }, JsonRequestBehavior.AllowGet);
            }
            //var data =from c dtusers.id where c.username==userid && c.password==password select c;
        }
    }
}