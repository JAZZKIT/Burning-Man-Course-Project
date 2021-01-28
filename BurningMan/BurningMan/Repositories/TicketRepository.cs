using System;
using System.Collections.Generic;
using System.Linq;
using BurningMan.Interfaces;
using BurningMan.Models;
using Microsoft.EntityFrameworkCore;

namespace BurningMan.Repositories
{
    public class TicketRepository : IRepository<Ticket>
    {
        private ApplicationContext db;

        public TicketRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public void Create(Ticket item)
        {
            db.Tickets.Add(item);
        }

        public void Delete(int id)
        {
            Ticket tic = db.Tickets.Find(id);
            if (tic != null)
                db.Tickets.Remove(tic);
        }

        public IEnumerable<Ticket> Find(Func<Ticket, bool> predicate)
        {
            return db.Tickets.Where(predicate).ToList();
        }

        public Ticket Get(int id)
        {
            return db.Tickets.Find(id);
        }

        public IEnumerable<Ticket> GetAll()
        {
            return db.Tickets;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Ticket item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
