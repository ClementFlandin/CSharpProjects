using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _2019_12_04_ASP.NET_ModelValidation_Test.Models;

namespace _2019_12_04_ASP.NET_ModelValidation_Test.Controllers
{
    public class ValidationController : Controller
    {
        [HttpGet]
        public IActionResult SimpleValidation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SimpleValidation(WebUser webUser)
        {
            if (ModelState.IsValid)
            {
                return Content("Thank you!");
            }
            else
            {
                return View(webUser);
            }
        }
    }
}