using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM.Controllers
{
    public class HomeController : Controller
    {
        //GET home/Index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Foo()
        {
            return View("About");
        }

        //GET home/About
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Send your details:";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string firstname, string age)
        {
            ViewBag.Message = $"Details received! Thanks {firstname}!";
            return View();
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVCATM1";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }

            else
            {
                return Content(serial);
            }
        }
        [Route("Home/AgeCalc/")]
        public ActionResult AgeCalc(string age)
        {
            if (Convert.ToInt32(age) < 18)
            {
                return Content("You are too young to access this.");
            }

            else
            {
                return Json(new { name = "Kay", myage = age }, JsonRequestBehavior.AllowGet );
            }
        }
    }
}