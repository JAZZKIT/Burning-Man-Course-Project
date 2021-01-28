using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BurningMan.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public Microsoft.EntityFrameworkCore.DbSet<Ticket> Tickets { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Order> Orders { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        //public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<ApplicationContext>
        //{
        //    protected override void Seed(ApplicationContext db)
        //    {
        //        db.Tickets.Add(new Ticket { Type = "Main Ticket", Camp = "Desert Squad", Price = 425 });
        //        db.Tickets.Add(new Ticket { Type = "Park Ticket", Camp = "Desert Squad", Price = 80 });
        //        db.Tickets.Add(new Ticket { Type = "Donation Ticket", Camp = "Desert Squad", Price = 25 });
        //        db.SaveChanges();
        //    }
        //}
    }
}

