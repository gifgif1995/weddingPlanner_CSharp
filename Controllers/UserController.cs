
using System;
using System.Linq;
using Newtonsoft.Json;
using System.Diagnostics;
using WeddingPlanner.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace WeddingPlanner.Controllers
{
    public class UserController: Controller
    {
        public int? LiveUser
        {
            get {return HttpContext.Session.GetInt32("UserID");}
            set {HttpContext.Session.SetInt32("UserID", (int)value);}
        }
        private DatabaseContext database;
        public UserController(DatabaseContext context)
        {
            database = context;
        }
        [Route("")]
        public IActionResult UserIndex()
        {
            HttpContext.Session.Clear();
            return View();
        }
        [HttpPost("registering")]
        public IActionResult Register(UserIndexView individual)
        {
            if (ModelState.IsValid)
            {
                if (database.Users.Any(u => u.Email == individual.UserNew.Email))
                {
                    ModelState.AddModelError("UserNew.Email", "Email already in use... sorry");
                    Console.WriteLine("###### BAD EMAIL");
                    return View("UserIndex", individual);
                }
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                string hashedPW = hasher
                    .HashPassword(individual.UserNew, individual.UserNew.Password);
                individual.UserNew.Password = hashedPW;
                database.Add(individual.UserNew);
                database.SaveChanges();
                LiveUser = individual.UserNew.UserId;
                return RedirectToAction("Success");
            }
            return View("UserIndex", individual);
        } 

        [HttpPost("entering")]
        public IActionResult Login(UserIndexView individual)
        {
            if (ModelState.IsValid)
            {
                User UserInDb = database.Users
                    .FirstOrDefault(u => u.Email == individual.UserExist.Email);
                if (UserInDb == null)
                {
                    ModelState.AddModelError("UserExist.Email", "Email does not exist");
                    return View("UserIndex", individual);
                }
                PasswordHasher<LogUser> hasher = new PasswordHasher<LogUser>();
                var result = hasher.VerifyHashedPassword(
                    individual.UserExist, UserInDb.Password, individual.UserExist.Password
                );
                if (result == 0)
                {
                    ModelState.AddModelError("UserExist.Password", "Password does not exist");
                    return View("UserIndex", individual);
                }
                LiveUser = UserInDb.UserId;
                return RedirectToAction("Success");
            }
            return View("UserIndex");
        } 

        // SUCCESS ACTION
        [Route("success")]
        public IActionResult Success()
        {
            if (LiveUser != null)
            {
                return RedirectToAction("Dashboard", "Wedding");
            }
            return RedirectToAction("UserIndex", LiveUser);
        }
        // LOGOUT
        [Route("exiting")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("UserIndex");
        }
    }
}