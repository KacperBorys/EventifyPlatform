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
        public ActionResult Index()
        {
            return View();
        }

        public static List<Event> eventsList = new List<Event>() { };

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
                //_context.Events.Add(newEvent);
                //_context.SaveChanges();
                eventsList.Add(newEvent);
                return RedirectToAction("Events", "Home"); // Przekierowanie do innej akcji po utworzeniu obiektu Event
            }

            ViewBag.Message = "Event nie został utworzony";
            return View();
           
        }
        [HttpGet]
        public ActionResult Remove(string nameOfEvent)
        {
            Event eventInfo = EventsProject.Controllers.EventController.eventsList.FirstOrDefault(e => e.EventName == nameOfEvent);
            if (eventInfo != null)
            {
                //eventsList.Remove(eventInfo);
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