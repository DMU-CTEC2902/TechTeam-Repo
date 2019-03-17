using FilmMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilmMVC.Controllers
{
    public class WebsiteController : Controller
    {
        // GET: Webiste
        public ViewResult Index()
        {
            //code for Index Action Methos
            ViewBag.Title = "The Film Website";
            ViewBag.WelcomeMessage = "Welcome to the website. Have fun browsing films!";
            ViewData["CurrentTime"] = DateTime.Now;
            return View();
        }

        public ViewResult Film()
        {
            FilmModel filmModel = new FilmModel();
            filmModel.Title = "Transformers";
            filmModel.Description = "Autobots with the help of a teenager battle Decepticons for an acient object on Earth.";
            filmModel.Year = 2007;

            return View(filmModel);
        }

        public RedirectResult Movie()
        {
            return RedirectPermanent("~/Website/Film");
        }
    }


   
}