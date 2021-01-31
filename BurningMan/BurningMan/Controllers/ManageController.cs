using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurningMan.Interfaces;
using BurningMan.Models;
using BurningMan.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BurningMan.Controllers
{
    public class ManageController : Controller
    {
        private IRepository<Order> db;


        public ManageController(ApplicationContext context)
        {
            db = new OrderRepository(context);
        }

        public IActionResult OrderHistory()
        {
            var model = db.GetAll().ToList();

            //TempData["OrdersList"] = order.GetAll().ToList();
            //TempData["UserList"] = user.GetAll().ToList();
            return View(model);
        }
    }
}
