using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurningMan.Interfaces;
using BurningMan.Models;
using BurningMan.Repositories;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Identity;


namespace BurningMan.Controllers
{
    public class TicketManageController : Controller
    {
        private readonly UserManager<User> _userManager;
        private string GetCurrentUserIdAsync() => _userManager.GetUserId(HttpContext.User);
        private IRepository<Order> db =  new OrderRepository();
        public IActionResult TicketMainPage()
        {
            return View();
        }

        public TicketManageController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }


        [HttpPost]
        public string BdTest(string price, string qt)
        {
            Order Ord = new Order
            {
                Quantity = Convert.ToInt32(qt),
                Amount = Convert.ToDecimal(price),
                OrderDateTime = DateTime.Now,
                //Ticket = new Ticket
                UserId = GetCurrentUserIdAsync()
                


            };
            db.Create(Ord);
            db.Save();
            return qt;
        }
    }
}
