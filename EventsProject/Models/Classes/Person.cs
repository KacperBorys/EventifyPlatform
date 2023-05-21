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
            Person_FirstName = firstName;
            Person_LastName = lastName;
            Person_Email = email;
            Person_Phone = phone;
        }

        public string Person_FirstName { get; set; }
        public string Person_LastName { get; set; }
        public string Person_Email { get; set; }
        public string Person_Phone { get; set; }

    }
}