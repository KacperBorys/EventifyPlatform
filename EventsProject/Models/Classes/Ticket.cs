using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EventsProject.Models.Classes
{
    public class Ticket
    {
        public Ticket(decimal price, bool isNormal, DateTime whenBought)
        {          
            Price = price;
            IsNormal = isNormal;
            WhenBought = whenBought;
        }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public bool IsNormal { get; set; }
        public DateTime WhenBought { get; set; }

        public int? PersonId { get; set; }
        public virtual Person Person { get; set; }
        public int? EventId { get; set; }
        public virtual Event Event { get; set; }

    }
}