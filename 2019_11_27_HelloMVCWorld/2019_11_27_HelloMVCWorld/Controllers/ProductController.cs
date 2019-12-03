using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _2019_11_27_HelloMVCWorld.Controllers
{
    [Route("/products")]
    public class ProductController : Controller
    {

        public IActionResult Index()
        {
            return Content("Product overview");
        }
        [Route("{id}")]
        public IActionResult Details (int id)
        {
            return Content("Product # " + id);
        }
    }
}