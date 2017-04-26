using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Items()
        {
            ViewBag.Message = "These are items!";
            return View();
        }

        public ActionResult Success(RegisterModel r)
        {                     
            ViewBag.Message = " Your first name is " + r.FirstName + " and your email address is " + r.EmailAddress;
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My name is Pete Rossman, and I'm currently a student in Grand Circus' .NET(C#) Bootcamp in Grand Rapids.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This Coffee Shop is a project made by Pete Rossman for Grand Circus' .NET(C#) Bootcamp.";
            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Register with GC Coffee";
            return View();
        }
    }
}