using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CIT280App.Models;
using CIT280App.DAL;
using System.Data.Entity;

namespace CIT280App.Controllers
{
    public class AdminController : Controller
    {
        private XyphosContext db = new XyphosContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AdminDashboard() 
        {
            return View();
        }
        public ActionResult AllUsers()
        {
            var employers = db.Employers.ToList();
            var students = db.Students.ToList();
            var users =new List<UserModel>(employers).Concat(students);
            return View(users);
            

        }
    }
}