using System;
using System.Collections.Generic;

namespace quotable.core{
    /// <summary>
    /// Interface used to return quotes.
    /// </summary>
    public interface RandomQuoteProvider{
        /// <summary>
        /// Takes in a long value representing how many quotes to return
        /// Returns quotes based on numOfQuotes.
        /// </summary>
        /// <param name="numOfQuotes"></param>
        /// <returns></returns>
        IEnumerable<Quote> returnQ (long numOfQuotes);
        /// <summary>
        /// Takes in a ID then returns a quote object based on that Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Quote returnQuoteById(int id);
    } 
}