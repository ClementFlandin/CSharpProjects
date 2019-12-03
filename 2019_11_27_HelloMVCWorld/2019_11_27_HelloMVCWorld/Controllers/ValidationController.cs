using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2019_11_27_HelloMVCWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2019_11_27_HelloMVCWorld.Controllers
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