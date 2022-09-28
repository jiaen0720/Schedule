using Schedule.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Schedule.App_Start
{
    public class SchedulerInitializer : DropCreateDatabaseIfModelChanges<SchedulerContext>
    {
        protected override void Seed(SchedulerContext context)
        {
            List<SchedulerEvent> events = new List<SchedulerEvent>()
            {
                new SchedulerEvent()
                {
                    Id = 1,
                    Text = "Event 1",
                    StartDate = new DateTime(2022, 9, 22, 2, 0, 0),
                    EndDate = new DateTime(2022, 9, 25, 4, 0, 0)
                },
                new SchedulerEvent()
                {
                    Id = 2,
                    Text = "Event 2",
                    StartDate = new DateTime(2022, 1, 14, 3, 0, 0),
                    EndDate = new DateTime(2022, 1, 14, 6, 0, 0)
                },
                new SchedulerEvent()
                {
                    Id = 3,
                    Text = "Multiday event",
                    StartDate = new DateTime(2022, 1, 11, 0, 0, 0),
                    EndDate = new DateTime(2022, 1, 16, 0, 0, 0)
                }
            };

            events.ForEach(s => context.SchedulerEvents.Add(s));
            context.SaveChanges();

        }

    }
}