using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// <summary>
    /// One to many relation between quote and authors.
    /// </summary>
    public sealed class QuoteAuthor
    {
        /// <summary>
        /// the ID of the quote that relates to the author
        /// </summary>
        public string QuoteId { get; set; }
        /// <summary>
        ///the quote related to the author.
        /// </summary>
        public Quote Quote { get; set; }
        /// <summary>
        /// The author id related to the quote
        /// </summary>
        public string AuthorId { get; set; }
        /// <summary>
        /// The author related to the quote.
        /// </summary>
        public Author Author { get; set; }
    }
}
