using MvcDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoLibrary;
using static DemoLibrary.Logic.EmployeeProcessor;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SignUp()
        {
            ViewBag.Message = "Employee Sign Up";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(EmployeeDetails model)
        {
            if (ModelState.IsValid)
            {
              int track=  CreateEmplpyee(model.EmployeeId, model.FirstName, model.LastName, model.EmailAdress, model.ConfirmEmail, model.Password, model.ConfirmPassword);
                 return RedirectToAction("Index"); 
            }

            return View();
        }
    }
}