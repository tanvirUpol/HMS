using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HMS.Models;
namespace HMS.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Member_MealInfo()
        {

            return View();

        }
        [HttpPost]
       public ActionResult Member_Mealinfo(MealInfo mi)
        {
            HMSEntities db = new HMSEntities();
            db.MealInfos.Add(mi);
            db.SaveChanges();

            return RedirectToAction("Index");

        }


        public ActionResult Member_Request_service()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Member_Request_service(Request_Services rs)
        {

            HMSEntities db = new HMSEntities();
            db.Request_Services.Add(rs);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}