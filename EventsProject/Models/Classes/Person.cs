using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsProject.Models.Classes
{
    public class Person
    {
        public Person() { Reviews = new List<Review>(); }
        public Person(int id, string firstName, string lastName, string email, string phone)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<Review> Reviews { get; set; }
    }
}