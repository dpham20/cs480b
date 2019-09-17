using System;
using System.Collections.Generic;

namespace quotable.core{
    /// <summary>
    /// Class that implements interface, RandomQuoteProvider.
    /// </summary>
    public class SimpleRandomQuoteProvider : RandomQuoteProvider{
        /// <summary>
        /// Takes in numOfQuotes and shoots back as many strings as equats to numOfQuotes value.
        /// If it goes over the length of available quotes then it returns all quotes.
        /// </summary>
        /// <param name="numOfQuotes"></param>
        /// <returns></returns>
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