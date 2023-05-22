using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsProject.Models.Classes
{
    public class Review
    {
        public Review(int rate, string text)
        {
            this.rate = rate;
            this.text = text;
        }

        public int ReviewId { get; set; }
        public int rate { get; set; }
        public string text { get; set; }

        public int? PersonId { get; set; }
        public virtual Person  Person { get; set;}

        public int? EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}