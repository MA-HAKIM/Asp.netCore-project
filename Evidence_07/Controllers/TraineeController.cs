using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Evidence_07.Models;
using Evidence_07.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Evidence_07.Controllers
{
    [Authorize]
    public class TraineeController : Controller
    {
        private readonly TraineeCourseDbContext db;
        private readonly IHostingEnvironment env;
        public TraineeController(TraineeCourseDbContext db, IHostingEnvironment env) { this.db = db; this.env = env; }
        public IActionResult Index()
        {
            return View(db.Trainees.Include(x => x.Course).ToList());
        }
        public IActionResult Create()
        {
            ViewBag.CourseList = db.Courses.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(TraineeViewModel t)
        {
            if (ModelState.IsValid)
            {
                Trainee e = new Trainee { TraineeName = t.TraineeName, Email = t.Email, TLocation = t.TLocation, Picture = "no-pic.png", CourseId=t.CourseId };
                if (t.Picture != null)
                {
                    var imagePath = env.WebRootPath + @"\uploads";

                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(t.Picture.FileName);
                    FileStream fs = new FileStream(Path.Combine(imagePath, fileName), FileMode.Create);
                    t.Picture.CopyTo(fs);
                    fs.Flush();
                    fs.Close();
                    e.Picture = fileName;
                }
                db.Trainees.Add(e);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(t);
        }
        public IActionResult Edit(int id)
        {
            var e = db.Trainees.First(x => x.TraineeId == id);
            ViewBag.picture = e.Picture;
            ViewBag.CourseList = db.Courses.ToList();
            return View(new TraineeViewModel
            {
                TraineeId = e.TraineeId,
                TraineeName = e.TraineeName,
                Email = e.Email,
                TLocation = e.TLocation,
                CourseId = e.CourseId
            });
        }
        [HttpPost]
        public IActionResult Edit(TraineeViewModel t)
        {
            if (ModelState.IsValid)
            {
                var tr = db.Trainees.First(x => x.TraineeId == t.TraineeId);
                tr.Email = t.Email;
                tr.TraineeName = t.TraineeName;
                tr.TLocation = t.TLocation;
                tr.CourseId = t.CourseId;
                if (t.Picture != null)
                {
                    var imagePath = env.WebRootPath + @"\uploads";
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(t.Picture.FileName);
                    FileStream fs = new FileStream(Path.Combine(imagePath, fileName), FileMode.Create);
                    t.Picture.CopyTo(fs);
                    fs.Flush();
                    fs.Close();
                    tr.Picture = fileName;
                }
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            ViewBag.CourseList = db.Courses.ToList();
            return View(t);
        }
        public IActionResult Delete(int id)
        {
            return View(db.Trainees.Include(x => x.Course).First(x => x.TraineeId == id));
        }
        [ActionName("Delete"), HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            Trainee t = new Trainee { TraineeId = id };
            db.Entry(t).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}