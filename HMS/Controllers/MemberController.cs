using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HMS.Auth;
using HMS.Models;
namespace HMS.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        [MemberAccess]
        [Authorize]
        public ActionResult Index()
        {
            var db = new HMSEntities();
            var id = Int32.Parse(Session["logged_user"].ToString());
            var mem = (from m in db.Members
                       where m.Id == id
                       select m).SingleOrDefault();

            return View(mem);
        }
       


        public ActionResult Member_Mealinfo()
        {

            return View();

        }
        [HttpPost]
        public ActionResult Member_Mealinfo(MealInfo mi)
        {
            if (ModelState.IsValid)
            {
                HMSEntities db = new HMSEntities();
                db.MealInfos.Add(mi);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }



        public ActionResult Member_Request_service()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Member_Request_service(Request_Services rs)
        {

            if (ModelState.IsValid)
            {
                HMSEntities db = new HMSEntities();
                db.Request_Services.Add(rs);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult MemberBill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult MemberBill(MemberBill mb)
        {
            if (ModelState.IsValid)
            {
                HMSEntities db = new HMSEntities();
                mb.Member_ID = Int32.Parse(Session["logged_user"].ToString());
                db.MemberBills.Add(mb);
                db.SaveChanges();

                return RedirectToAction("Index");
            }


            return View();
        }

    }
}