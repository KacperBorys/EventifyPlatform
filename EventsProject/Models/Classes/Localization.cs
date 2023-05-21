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
            LocalizationCountry = country;
            LocalizationTown = town;
            LocalizationStreet = street;
            LocalizationIsInside = isInside;
        }
        public string LocalizationCountry { get; set; }
        public string LocalizationTown { get; set; }
        public string LocalizationStreet { get; set; }
        public bool LocalizationIsInside { get; set; }


        public string IsInside()
        {
            if(this.LocalizationIsInside)
            {
                return ("Inside");
            }
            return ("Outside");
        }
        public override string ToString()
        {
            return ($"{this.LocalizationCountry} {this.LocalizationTown} {this.LocalizationStreet} {IsInside()}");
        }
    
    }
}