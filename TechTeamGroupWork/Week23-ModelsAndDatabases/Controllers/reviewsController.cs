using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FilmReview.Models;

namespace FilmReview.Controllers
{
    public class reviewsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Reviews
        public ActionResult Index()
        {
            if (Session["userId"] != null)
            {
                if (!Session["userAdmin"].Equals("admin"))
                {
                    return RedirectToAction("Login", "Users");
                }
            }

            var users = db.Reviews;
            return View(users.ToList());
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review = db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Review review = db.Reviews.Find(id);
            var movieId = review.MovieId;
            db.Reviews.Remove(review);
            db.SaveChanges();

            return RedirectToAction("Details", "Movies", new { id = movieId });
        }


    }
}