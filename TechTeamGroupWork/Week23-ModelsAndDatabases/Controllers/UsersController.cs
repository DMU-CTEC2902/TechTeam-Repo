using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmReview.Models;

namespace FilmReview.Controllers
{
    public class UsersController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Account
        public ActionResult Index()
        {
            if (Session["userId"] != null)
            {
                if (!Session["userAdmin"].Equals("admin"))
                {
                    return RedirectToAction("Login", "Users");
                }
            }

            var users = db.Users;
            return View(users.ToList());
        }

        // GET: Users/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserId,UserName,UserEmail")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: Users/Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {

            var u = db.Users.Where(p => p.Email == user.Email && p.Password == user.Password).FirstOrDefault();

            if (u != null)
            {
                Session["userId"] = u.UserId.ToString();
                Session["userName"] = u.UserName.ToString();
                Session["userAdmin"] = u.Status.ToString();


                return RedirectToAction("Loggedin");
            }
            else
            {
                ModelState.AddModelError("", "Your username or passwordd is invalid");
            }

            return View();
        }

        // GET: Users/Logout
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Loggedin()
        {
            if (Session["userId"] != null)
            {
                return RedirectToAction("Index", "Movies");
            }
            else
            {
                return RedirectToAction("Login", "Users");
            }
        }


    }
}