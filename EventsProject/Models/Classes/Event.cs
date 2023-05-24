using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventsProject.Models.Classes
{
    public enum EventCategory { Festival, Concert, Business_meeting, Other };
    public enum EventAudience { Youth, Parents, Families, Businessmen, Other }
    /// <summary>
    /// Represents an event with its associated properties and methods.
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Gets or sets the unique identifier for the event.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the event.
        /// </summary>
        public string EventName { get; set; }

        /// <summary>
        /// Gets or sets the date of the event.
        /// </summary>
        public DateTime EventDate { get; set; }

        /// <summary>
        /// Gets or sets the place of the event.
        /// </summary>
        public string EventPlace { get; set; }

        /// <summary>
        /// Gets or sets the description of the event.
        /// </summary>
        public string EventDescription { get; set; }

        /// <summary>
        /// Gets or sets the normal price for the event.
        /// </summary>
        public double EventPriceNormal { get; set; }

        /// <summary>
        /// Gets or sets the reduced price for the event.
        /// </summary>
        public double EventPriceReduced { get; set; }

        /// <summary>
        /// Gets or sets the category of the event.
        /// </summary>
        public EventCategory EventCategory { get; set; }

        /// <summary>
        /// Gets or sets the available seats for the event.
        /// </summary>
        public int EventAvailableSeats { get; set; }

        /// <summary>
        /// Gets or sets the start time of the event.
        /// </summary>
        public TimeSpan EventStartTime { get; set; }

        /// <summary>
        /// Gets or sets the target audience for the event.
        /// </summary>
        public EventAudience EventTargetAudience { get; set; }

        /// <summary>
        /// Gets or sets the source of the event's image.
        /// </summary>
        public string ImgSrc { get; set; }

        /// <summary>
        /// Gets or sets the ID of the associated localization for the event.
        /// </summary>
        public int? LocalizationId { get; set; }

        /// <summary>
        /// Gets or sets the associated localization for the event.
        /// </summary>
        public virtual Localization Localization { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        public Event() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class with the specified parameters.
        /// </summary>
        /// <param name="eventName">The name of the event.</param>
        /// <param name="eventDate">The date of the event.</param>
        /// <param name="eventPlace">The place of the event.</param>
        /// <param name="eventDescription">The description of the event.</param>
        /// <param name="eventPriceNormal">The normal price for the event.</param>
        /// <param name="eventPriceReduced">The reduced price for the event.</param>
        /// <param name="eventCategory">The category of the event.</param>
        /// <param name="eventMaxAvailableSeats">The maximum number of available seats for the event.</param>
        /// <param name="eventStartTime">The start time of the event.</param>
        /// <param name="eventTargetAudience">The target audience for the event.</param>
        /// <param name="imgSrc">The source of the event's image.</param>
        public Event(string eventName, DateTime eventDate, string eventPlace, string eventDescription, double eventPriceNormal, double eventPriceReduced, EventCategory eventCategory, int eventMaxAvailableSeats, TimeSpan eventStartTime, EventAudience eventTargetAudience, string imgSrc)
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
            ImgSrc = imgSrc;
        }
    }
}
