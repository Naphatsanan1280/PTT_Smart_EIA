﻿using System.Web.Mvc;

namespace PTT_Smart_EIA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Homepage()
        {
            return View();
        }
        public ActionResult Screening()
        {
            return View();
        }

        public ActionResult Regulatory()
        {
            return View();
        }
        public ActionResult Gis()
        {
            return View();
        }

        public ActionResult CalculateArea()
        {
            return View();
        }



    }
}