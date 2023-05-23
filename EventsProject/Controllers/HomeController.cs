using EventsProject.Models;
using EventsProject.Models.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            return View();
        }

        public ActionResult CreateEvent()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult Event_Informations(string nameOfEvent)
        {
            Event eventInfo = EventsProject.Controllers.EventController.eventsList.FirstOrDefault(e => e.EventName == nameOfEvent);
            if (eventInfo != null)
            {
                return View(eventInfo);
            }
            return RedirectToAction("Events", "Home");
        }

        [HttpGet]
        public ActionResult EventModified(string nameOfEvent)
        {
            Event newEvent = new Event();
            using (DatabaseContext db = new DatabaseContext())
            {
                newEvent = db.Events.FirstOrDefault(e => e.EventName == nameOfEvent);
            }
            return View(newEvent);
        }
        public ActionResult Shopping_cart()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Events()
        {
            List<Event> listOfEventsFromDB;
            using (DatabaseContext db = new DatabaseContext())
            {
                listOfEventsFromDB = db.Events.ToList();
                EventsProject.Controllers.EventController.eventsList = listOfEventsFromDB;
            }
            return View();
        }
    }
}