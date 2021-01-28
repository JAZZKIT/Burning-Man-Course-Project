using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace BurningMan.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Camp { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
