using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HMS.Models;

namespace HMS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(Admin e)
        {

                HMSEntities db = new HMSEntities();
                var ad = (from s in db.Admins
                          where s.Id.Equals(e.Id)
                          && s.Password.Equals(e.Password)
                          select s).SingleOrDefault();

           
                var mem = (from s in db.Members
                            where s.Id.Equals(e.Id)
                            && s.Password.Equals(e.Password)
                            select s).SingleOrDefault();

           



            if (ad != null)
            {
                Session["logged_user"] = ad.Id;
                return RedirectToAction("Index", "Admin");
            }
            else if (mem != null)
            {
                Session["logged_user"] = mem.Id;
                return RedirectToAction("Index", "Member");
            }

                TempData["msg"] = "User Does not exist";
                return View();
 
        }

    }
}