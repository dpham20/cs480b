using System;
using System.Collections.Generic;

namespace quotable.core{
    /// <summary>
    /// Can accept a list of quote from a file. A implementation of RandomQuoteProvider.
    /// </summary>
    public class DefaultRandomQuoteProvider : RandomQuoteProvider{
        string[] quotes; //list of available quotes.
        //constructor that takes in an array of strings to populate avaiable quotes (quotes)
        public DefaultRandomQuoteProvider(string[] quotes){
            this.quotes = quotes;
        }
        /// <summary>
        /// Returns list of quotes based on numOfQuotes requested by user.
        /// </summary>
        /// <param name="numOfQuotes"></param>
        /// <returns></returns>
        public IEnumerable<string> returnQ (long numOfQuotes){
            //var quoteArr = this.quotes;
            var quoteArr = quotes;
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