using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CIT280App.DAL;
using CIT280App.Models;

namespace CIT280App.Controllers
{
    [Authorize]
    public class AdminController : Controller
    
    {
        private XyphosContext db = new XyphosContext();

        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Admins.ToList());
        }
        public ActionResult AdminDashboard()
        {
            return View();
        }

        public ActionResult CreateUserDashboard()
        {
            return View();
        }
        public ActionResult AllUsers()
        {
            var employers = db.Employers.ToList();
            var students = db.Students.ToList();
            var admins = db.Admins.ToList();
            var users = new List<UserModel>(employers).Concat(students).Concat(admins).ToList();
            return View(users);
        }

        public ActionResult AllJobs() 
        {
            var jobs = db.Jobs.Include(j => j.User);
            return View(jobs.ToList());
        }

        // GET: JobsModel/Details/5
        public ActionResult JobDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobsModel jobsModel = db.Jobs.Find(id);
            if (jobsModel == null)
            {
                return HttpNotFound();
            }
            return View(jobsModel);
        }

        // GET: Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserModel userModel = db.Admins.Find(id);
            if (userModel == null)
            {
                return HttpNotFound();
            }
            return View(userModel);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Role,FirstName,LastName,City,State,Description,Email,Phone,ProfilePic,Reviews")] UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                userModel.Role = UserRole.Admin;
                db.Admins.Add(userModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userModel);
        }

        // GET: JobsModel/Edit/5
        public ActionResult JobEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobsModel jobsModel = db.Jobs.Find(id);
            if (jobsModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserID = new SelectList(db.Admins, "ID", "FirstName", jobsModel.UserID);
            return View(jobsModel);
        }

        // POST: JobsModel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult JobEdit([Bind(Include = "ID,UserID,Name,Description,City,State,RequiredSkills,Photo,Pay,IsComplete")] JobsModel jobsModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobsModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("AllJobs");
            }
            ViewBag.UserID = new SelectList(db.Admins, "ID", "FirstName", jobsModel.UserID);
            return View(jobsModel);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserModel userModel = db.Admins.Find(id);
            if (userModel == null)
            {
                return HttpNotFound();
            }
            return View(userModel);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Role,FirstName,LastName,City,State,Description,Email,Phone,ProfilePic,Reviews")] UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userModel);
        }


        // GET: JobsModel/Delete/5
        public ActionResult JobDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobsModel jobsModel = db.Jobs.Find(id);
            if (jobsModel == null)
            {
                return HttpNotFound();
            }
            return View(jobsModel);
        }

        // POST: JobsModel/Delete/5
        [HttpPost, ActionName("JobDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult JobDeleteConfirmed(int id)
        {
            JobsModel jobsModel = db.Jobs.Find(id);
            db.Jobs.Remove(jobsModel);
            db.SaveChanges();
            return RedirectToAction("AllJobs");
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserModel userModel = db.Admins.Find(id);
            if (userModel == null)
            {
                return HttpNotFound();
            }
            return View(userModel);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserModel userModel = db.Admins.Find(id);
            db.Admins.Remove(userModel);
            db.SaveChanges();
            return RedirectToAction("Index");
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
