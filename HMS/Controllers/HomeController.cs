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
                var st = (from s in db.Admins
                          where s.Name.Equals(e.Name)
                          && s.Password.Equals(e.Password)
                          select s).SingleOrDefault();
                if (st != null)
                {
                    Session["logged_user"] = st.Id;
                    return RedirectToAction("Index", "Home");
                }
                TempData["msg"] = "User Does not exist";
                return View();
 
        }

    }
}