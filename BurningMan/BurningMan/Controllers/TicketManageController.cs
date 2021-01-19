using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BurningMan.Controllers
{
    public class TicketManageController : Controller
    {
        
        public IActionResult TicketMainPage()
        {
            return View();
        }
    }
}
