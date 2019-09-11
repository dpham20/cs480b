using System;
using System.Collections.Generic;

namespace quotable.core{
    public class SimpleRandomQuoteProvider : RandomQuoteProvider{
        public IEnumerable<string> returnQ (long numOfQuotes){
            var quoteArr = new string[]{"Quote1", "Quote2", "Quote3", "TwoDollah"};
            if(numOfQuotes <= quoteArr.Length)
            {
                var requestArr = new string[numOfQuotes];
                Array.Copy(quoteArr, 0, requestArr, 0, numOfQuotes);
                foreach (string quote in requestArr)
                {
                    Console.WriteLine(quote);
                }
                return requestArr;
            }
            else if (numOfQuotes > quoteArr.Length)
            {
                foreach (string quote in quoteArr)
                {
                    Console.WriteLine(quote);
                }
                return quoteArr;
            }
            return quoteArr;
        }
    }
}