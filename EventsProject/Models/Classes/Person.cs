using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsProject.Models.Classes
{
    /// <summary>
    /// Represents a person with their associated properties and reviews.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class with default values.
        /// </summary>
        public Person()
        {
            Reviews = new List<Review>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class with the specified parameters.
        /// </summary>
        /// <param name="id">The unique identifier for the person.</param>
        /// <param name="firstName">The first name of the person.</param>
        /// <param name="lastName">The last name of the person.</param>
        /// <param name="email">The email address of the person.</param>
        /// <param name="phone">The phone number of the person.</param>
        public Person(int id, string firstName, string lastName, string email, string phone)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Reviews = new List<Review>();
        }

        /// <summary>
        /// Gets or sets the unique identifier for the person.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name of the person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email address of the person.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the person.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the list of reviews associated with the person.
        /// </summary>
        public List<Review> Reviews { get; set; }
    }
}
