using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventsProject.Models.Classes
{
    /// <summary>
    /// Represents a localization class that contains information about a specific location.
    /// </summary>
    public class Localization
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Localization"/> class with the specified parameters.
        /// </summary>
        /// <param name="id">The unique identifier for the localization.</param>
        /// <param name="country">The country of the localization.</param>
        /// <param name="town">The town or city of the localization.</param>
        /// <param name="street">The street of the localization.</param>
        /// <param name="isInside">A boolean value indicating whether the localization is inside or outside.</param>
        public Localization(int id, string country, string town, string street, bool isInside)
        {
            Id = id;
            Country = country;
            Town = town;
            Street = street;
            IsInside = isInside;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the localization.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the country of the localization.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the town or city of the localization.
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Gets or sets the street of the localization.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the localization is inside or outside.
        /// </summary>
        public bool IsInside { get; set; }

        /// <summary>
        /// Determines the location type based on the "IsInside" property.
        /// </summary>
        /// <returns>A string indicating whether the location is inside or outside.</returns>
        public string Where()
        {
            if (IsInside)
            {
                return "Inside";
            }
            return "Outside";
        }

        /// <summary>
        /// Returns a string representation of the localization object.
        /// </summary>
        /// <returns>A string containing the country, town, street, and location type.</returns>
        public override string ToString()
        {
            return $"{Country} {Town} {Street} {Where()}";
        }
    }
}
