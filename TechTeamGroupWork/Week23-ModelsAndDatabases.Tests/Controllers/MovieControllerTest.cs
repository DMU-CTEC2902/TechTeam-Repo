using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilmReview;
using FilmReview.Controllers;
using FilmReview.Models;

namespace FilmReview.Tests.Controllers
{
    [TestClass]
    public class MovieControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            MoviesController movie = new MoviesController();

            // Act
            ViewResult result = movie.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestDetailsView()
        {

            var controller = new MoviesController();
            var result = controller.Details() as ViewResult;
            Assert.AreEqual("Details", result.ViewName);
         }
        [TestMethod]
        public void TestDetailsViewData()
        {
            var controller = new MoviesController();
            var result = controller.Details() as ViewResult;
            var movie = (Movie)result.ViewData.Model;
            Assert.AreEqual("1", movie.MovieId);
        }

        
    }
}
