using NUnit.Framework;
using quotable.core;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Test to see if simpleRandomQuoteProvider's returnQ returns something.
        /// </summary>
        [Test]
        public void test_simpleRandomQuoteProvider_returnQ_Null()
        {
            RandomQuoteProvider Provider = new SimpleRandomQuoteProvider();
            var actual = Provider.returnQ(2);
            Assert.That(actual, Is.Not.Null.Or.Empty);
        }

        /// <summary>
        /// Test to see if DefaultQuoteProvider;s returnQ returns something.
        /// </summary>
        [Test]
        public void test_defaultRandomQuoteProvider_returnQ_Null()
        {
            var quoteArr = new Quote[]{
                new Quote("0", "I'm selfish, impatient and a little insecure. I make mistakes, I am out of control and at times hard to handle. But if you can't handle me at my worst, then you sure as hell don't deserve me at my best.", "Marilyn Monroe"),
                new Quote("1", "Very Cool, Kanye", "Trump"),
            };
            IEnumerable<Quote> compare = quoteArr;
            RandomQuoteProvider Provider = new DefaultRandomQuoteProvider(quoteArr);
            var actual = Provider.returnQ(2);
            Assert.That(actual, Is.Not.Null.Or.Empty);
        }

        /// <summary>
        /// Test to see if simpleRandomQuoteProvider's returnQ return is accurate.
        /// </summary>
        [Test]
        public void test_simpleRandomQuoteProvider_returnQ()
        {
            var quoteArr = new Quote[]{
                new Quote("0", "I'm selfish, impatient and a little insecure. I make mistakes, I am out of control and at times hard to handle. But if you can't handle me at my worst, then you sure as hell don't deserve me at my best.", "Marilyn Monroe"),
                new Quote("1", "Very Cool, Kanye", "Trump"),
            };
            RandomQuoteProvider Provider = new SimpleRandomQuoteProvider();
            Quote[] actual = Provider.returnQ(2).Cast<Quote>().ToArray();
            Assert.That(actual[0].quote, Is.EqualTo(quoteArr[0].quote));
            Assert.That(actual[1].quote, Is.EqualTo(quoteArr[1].quote));
        }
    } 
}