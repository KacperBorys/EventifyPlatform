using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EventsProject.Models.Classes
{
    public enum EventCategory { Festival, Concert, Business_meeting, Other }

    public class Event
    {

        public Event(string description, int max_people, DateTime date, EventCategory category, int max_tickets)
        {
            Description = description;
            Max_people = max_people;
            Date = date;
            Category = category;
            Max_tickets = max_tickets;
        }

        public string Description { get; set; }
        public int Max_people { get; set; }
        public DateTime Date { get; set; }
        public EventCategory Category { get; set; }

        public int Max_tickets { get; set; }

    }
}