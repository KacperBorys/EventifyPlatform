using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventsProject.Models.Classes
{
    /// <summary>
    /// Represents a ticket with its associated properties.
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ticket"/> class with the specified parameters.
        /// </summary>
        /// <param name="price">The price of the ticket.</param>
        /// <param name="isNormal">A boolean value indicating whether the ticket is a normal ticket or not.</param>
        /// <param name="whenBought">The date and time when the ticket was bought.</param>
        public Ticket(decimal price, bool isNormal, DateTime whenBought)
        {
            Price = price;
            IsNormal = isNormal;
            WhenBought = whenBought;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the ticket.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the price of the ticket.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the ticket is a normal ticket or not.
        /// </summary>
        public bool IsNormal { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the ticket was bought.
        /// </summary>
        public DateTime WhenBought { get; set; }

        /// <summary>
        /// Gets or sets the ID of the associated person for the ticket.
        /// </summary>
        public int? PersonId { get; set; }

        /// <summary>
        /// Gets or sets the associated person for the ticket.
        /// </summary>
        public virtual Person Person { get; set; }

        /// <summary>
        /// Gets or sets the ID of the associated event for the ticket.
        /// </summary>
        public int? EventId { get; set; }

        /// <summary>
        /// Gets or sets the associated event for the ticket.
        /// </summary>
        public virtual Event Event { get; set; }
    }
}
