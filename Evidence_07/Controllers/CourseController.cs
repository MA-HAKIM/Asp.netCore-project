using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Evidence_07.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Evidence_07.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private readonly TraineeCourseDbContext db;
        public CourseController(TraineeCourseDbContext db) { this.db = db;}
        public IActionResult Index()
        {
            return View(db.Courses.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Course c)
        {
            Thread.Sleep(1000);
            if (ModelState.IsValid)
            {
                db.Courses.Add(c);
                db.SaveChanges();
                ViewBag.Success = true;
                ViewBag.Message = "Data saved successfully";
                return PartialView("_AjaxPartial");
            }

            ViewBag.Success = false;
            ViewBag.Message = "Failed to save data";
            return PartialView("_AjaxPartial");
        }
        public IActionResult Edit(int id)
        {
            return View(db.Courses.First(x => x.CourseId == id));
        }
        [HttpPost]
        public IActionResult Edit(Course ct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ct).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ct);
        }
        public IActionResult Delete(int id)
        {
            return View(db.Courses.Include(x=>x.Trainees).First(x => x.CourseId == id));
        }
        [ActionName("Delete"), HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            Course c = new Course { CourseId = id };
            db.Entry(c).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}