﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _2019_11_27_HelloMVCWorld.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return Content("Product overview");
        }
        
        public IActionResult List()
        {
            return Content("Product list");
        }
        public IActionResult Details(int id)
        {
            return Content("Product details for # " + id);
        }
    }
}