using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quotable.api.Models
{
    public class QuoteData
    {
        public String Id { get; set; }
        public IEnumerable<string> quote { get; set; }
        public String Author { get; set; }
    }
}
