using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Lab01a()
        {
            return View();
        }
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

        public ActionResult BT1_Lab01b()
        {
            return View();
        }
        public ActionResult BT2_Lab01b()
        {
            return View();
        }

        public ActionResult BT3_Lab01b()
        {
            return View();
        }

        public ActionResult BT4_Lab01b()
        {
            return View();
        }

        public ActionResult BT5_Lab01b()
        {
            return View();
        }

        public ActionResult BT1_Lab01b2()
        {
            return View();
        }

        public ActionResult BT2_Lab01b2()
        {
            return View();
        }
        public ActionResult BT3_Lab01b2()
        {
            return View();
        }

        public ActionResult BT4_Lab01b2()
        {
            return View();
        }
    }
}