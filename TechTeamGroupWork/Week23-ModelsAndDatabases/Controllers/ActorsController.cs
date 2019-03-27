using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FilmReview.Models;

namespace FilmReview.Controllers
{
    public class ActorsController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Actors
        public ActionResult Index()
        {
            
            var actors = db.Actors.Include(p=>p.Movies);
            return View(actors.ToList());

        }

        // GET: Actors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Actor actor = db.Actors.Find(id);
            if (actor == null)
            {
                return HttpNotFound();
            }

            ViewBag.MovieId = new SelectList(db.Movies, "MovieId", "MovieTitle");
            return View(actor);
        }

        // GET: Actors/Create
        public ActionResult Create()
        {
            if (!Session["userAdmin"].Equals("admin"))
            {
                return RedirectToAction("Login", "Users");
            }

            return View();
        }

        // POST: Actors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ActorId,ActorName,ActorDOB,ActorGender")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                db.Actors.Add(actor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(actor);
        }

        // GET: Actors/Edit/5
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
            Actor actor = db.Actors.Find(id);
            if (actor == null)
            {
                return HttpNotFound();
            }

            return View(actor);
        }

        // POST: Actors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ActorId,ActorName,ActorDOB,ActorGender")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(actor);
        }

        // GET: Actors/Delete/5
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
            Actor actor = db.Actors.Find(id);
            if (actor == null)
            {
                return HttpNotFound();
            }
            return View(actor);
        }

        // POST: Actors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Actor actor = db.Actors.Find(id);
            db.Actors.Remove(actor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AssignMovie([Bind(Include = "ActorId")] Actor actor)
        {
            //
            var movieId = Request["MovieId"];
            var actorId = Request["ActorId"].ToString();

            foreach(Actor ac in db.Actors)
            {
                if(ac.ActorId.ToString() == actorId)
                {
                    var movie = db.Movies.Where(p => p.MovieId.ToString() == movieId).FirstOrDefault();
                    ac.Movies.Add(movie);

                    break;
                }
            }

            db.SaveChanges();

            return RedirectToAction("Details", "Actors", new { id = actorId });
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
