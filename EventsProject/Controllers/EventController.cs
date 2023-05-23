﻿using EventsProject.Models.Classes;
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
    }
    

}