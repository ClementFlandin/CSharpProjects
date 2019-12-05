using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2019_12_04_ASP.NET_ModelValidation_Test.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2019_12_04_ASP.NET_ModelValidation_Test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(WebUser webUser)
        {
            return View(webUser);
        }

    }
}