using HMS.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HMS.Models;

namespace HMS.Controllers
{
    [AdminAccess]
    [Authorize]
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

        public ActionResult UpdateAdmin(int Id)
        {
            HMSEntities db = new HMSEntities();
            var ad = (from st in db.Admins
                           where st.Id == Id
                           select st).FirstOrDefault();

            return View(ad);
        }

        [HttpPost]
        public ActionResult UpdateAdmin(Admin s)
        {
            using (HMSEntities db = new HMSEntities())
            {
                var ad = (from st in db.Admins
                               where st.Id == s.Id
                               select st).FirstOrDefault();
                ad.Type = 1;
                ad.Name = s.Name;
                ad.Phone = s.Phone;
                ad.Email = s.Email;
                ad.Password = s.Password;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

        }

        public ActionResult DeleteAdmin(int id)
        {
            HMSEntities db = new HMSEntities();
            var st = (from s in db.Admins where s.Id == id select s).SingleOrDefault();
            db.Admins.Remove(st);
            db.SaveChanges();
            return RedirectToAction("ListAdmin");
        }

        public ActionResult EditAdmins(int Id)
        {
            HMSEntities db = new HMSEntities();
            var ad = (from st in db.Admins
                      where st.Id == Id
                      select st).FirstOrDefault();

            return View(ad);
        }

        [HttpPost]
        public ActionResult EditAdmins(Admin s)
        {
            using (HMSEntities db = new HMSEntities())
            {
                var ad = (from st in db.Admins
                               where st.Id == s.Id
                               select st).FirstOrDefault();
                ad.Type = 1;
                ad.Name = s.Name;
                ad.Phone = s.Phone;
                ad.Email = s.Email;
                ad.Password = s.Password;
                db.SaveChanges();
                return RedirectToAction("ListAdmin");
            }

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



        public ActionResult EditStaff(int Id)
        {
            HMSEntities db = new HMSEntities();
            var ad = (from st in db.Staffs
                      where st.Id == Id
                      select st).FirstOrDefault();

            return View(ad);
        }

        [HttpPost]
        public ActionResult EditStaff(Staff s)
        {
            using (HMSEntities db = new HMSEntities())
            {
                var ad = (from st in db.Staffs
                          where st.Id == s.Id
                          select st).FirstOrDefault();
                ad.Type = 3;
                ad.Name = s.Name;            
                ad.Age = s.Age;
                ad.Gender = s.Gender;
                ad.Address = s.Address;
                ad.Phone = s.Phone;
                ad.Password = s.Password;
                db.SaveChanges();
                return RedirectToAction("ListStaff");
            }

        }

        public ActionResult DeleteStaff(int id)
        {
            HMSEntities db = new HMSEntities();
            var st = (from s in db.Staffs where s.Id == id select s).SingleOrDefault();
            db.Staffs.Remove(st);
            db.SaveChanges();
            return RedirectToAction("ListStaff");
        }




        public ActionResult StaffTasks(int Id)
        {
            ViewBag.Id = Id;
            HMSEntities db = new HMSEntities();
            var ad = (from st in db.StaffTasks
                      where st.StaffID == Id
                      select st);

            return View(ad);

           
        }

        [HttpPost]
        public ActionResult StaffTasks(StaffTask s)
        {
            HMSEntities db = new HMSEntities();
            s.Status = 0;

            db.StaffTasks.Add(s);
            db.SaveChanges();
            return RedirectToAction("ListStaff");

        }

        public ActionResult DeleteTask(int id)
        {
            HMSEntities db = new HMSEntities();
            var st = (from s in db.StaffTasks where s.ID == id select s).SingleOrDefault();
            db.StaffTasks.Remove(st);
            db.SaveChanges();
            return RedirectToAction("ListStaff");
        }



    }
}