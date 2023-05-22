using EventsProject.Models.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventsProject.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("EventsProjectConnectionString") { }
        public DbSet<Event> Events { get; set; }
        public DbSet<Localization> Localization { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}