using Schedule.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Schedule.Context
{
    public class DBContext : DbContext
    {
        public DBContext() : base("DefaultConnection") { 
        
        }

        public DbSet<DB> DBs { get; set; }
    }
}