﻿using System;
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
        private IRepository<Order> db;

        public IActionResult TicketMainPage()
        {
            return View();
        }

        public TicketManageController(UserManager<User> userManager, ApplicationContext context)
        {
            _userManager = userManager;
            db = new OrderRepository(context);
        }


        [HttpPost]
        public string BdTest(string price, string qt)
        {
            Order Ord = new Order
            {
                Quantity = Convert.ToInt32(qt),
                Amount = Convert.ToDecimal(price),
                OrderDateTime = DateTime.Now,
                TicketId = 1, 
                UserId = GetCurrentUserIdAsync()
                


            };
            db.Create(Ord);
            db.Save();
            return qt;
        }
    }
}
