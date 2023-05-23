using EventsProject.Models;
using EventsProject.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventsProject.Controllers
{
    public class EventController : Controller
    {
        //private readonly DatabaseContext _context;

        //public EventController(DatabaseContext context)
        //{
        //    _context = context;
        //}
        // GET: Event
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
                eventsList.Remove(eventInfo);
                return RedirectToAction("Events", "Home");
               
            }
            return View();         
        }

        //[HttpGet]
        //public ActionResult Events()
        //{
        //    List<Event> listOfEventsFromDB;
        //    using(DatabaseContext db= new DatabaseContext())
        //    {
        //        listOfEventsFromDB = db.Events.ToList();
        //        eventsList = listOfEventsFromDB;
        //    }
        //    return View();
        //}
    }
    

}