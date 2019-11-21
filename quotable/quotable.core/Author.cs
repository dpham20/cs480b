using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// <summary>
    /// //This is a model class to represent Author obejcts.
    /// </summary>
    public sealed class Author
    {
        /// <summary>
        /// id represents a string id of a Quote object.
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// quote holds the string name of an author.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// The relation of quote to author.
        /// </summary>
        public ICollection<QuoteAuthor> QuoteAuthors { get; set; }

    }
}
