using Schedule.Context;
using Schedule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Schedule.Controllers
{
    public class HomeController : Controller
    {
        DBContext db = new DBContext();

        public ActionResult Index()
        {
            return View(db.DBs.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}