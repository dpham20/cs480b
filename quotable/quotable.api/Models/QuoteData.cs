using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quotable.api.Models
{
    /// <summary>
    /// A model that has a IEnumerable<Quote> attribute that takes in a collection of quotes from the .core project.
    /// </summary>
    public class QuoteData
    {
        string id { get; set; }
        string quote { get; set; }
        string author { get; set; }

    }
}
