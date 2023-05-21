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
           Ticket_Price = price;
           Ticket_IsNormal = isNormal;
           Ticket_WhenBought = whenBought;
        }

        public decimal Ticket_Price { get; set; }
        public bool Ticket_IsNormal { get; set; }
        public DateTime Ticket_WhenBought { get; set; }

    }
}