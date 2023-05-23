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
        // <summary>
        /// Displays the index view.
        /// </summary>
        /// <returns>The index view</returns>
        [HttpGet]
        public ActionResult Index()
        {
            List<Event> listOfEventsFromDB;
            using (DatabaseContext db = new DatabaseContext())
            {
                listOfEventsFromDB = db.Events.ToList();
                EventsProject.Controllers.EventController.eventsList = listOfEventsFromDB;
            }
            return View();
        }
        /// <summary>
        /// Displays the about view.
        /// </summary>
        /// <returns>The about view</returns>
        public ActionResult About()
        {
            return View();
        }
        /// <summary>
        /// Displays the create event view.
        /// </summary>
        /// <returns>The create event view</returns>
        public ActionResult CreateEvent()
        {
            return View();
        }
        /// <summary>
        /// Displays the profile view.
        /// </summary>
        /// <returns>The profile view</returns>
        public ActionResult Profile()
        {
            return View();
        }

        /// <summary>
        /// Displays the event information view for a specific event.
        /// </summary>
        /// <param name="nameOfEvent">The name of the event</param>
        /// <returns>The event information view</returns>
        public ActionResult Event_Informations(string nameOfEvent)
        {
            Event eventInfo = EventsProject.Controllers.EventController.eventsList.FirstOrDefault(e => e.EventName == nameOfEvent);
            if (eventInfo != null)
            {
                return View(eventInfo);
            }
            return RedirectToAction("Events", "Home");
        }

        /// <summary>
        /// Displays the event modification view for a specific event.
        /// </summary>
        /// <param name="nameOfEvent">The name of the event</param>
        /// <returns>The event modification view</returns>
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

        /// <summary>
        /// Displays the shopping cart view.
        /// </summary>
        /// <returns>The shopping cart view</returns>
        public ActionResult Shopping_cart()
        {
            return View();
        }

        /// <summary>
        /// Displays the events view and fetches the list of events from the database.
        /// </summary>
        /// <returns>The events view</returns>
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