using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Schedule.Controllers
{
    public class OssController : Controller
    {
        // GET: Oss
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Index3()
        {
            return View();
        }

        public ActionResult Index4()
        {
            return View();
        }

        public ActionResult Index5()
        {
            return View();
        }

        public ActionResult Index6()
        {
            return View();
        }

        public ActionResult Index7()
        {
            return View();
        }

        //public JsonResult Index3(DateTime start)
        //{
        //    return new JsonResult { Data = new { status = "" } };
        //}

        public class Data
        {
            public int EventID { get; set; }
            public string Subject { get; set; }
            public string Description { get; set; }
            public DateTime Start { get; set; }
            public DateTime End { get; set; }
            public string ThemeColor { get; set; }
            public Boolean IsFullDay { get; set; }
        }

        public JsonResult GetEvents()
        {
            Data list = new Data();
            list.Subject = "";
            list.Description = "";
            list.Start = DateTime.Now;
            list.End = DateTime.Now.AddDays(1); ;
            list.ThemeColor = "green";
            list.IsFullDay = false;

            return new JsonResult { Data = list, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        //[HttpPost]
        //public JsonResult SaveEvent(Data e)
        //{
        //    var status = false;
        //    using (MyDatabaseEntities dc = new MyDatabaseEntities())
        //    {
        //        if (e.EventID > 0)
        //        {
        //            //Update the event
        //            var v = dc.Events.Where(a => a.EventID == e.EventID).FirstOrDefault();
        //            if (v != null)
        //            {
        //                v.Subject = e.Subject;
        //                v.Start = e.Start;
        //                v.End = e.End;
        //                v.Description = e.Description;
        //                v.IsFullDay = e.IsFullDay;
        //                v.ThemeColor = e.ThemeColor;
        //            }
        //        }
        //        else
        //        {
        //            dc.Events.Add(e);
        //        }
        //        dc.SaveChanges();
        //        status = true;
        //    }
        //    return new JsonResult { Data = new { status = status } };
        //}

        //[HttpPost]
        //public JsonResult DeleteEvent(int eventID)
        //{
        //    var status = false;
        //    using (MyDatabaseEntities dc = new MyDatabaseEntities())
        //    {
        //        var v = dc.Events.Where(a => a.EventID == eventID).FirstOrDefault();
        //        if (v != null)
        //        {
        //            dc.Events.Remove(v);
        //            dc.SaveChanges();
        //            status = true;
        //        }
        //    }
        //    return new JsonResult { Data = new { status = status } };
        //}
    }
}