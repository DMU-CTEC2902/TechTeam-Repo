using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using FilmMVC.Controllers;
using FilmMVC.Models;
  

namespace FilmMVC.Tests.Controllers
{
    [TestClass]
    public class WebsiteControllerTest
    {
        [TestMethod]
        public void IndexWelcomeMessage()
        {
            //Arrange

            WebsiteController controller = new WebsiteController();

            //Act

            ViewResult result = controller.Index();

            //Assert

            Assert.AreEqual("Welcome to the website. Have fun browsing films!", controller.ViewBag.WelcomeMessage);
        }

        [TestMethod]
        
        public void FilmTitle()
        {
            //Arrange

            WebsiteController controller = new WebsiteController();

            //Act

            ViewResult viewResult = controller.Film();
            FilmModel result = viewResult.Model as FilmModel;

            //Assert

            Assert.AreEqual("Transformers", result.Title);

        }
    }
}
