using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApp.Models
{
    public class MvcDbContext : DbContext
    {
        public MvcDbContext() : base("DefaultConnection") { }


        public DbSet<Person> Persons { get; set; }
    }
}