using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurningMan.Models;

namespace BurningMan.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Ticket> Tickets { get; }
        IRepository<Order> Orders { get; }
        void Save();
    }
}
