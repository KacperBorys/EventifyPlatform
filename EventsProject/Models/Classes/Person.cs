using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsProject.Models.Classes
{
    public class Person
    {
        public Person(string firstName, string lastName, string email, string phone)
        {
            PersonFirstName = firstName;
            PersonLastName = lastName;
            PersonEmail = email;
            PersonPhone = phone;
        }

        public string PersonFirstName { get; set; }
        public string PersonLastName { get; set; }
        public string PersonEmail { get; set; }
        public string PersonPhone { get; set; }

    }
}