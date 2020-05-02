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
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers
{
    public class WeddingController: Controller
    {
        public int? LiveUser
        {
            get {return HttpContext.Session.GetInt32("UserID");}
            set {HttpContext.Session.SetInt32("UserID", (int)value);}
        }
        private DatabaseContext database;

        public WeddingController(DatabaseContext context)
        {

            database = context;
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if (LiveUser == null)
            {
                return RedirectToAction("UserIndex", "User");
            }
            User liveUser = database.Users
                .Include(u => u.Weddings)
                .FirstOrDefault(u => u.UserId == LiveUser);
            List<Wedding> allWeddings = database.Weddings
                .Include(w => w.Planner)
                .Include(w => w.Guests)
                .ToList();
            ViewBag.LiveUser = liveUser;
            return View(allWeddings);
        }

        [HttpGet("wedding")]
        public IActionResult NewWedding()
        {
            if (LiveUser == null)
            {
                return RedirectToAction("UserIndex", "User");
            }
            ViewBag.LiveUser = LiveUser;
            return View();
        }

        [HttpGet("wedding/{wedId:int}")]
        public IActionResult ViewWedding(int wedId)
        {
            if (LiveUser == null)
            {
                return RedirectToAction("UserIndex", "User");
            }
            Wedding target = database.Weddings
                .Include(w => w.Guests)
                .ThenInclude(g => g.Guest)
                .FirstOrDefault(w => w.WeddingId == wedId);
            return View(target);
        }

        [HttpPost("create")]
        public IActionResult Creator(Wedding newWed)
        {
            if (LiveUser == null)
            {
                return RedirectToAction("UserIndex", "User");
            }
            if(ModelState.IsValid)
            {
                database.Add(newWed);
                database.SaveChanges();
                return RedirectToAction("ViewWedding", new{wedId=newWed.WeddingId});
            }
            else
            {
                return RedirectToAction("NewWedding");
            }
            
        }

        [HttpGet("accept/{wedId:int}")]
        public IActionResult Accept(int wedId)
        {
            if (LiveUser == null)
            {
                return RedirectToAction("UserIndex", "User");
            }
            Wedding target = database.Weddings
                .FirstOrDefault(w => w.WeddingId == wedId);
            Relation acceptance = new Relation();
            acceptance.WeddingId = target.WeddingId;
            acceptance.UserId = (int)LiveUser;
            target.UpdatedAt = DateTime.Now;
            database.Add(acceptance);
            database.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("leaving/{wedId:int}")]
        public IActionResult Leave(int wedId)
        {
            if (LiveUser == null)
            {
                return RedirectToAction("UserIndex", "User");
            }
            Relation target = database.Relations
                .FirstOrDefault(r => r.WeddingId == wedId && r.UserId == LiveUser);
            database.Relations.Remove(target);
            database.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("delete/{wedId:int}")]
        public IActionResult Destroyer(int wedId)
        {
            if (LiveUser == null)
            {
                return RedirectToAction("UserIndex", "User");
            }
            Wedding target = database.Weddings
                .FirstOrDefault(w => w.WeddingId == wedId);
            database.Remove(target);
            database.SaveChanges();
            return RedirectToAction("Dashboard");
        }
    }
}