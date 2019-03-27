using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FilmReview.Models;

namespace FilmReview.Controllers
{
    public class MoviesController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Movies
        public ActionResult Index()
        {

            var movies = db.Movies.Include(p => p.Director);
            ViewBag.GenraId = new SelectList(db.Genras, "GenraId", "GenraType");
            return View(movies.ToList());

        }

        // GET: Movies/Details/5
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        public ViewResult Details()
        {
            throw new NotImplementedException();
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            if (!Session["userAdmin"].Equals("admin"))
            {
                return RedirectToAction("Login", "Users");
            }

            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "DirectorName");
            ViewBag.GenraId = new SelectList(db.Genras, "GenraId", "GenraType");
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MovieId,DirectorId,MovieTitle,MovieImage,Description, MovieYear")] Movie movie, HttpPostedFileBase MovieImage)
        {
           
            if (ModelState.IsValid)
            {
                var fileName = "";
                if (MovieImage != null)
                {
                    fileName = Path.GetFileName(MovieImage.FileName);
                    var path = Path.Combine(Server.MapPath(@"\images"), fileName);
                    MovieImage.SaveAs(path);
                }
                else
                {
                    fileName = "default.jpg";
                }
                movie.MovieImage = fileName;
               
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GenraId = new SelectList(db.Genras, "GenraId", "GenraType", movie.Genra.GenraId);
            return View(movie);
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (!Session["userAdmin"].Equals("admin"))
            {
                return RedirectToAction("Login", "Users");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }


            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "DirectorName", movie.Director);
            ViewBag.GenraId = new SelectList(db.Genras, "GenraId", "GenraType", movie.Genra);
            return View(movie);
        }

        // POST: Movies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MovieId,DirectorId,MovieTitle,MovieImage,Description,MovieYear")] Movie movie, HttpPostedFileBase Image)
        {
            if (ModelState.IsValid)
            {
                var fileName = "";
                if (Image != null)
                {
                    fileName = Path.GetFileName(Image.FileName);
                    var path = Path.Combine(Server.MapPath(@"\images"), fileName);
                    Image.SaveAs(path);
                }
                else
                {
                    var img = Request["MovieImage"];
                    fileName = img;
                    
                }
                movie.MovieImage = fileName;
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DirectorId = new SelectList(db.Directors, "DirectorId", "DirectorName", movie.Director);
            ViewBag.GenraId = new SelectList(db.Genras, "GenraId", "GenraType", movie.Genra);
            return View(movie);
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (!Session["userAdmin"].Equals("admin"))
            {
                return RedirectToAction("Login", "Users");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var movie = db.Movies.Where(p => p.MovieId == id).FirstOrDefault();

            db.Movies.Remove(movie);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddReview([Bind(Include = "MovieId")] Movie movie)
        {
            string userName = Session["userName"].ToString();
            var reviewDesp = Request["reviewDesciption"];
            var reviewDate = DateTime.Now;

            Review review = new Review();
            review.ReviewId = 0;
            review.ReviewUser = userName;
            review.ReviewTime = reviewDate;
            review.Description = reviewDesp;
            review.MovieId = movie.MovieId;

            foreach(Movie m in db.Movies)
            {
                if(m.MovieId == movie.MovieId)
                {

                    m.Reviews.Add(review);
                }
            }

            db.SaveChanges();

            return RedirectToAction("Details", "Movies", new { id = movie.MovieId });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Search()
        {
            ViewBag.GenraId = new SelectList(db.Genras, "GenraId", "GenraType");
            var genra = Request["GenraId"];
            var g = db.Movies.Where(p => p.Genra.GenraId.ToString() == genra);

            return View("Index", g.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
