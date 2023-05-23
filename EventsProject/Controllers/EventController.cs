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
    public class EventController : Controller
    {
        /// <summary>
        /// Displays the index view.
        /// </summary>
        /// <returns>The index view</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Static list containing events
        /// </summary>
        public static List<Event> eventsList = new List<Event>() { };


        /// <summary>
        /// Creates a new event and saves it to the database. Then adds it to the eventList.
        /// Finally, redirects the user to the Events view.
        /// </summary>
        /// <param name="model">The event model</param>
        /// <returns>The Events view</returns>
        [HttpPost]
        public ActionResult Create(Event model)
        {
            if (ModelState.IsValid)
            {
                Event newEvent = new Event(
                    model.EventName,
                    model.EventDate,
                    model.EventPlace,
                    model.EventDescription,
                    model.EventPriceNormal,
                    model.EventPriceReduced,
                    model.EventCategory,
                    model.EventAvailableSeats,
                    model.EventStartTime,
                    model.EventTargetAudience,
                    model.ImgSrc
                );
                using(DatabaseContext db= new DatabaseContext())
                {
                    db.Events.Add(newEvent);
                    db.SaveChanges();
                }
                eventsList.Add(newEvent);
                return RedirectToAction("Events", "Home"); // Przekierowanie do innej akcji po utworzeniu obiektu Event
            }
            ViewBag.Message = "Event nie został utworzony";
            return RedirectToAction("Events", "Home");
        }

        /// <summary>
        /// Removes an event from the database. Then redirects the user to the Events view.
        /// </summary>
        /// <param name="nameOfEvent">The name of the event</param>
        /// <returns>The Events view</returns>
        [HttpGet]
        public ActionResult Remove(string nameOfEvent)
        {
            Event eventInfo = EventsProject.Controllers.EventController.eventsList.FirstOrDefault(e => e.EventName == nameOfEvent);
            if (eventInfo != null)
            {
                using(DatabaseContext db = new DatabaseContext())
                {
                    db.Events.Attach(eventInfo);
                    db.Events.Remove(eventInfo);
                    db.SaveChanges();
                }
                return RedirectToAction("Events", "Home");
            }
            return View();         
        }


        /// <summary>
        /// Modifies an existing event in the database. Then redirects the user to the Events view.
        /// </summary>
        /// <param name="model">The event model</param>
        /// <returns>The Events view</returns>
        [HttpPost]
        public ActionResult EventModified(Event model)
        {

            if (!ModelState.IsValid)
            {
                return RedirectToAction("Events", "Home");
            }
            using (DatabaseContext db = new DatabaseContext())
            {
                Event existingEvent = db.Events.FirstOrDefault(ev => ev.EventName == model.EventName);
                if (existingEvent != null)
                {
                    existingEvent.EventName = model.EventName;
                    existingEvent.EventDate = model.EventDate;
                    existingEvent.EventPlace = model.EventPlace;
                    existingEvent.EventDescription = model.EventDescription;
                    existingEvent.EventPriceNormal = model.EventPriceNormal;
                    existingEvent.EventPriceReduced = model.EventPriceReduced;
                    existingEvent.EventCategory = model.EventCategory;
                    existingEvent.EventAvailableSeats = model.EventAvailableSeats;
                    existingEvent.EventStartTime = model.EventStartTime;
                    existingEvent.EventTargetAudience = model.EventTargetAudience;
                    existingEvent.ImgSrc = model.ImgSrc;
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Events", "Home");
        }
    }
    

}