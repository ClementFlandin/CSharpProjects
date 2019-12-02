using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return View("Error");
            }
            else
            {
                ViewData["Nom"] = id;
                return View();
            }
        }

        public ActionResult ListeClients()
        {
            Clients clients = new Clients();
            ViewBag.Clients = clients.GetClients();
            return View();
        }

        public ActionResult ChercheClient(string id)
        {
            ViewBag.Nom = id;
            Clients clients = new Clients();
            Client client = clients.GetClients().FirstOrDefault(c => c.Nom == id);
            if (client != null)
            {
                ViewBag.Age = client.Age;
                return View("Trouve");
            }
            return View("NonTrouve");
        }
        //public string Index2()
        //{
        //    return "Salut les contrôleurs!";
        //}
    }
}