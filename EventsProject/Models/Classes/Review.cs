using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventsProject.Models.Classes
{
    /// <summary>
    /// Represents a review with its associated properties.
    /// </summary>
    public class Review
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Review"/> class with the specified parameters.
        /// </summary>
        /// <param name="rate">The rating for the review.</param>
        /// <param name="text">The text of the review.</param>
        public Review(int rate, string text)
        {
            this.rate = rate;
            this.text = text;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the review.
        /// </summary>
        public int ReviewId { get; set; }

        /// <summary>
        /// Gets or sets the rating for the review.
        /// </summary>
        public int rate { get; set; }

        /// <summary>
        /// Gets or sets the text of the review.
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Gets or sets the ID of the associated person for the review.
        /// </summary>
        public int? PersonId { get; set; }

        /// <summary>
        /// Gets or sets the associated person for the review.
        /// </summary>
        public virtual Person Person { get; set; }

        /// <summary>
        /// Gets or sets the ID of the associated event for the review.
        /// </summary>
        public int? EventId { get; set; }

        /// <summary>
        /// Gets or sets the associated event for the review.
        /// </summary>
        public virtual Event Event { get; set; }
    }
}
