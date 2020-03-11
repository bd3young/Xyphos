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
    public class EmployerModelController : Controller
    {
        private XyphosContext db = new XyphosContext();

        // GET: EmployerModel
        public ActionResult Index()
        {
            return View(db.Employers.ToList());
        }

        // GET: EmployerModel/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployerModel employerModel = db.Employers.Find(id);
            if (employerModel == null)
            {
                return HttpNotFound();
            }
            return View(employerModel);
        }

        // GET: EmployerModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployerModel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,BuisnessName,BuisnessType,Role,FirstName,LastName,City,State,Description,Email,Phone,ProfilePic,Reviews")] EmployerModel employerModel)
        {
            if (ModelState.IsValid)
            {
                db.Employers.Add(employerModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employerModel);
        }

        // GET: EmployerModel/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployerModel employerModel = db.Employers.Find(id);
            if (employerModel == null)
            {
                return HttpNotFound();
            }
            return View(employerModel);
        }

        // POST: EmployerModel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,BuisnessName,BuisnessType,Role,FirstName,LastName,City,State,Description,Email,Phone,ProfilePic,Reviews")] EmployerModel employerModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employerModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employerModel);
        }

        // GET: EmployerModel/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployerModel employerModel = db.Employers.Find(id);
            if (employerModel == null)
            {
                return HttpNotFound();
            }
            return View(employerModel);
        }

        // POST: EmployerModel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            EmployerModel employerModel = db.Employers.Find(id);
            db.Employers.Remove(employerModel);
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
