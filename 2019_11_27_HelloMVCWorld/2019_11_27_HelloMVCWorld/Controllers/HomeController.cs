using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2019_11_27_HelloMVCWorld.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _2019_11_27_HelloMVCWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(int id)
        {
            //Product product = new Product()
            //{
            //    Title = "Toilet paper",
            //    Price = 1.99
            //};
            //return View(product);

            ViewBag.ProductTitle = "Toilet paper";
            ViewBag.ProductPrice = 1.99;
            return View();
        }
        public IActionResult Movies()
        {
            Movie movie = new Movie()
            {
                Title = "The Godfather",
                ReleaseDate = DateTime.Now
            };
            return View(movie);
        }
        //Routing template with catch-all parameter

        //[Route("blog/{entryId}/{*slug}")]
        //public IActionResult Blog(int entryId, string slug)
        //{
        //    return Content($"Blog entry with id #{entryId} requested (URL slug : {slug})");
        //}

        //Routing template with optional parameter

        [Route("blog/{entryId}/{slug?}")]
        public IActionResult Blog(int entryId, string slug)
        {
            if (slug == null)
            {
                return Content(String.Format("Blog entry with id #" + entryId));
            }
            else
            {
                return Content(String.Format($"Blog entry with id #{entryId} requested (URL slug : {slug})"));
            }
        }
    }
}
