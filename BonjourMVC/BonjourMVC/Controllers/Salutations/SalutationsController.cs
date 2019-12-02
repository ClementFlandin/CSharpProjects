using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BonjourMVC.Models;

namespace BonjourMVC.Controllers.Salutations
{
    public class SalutationsController : Controller
    {
        // GET: Salutations
        public ActionResult Index()
        {
            Visiteur client = new Visiteur();
            return View(client);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(Visiteur visiteur)
        {
            Visiteur client = new Visiteur();
            String prenom = "";

            prenom = Request.Form["prenom_visiteur"];
            client.Prenom = prenom;
            ViewData["message"] = "Bienvenue à toi, " + prenom;
            return View("Index", client);
        }
    }
}