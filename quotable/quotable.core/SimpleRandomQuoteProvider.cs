using System.Collections.Generic;

namespace quotable.core{
    public class SimpleRandomQuoteProvider : RandomQuoteProvider{
        public IEnumerable<string> returnQ (long numOfQuotes){
            IEnumerable<string> test;
            var testArr = new string[]{"Quote1", "Quote2", "Quote3", "TwoDollah"};
            return testArr;
        }
    }
}