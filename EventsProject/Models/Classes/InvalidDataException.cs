using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EventsProject.Models.Classes
{
    public class InvalidDataException : Exception
    {
        public InvalidDataException() { }
        public InvalidDataException(string message) : base(message) { }
        
    }
}