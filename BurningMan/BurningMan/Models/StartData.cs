using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurningMan.Models;

namespace BurningMan.Models
{
    public static class StartData
    {
        public static void Initialize(ApplicationContext context)
        {
            if (!context.Tickets.Any())
            {
                context.Tickets.AddRange(
                    new Ticket
                    {
                        Type = "Main Ticket",
                        Camp = "Desert Squad",
                        Price = 425
                    },
                    new Ticket
                    {
                        Type = "Park Ticket",
                        Camp = "Desert Squad",
                        Price = 80
                    },
                    new Ticket
                    {
                        Type = "Donation Ticket",
                        Camp = "Desert Squad",
                        Price = 25
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
