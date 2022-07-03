using HMS.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HMS.Models;

namespace HMS.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        public ActionResult Index()
        {
            var db = new HMSEntities();
            var id = Int32.Parse(Session["logged_user"].ToString());
            var st = (from s in db.Admins
                      where s.Id == id
                      select s).SingleOrDefault();
            return View(st);
            
        }

    }
}