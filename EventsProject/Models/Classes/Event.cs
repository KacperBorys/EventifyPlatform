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
        static int Event_Max_Tickets = 1;
 
        public Event(string event_Name, DateTime event_Date, string event_Place, string event_Description, double event_Price_Normal, double event_Price_Reduced, EventCategory event_Category, int event_Max_Available_Seats, TimeSpan event_Start_Time, EventAudience event_Target_Audience)
        {
            Event_Name = event_Name;
            Event_Date = event_Date;
            Event_Place = event_Place;
            Event_Description = event_Description;
            Event_Price_Normal = event_Price_Normal;
            Event_Price_Reduced = event_Price_Reduced;
            Event_Category = event_Category;
            Event_Max_Available_Seats = event_Max_Available_Seats;
            Event_Start_Time = event_Start_Time;
            Event_Target_Audience = event_Target_Audience;
        }

        public string Event_Name { get;set; }
        public DateTime Event_Date { get; set; }
        public string Event_Place { get; set; }
        public string Event_Description { get; set; }
        public double Event_Price_Normal { get; set; }
        public double Event_Price_Reduced { get; set; }
        public EventCategory Event_Category { get; set; }
        public int Event_Max_Available_Seats { get; set; }
        public TimeSpan Event_Start_Time { get; set; }
        public EventAudience Event_Target_Audience { get; set; }
        
    }
}