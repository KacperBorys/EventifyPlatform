using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EventsProject.Models.Classes
{
    public class Localization
    {
        public Localization(string country, string town, string street, bool isInside)
        {
            Country = country;
            Town = town;
            Street = street;
            IsInside = isInside;
        }
        public string Country { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public bool IsInside { get; set; }
    
    }
}