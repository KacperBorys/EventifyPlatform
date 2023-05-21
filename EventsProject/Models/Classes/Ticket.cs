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
           TicketPrice = price;
           TicketIsNormal = isNormal;
           TicketWhenBought = whenBought;
        }

        public decimal TicketPrice { get; set; }
        public bool TicketIsNormal { get; set; }
        public DateTime TicketWhenBought { get; set; }

    }
}