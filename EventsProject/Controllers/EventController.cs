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
                // Jeśli ModelState.IsValid jest prawdziwe, to model został poprawnie związany i walidowany.
                // Możesz tutaj utworzyć obiekt `Event` na podstawie danych z modelu i wykonać odpowiednie operacje.

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
                    model.EventTargetAudience
                );
                
                eventsList.Add(newEvent);
                return RedirectToAction("Events", "Home"); // Przekierowanie do innej akcji po utworzeniu obiektu Event
            }

            ViewBag.Message = "Event nie został utworzony";

            return View(model);
        }
    }
}