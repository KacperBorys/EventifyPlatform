using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EventsProject.Models.Classes
{
    public class TicketLimitException : Exception
    {
        public TicketLimitException() { }
        public TicketLimitException(string message) : base(message) { }
    }
}