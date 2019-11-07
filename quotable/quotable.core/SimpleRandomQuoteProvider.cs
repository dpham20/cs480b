using System;
using System.Collections.Generic;

namespace quotable.core{
    /// <summary>
    /// Class that implements interface, RandomQuoteProvider.
    /// </summary>
    public class SimpleRandomQuoteProvider : RandomQuoteProvider{
        /// <summary>
        /// A hardcoded array of Quote objects.
        /// </summary>
        public Quote[] quoteArr = new Quote[]{
                new Quote("0", "I'm selfish, impatient and a little insecure. I make mistakes, I am out of control and at times hard to handle. But if you can't handle me at my worst, then you sure as hell don't deserve me at my best.", "Marilyn Monroe"),
                new Quote("1", "Very Cool, Kanye", "Trump"),
                new Quote("2", "In three words I can sum up everything I've learned about life: it goes on.", "Robert Frost"),
                new Quote("3", "I Like Turtles.", "Turtle Kid")
         };
        /// <summary>
        /// Takes in numOfQuotes and shoots back as many strings as equats to numOfQuotes value.
        /// If it goes over the length of available quotes then it returns all quotes.
        /// </summary>
        /// <param name="numOfQuotes"></param>
        /// <returns></returns>
        public IEnumerable<Quote> returnQ (long numOfQuotes){
            if(numOfQuotes <= quoteArr.Length)
            {
                var requestArr = new Quote[numOfQuotes];
                Array.Copy(quoteArr, 0, requestArr, 0, numOfQuotes);
                foreach (Quote quote in requestArr)
                {
                    Console.WriteLine(quote);
                }
                return requestArr;
            }
            else if (numOfQuotes > quoteArr.Length)
            {
                foreach (Quote quote in quoteArr)
                {
                    Console.WriteLine(quote);
                }
                return quoteArr;
            }
            return quoteArr;
        }
        /// <summary>
        /// Returns the Quote object that has the same id as the one the parameter id.
        /// If the supplied id does not appear in the array then it will retun a NULL.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Quote returnQuoteById(int id)
        {
            if (id < this.quoteArr.Length)
            {
               return this.quoteArr[id];
            }
            else
            {
                return null;
            }
        }
    }
}