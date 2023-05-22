using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EventsProject.Models.Classes
{
    public class Localization
    {
        public Localization(int id, string country, string town, string street, bool isInside)
        {
            Id = id;
            Country = country;
            Town = town;
            Street = street;
            IsInside = isInside;
        }
        public int Id { get; set; } 
        public string Country { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public bool IsInside { get; set; }


        public string Where()
        {
            if(this.IsInside)
            {
                return ("Inside");
            }
            return ("Outside");
        }
        public override string ToString()
        {
            return ($"{this.Country} {this.Town} {this.Street} {Where()}");
        }
    
    }
}