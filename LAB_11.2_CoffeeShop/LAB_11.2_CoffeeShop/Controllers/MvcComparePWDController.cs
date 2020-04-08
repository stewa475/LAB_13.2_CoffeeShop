using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LAB_11._2_CoffeeShop.Controllers
{
    public class MvcComparePWDController : Controller
    {
        public IActionResult PasswordIndex()
        {
            return View();
        }
    }
}