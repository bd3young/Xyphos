using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIT280App.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult StudentDashboard() 
        //{
        //    return View();
        //}

        public ActionResult StudentList() 
        {
            return View();
        }

        public ActionResult StudentProfile() 
        {
            return View();
        }
    }
}