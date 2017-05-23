using gushv3.Context;
using gushv3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace gushv3.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Users account)
        {
            if (ModelState.IsValid)
            {
                using (OurDbContext db = new OurDbContext())
                {
                    db.user.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();

            }
            return RedirectToAction("Login");

        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login (Users user)
        {
            using (OurDbContext db = new OurDbContext())
            {
                var usr = db.user.Where(u => u.username == user.username && u.password == user.password).FirstOrDefault();
                if (usr != null)
                {
                    Session["UserId"] = usr.UserId.ToString();
                    Session["username"] = usr.username.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password is Wrong");
                }
                return View();
            }
        }

        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
            {
                return RedirectToAction("Dashboard", "Dashboard");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }


   
        public ActionResult Back()
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");

        }

        public ActionResult AdminAuthentication()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AdminAuthentication(string authcode)
        {
            if (authcode == "123")
            {
                return View("Register");
            } else
            {
                return RedirectToAction("Back");
            }
         
        }


    }
}