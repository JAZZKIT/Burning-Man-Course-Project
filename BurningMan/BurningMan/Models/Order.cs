using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurningMan.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime OrderDateTime { get; set; }
        public  int Quantity { get; set; }


        //Maybe collection of tickets 
        //public int TicketId { get; set; }
        //public Ticket Ticket { get; set; }

        public string UserId { get; set; }
    }
}
