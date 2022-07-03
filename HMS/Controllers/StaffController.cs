using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HMS.Models;

namespace HMS.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalGro()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalGro(CalGro e)
        {
            HMSEntities db = new HMSEntities();
            db.CalGros.Add(e);
            db.SaveChanges();
            return View();
        }
    }
}
