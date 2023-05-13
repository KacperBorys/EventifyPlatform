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

        public decimal Price { get; set; }
        public bool IsNormal { get; set; }
        public DateTime WhenBought { get; set; }

    }
}