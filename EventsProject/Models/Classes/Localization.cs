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
            Localization_Country = country;
            Localization_Town = town;
            Localization_Street = street;
            Localization_IsInside = isInside;
        }
        public string Localization_Country { get; set; }
        public string Localization_Town { get; set; }
        public string Localization_Street { get; set; }
        public bool Localization_IsInside { get; set; }


        public string Is_Inside()
        {
            if(this.Localization_IsInside)
            {
                return ("Inside");
            }
            return ("Outside");
        }
        public override string ToString()
        {
            return ($"{this.Localization_Country} {this.Localization_Town} {this.Localization_Street} {Is_Inside()}");
        }
    
    }
}