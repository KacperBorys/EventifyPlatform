﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventsProject.Controllers
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

        public ActionResult Events()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult CreateEvent()
        {
            return View();
        }
        public ActionResult Event_Informations() 
        {
            return View();
        }
    }
}