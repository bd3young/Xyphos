using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIT280App.Controllers
{
    public class EmployerController : Controller
    {
        // GET: Employer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EmployerDashboard() 
        {
            return View();
        }
        public ActionResult EmployerList()
        {
            return View();
        }
        public ActionResult EmployerProfile()
        {
            return View();
        }
    }
}