using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommercePortFolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Type = 0;
            return View();
        }

        public ActionResult IndexV2()
        {
            ViewBag.Type = 1;
            return View();
        }

        public ActionResult IndexV3()
        {
            ViewBag.Type = 2;
            return View();
        }

        public ActionResult Shop()
        {
            ViewBag.Type = 0;
            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Type = 0;
            return View();
        }

        public ActionResult Cart()
        {
            ViewBag.Type = 0;
            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Type = 0;
            return View();
        }

        public ActionResult BlogDetails()
        {
            ViewBag.Type = 0;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Type = 0;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.Type = 0;
            return View();
        }
    }
}