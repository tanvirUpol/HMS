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

        public ActionResult ListAdmin()
        {
            var db = new HMSEntities();

            var st = (from s in db.Admins  select s);
            return View(st);

        }

        public ActionResult CreateAdmin()
        {
           
            return View();

        }

        [HttpPost]
        public ActionResult CreateAdmin(Admin e)
        {
            HMSEntities db = new HMSEntities();
            e.Type = 1;
            db.Admins.Add(e);
            db.SaveChanges();
            return RedirectToAction("ListAdmin");

        }

        public ActionResult DeleteAdmin(int id)
        {
            HMSEntities db = new HMSEntities();
            var st = (from s in db.Admins where s.Id == id select s).SingleOrDefault();
            db.Admins.Remove(st);
            db.SaveChanges();
            return RedirectToAction("ListAdmin");
        }

        public ActionResult ListStaff()
        {
            var db = new HMSEntities();

            var st = (from s in db.Staffs select s);
            return View(st);

        }

        public ActionResult CreateStaff()
        {

            return View();

        }

        [HttpPost]
        public ActionResult CreateStaff(Staff e)
        {
            HMSEntities db = new HMSEntities();
            e.Type = 3;
            db.Staffs.Add(e);
            db.SaveChanges();
            return RedirectToAction("ListStaff");

        }


    }
}