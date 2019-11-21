using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace quotable.core {
    /// <summary>
    /// Model object for a Quote object.
    /// </summary>
    public sealed class Quote
    {
        //This is a model class to represent Quote obejcts.

        /// <summary>
        /// Creates a Quote object setting parameters: id, string, and author.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="quote"></param>
        /// <param name="author"></param>
        //public Quote(string id, string quote)
        //{
        //    this.id = id;
        //    this.quote = quote;
        //}
        /// <summary>
        /// id represents a string id of a Quote object.
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// quote holds the string quote of an author for the Quote object.
        /// </summary>
        public string quote { get; set; }
        /// <summary>
        /// To find more than 1 author of a quote if there are more than one.
        /// </summary>
        [NotMapped]
        public IEnumerable<Author> Authors => from x in QuoteAuthor select x.Author;
        /// <summary>
        /// The relations of quote to the author.
        /// </summary>
        public ICollection<QuoteAuthor> QuoteAuthor { get; set; } = new List<QuoteAuthor>();
    }
}