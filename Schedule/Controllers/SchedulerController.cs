using Schedule.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Schedule.Controllers
{
    public class SchedulerController : ApiController
    {
        private SchedulerContext db = new SchedulerContext();

        // GET: api/scheduler
        public IEnumerable<WebAPIEvent> Get()
        {
            return db.SchedulerEvents.ToList().Select(e => (WebAPIEvent)e);
        }

        // GET: api/scheduler/5
        public WebAPIEvent Get(int id)
        {
            return (WebAPIEvent)db.SchedulerEvents.Find(id);
        }

        // PUT: api/scheduler/5
        [System.Web.Http.HttpPut]
        public IHttpActionResult EditSchedulerEvent(int id, WebAPIEvent webAPIEvent)
        {
            var updatedSchedulerEvent = (SchedulerEvent)webAPIEvent;
            updatedSchedulerEvent.Id = id;
            db.Entry(updatedSchedulerEvent).State = EntityState.Modified;
            db.SaveChanges();

            return Ok(new
            {
                action = "updated"
            });
        }

        // POST: api/scheduler/5
        [System.Web.Http.HttpPost]
        public IHttpActionResult CreateSchedulerEvent(WebAPIEvent webAPIEvent)
        {
            var newSchedulerEvent = (SchedulerEvent)webAPIEvent;
            db.SchedulerEvents.Add(newSchedulerEvent);
            db.SaveChanges();

            return Ok(new
            {
                tid = newSchedulerEvent.Id,
                action = "inserted"
            });
        }

        // DELETE: api/scheduler/5
        [System.Web.Http.HttpDelete]
        public IHttpActionResult DeleteSchedulerEvent(int id)
        {
            var schedulerEvent = db.SchedulerEvents.Find(id);
            if (schedulerEvent != null)
            {
                db.SchedulerEvents.Remove(schedulerEvent);
                db.SaveChanges();
            }

            return Ok(new
            {
                action = "deleted"
            });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}