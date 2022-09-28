using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Schedule.Models
{
    public class SchedulerContext: DbContext
    {
        public DbSet<SchedulerEvent> SchedulerEvents { get; set; }
    }
}