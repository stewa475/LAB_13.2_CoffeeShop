using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LAB_11._2_CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAB_11._2_CoffeeShop.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View("RegistrationIndex");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegistrationConfirmation(MemberRegistration member)
        {
            if (ModelState.IsValid)
            {
                return View(member);
            }
            else
            {
                ViewData["errorMsg"] = "Your form had errors. Please correct and re-submit.";
                return View("RegistrationIndex", member);
            }
        }
    }
}