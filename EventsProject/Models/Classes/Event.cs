using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EventsProject.Models.Classes
{
    public enum EventCategory { Festival, Concert, Business_meeting, Other };
    public enum EventAudience { Youth, Parents, Families, Businessmen, Other }

    public class Event
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventPlace { get; set; }
        public string EventDescription { get; set; }
        public double EventPriceNormal { get; set; }
        public double EventPriceReduced { get; set; }
        public EventCategory EventCategory { get; set; }
        public int EventAvailableSeats { get; set; }
        public TimeSpan EventStartTime { get; set; }
        public EventAudience EventTargetAudience { get; set; }

        public int? LocalizationId { get; set; }
        public virtual Localization Localization { get; set; }
        public Event() { }
        public Event(string eventName)
        {
            EventName = eventName;
        }
        public Event(string eventName, DateTime eventDate, string eventPlace, string eventDescription, double eventPriceNormal, double eventPriceReduced, EventCategory eventCategory, int eventMaxAvailableSeats, TimeSpan eventStartTime, EventAudience eventTargetAudience)
        {
            EventName = eventName;
            EventDate = eventDate;
            EventPlace = eventPlace;
            EventDescription = eventDescription;
            EventPriceNormal = eventPriceNormal;
            EventPriceReduced = eventPriceReduced;
            EventCategory = eventCategory;
            EventAvailableSeats = eventMaxAvailableSeats;
            EventStartTime = eventStartTime;
            EventTargetAudience = eventTargetAudience;
        }
    }
}
