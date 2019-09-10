using System;
using System.Collections.Generic;

namespace quotable.core{
    public interface RandomQuoteProvider{
        IEnumerable<string> returnQ (long numOfQuotes);
    } 
}