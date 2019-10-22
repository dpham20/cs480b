using NUnit.Framework;
using quotable.api.Controllers;
using quotable.core;

namespace Tests
{
    /// <summary>
    /// Testing class to test api functionality for resource url.
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Not in use.
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Testing if quote of JSON body is equal to this string when using getById
        /// </summary>
        [Test]
        public void Testing_Get_By_Id()
        {
            RandomQuoteProvider Provider = new SimpleRandomQuoteProvider();
            QuoteController controller = new QuoteController(Provider);

            var actual = controller.GetQuoteById(2);
            Assert.That(actual.Value.quote, Is.EqualTo(("In three words I can sum up everything I've learned about life: it goes on.")));
        }
        /// <summary>
        /// Testing if quote of JSON body is not null for getById
        /// </summary>
        [Test]
        public void Testing_Get_By_Id_Not_Null()
        {
            RandomQuoteProvider Provider = new SimpleRandomQuoteProvider();
            QuoteController controller = new QuoteController(Provider);

            var actual = controller.GetQuoteById(2);
            Assert.That(actual.Value.quote, Is.Not.Null.Or.Empty);
        }
        /// <summary>
        /// Testing if length of getAll matches Acutal length of 4.
        /// </summary>
        [Test]
        public void Testing_Get_All_Length()
        {
            RandomQuoteProvider Provider = new SimpleRandomQuoteProvider();
            QuoteController controller = new QuoteController(Provider);
            var actual = controller.GetAllQuotes();
            var quoteArr = new Quote[]{
                new Quote("0", "I'm selfish, impatient and a little insecure. I make mistakes, I am out of control and at times hard to handle. But if you can't handle me at my worst, then you sure as hell don't deserve me at my best.", "Marilyn Monroe"),
                new Quote("1", "Very Cool, Kanye", "Trump"),
                new Quote("2", "In three words I can sum up everything I've learned about life: it goes on.", "Robert Frost"),
                new Quote("3", "I Like Turtles.", "Turtle Kid")
            };
             Assert.That(actual.Value.Length, Is.EqualTo(quoteArr.Length));
        }

        /// <summary>
        /// Testing if length of getAll matches quoteArr.
        /// </summary>
        [Test]
        public void Testing_Get_All()
        {
            RandomQuoteProvider Provider = new SimpleRandomQuoteProvider();
            QuoteController controller = new QuoteController(Provider);
            var actual = controller.GetAllQuotes();
            var quoteArr = new Quote[]{
                new Quote("0", "I'm selfish, impatient and a little insecure. I make mistakes, I am out of control and at times hard to handle. But if you can't handle me at my worst, then you sure as hell don't deserve me at my best.", "Marilyn Monroe"),
                new Quote("1", "Very Cool, Kanye", "Trump"),
                new Quote("2", "In three words I can sum up everything I've learned about life: it goes on.", "Robert Frost"),
                new Quote("3", "I Like Turtles.", "Turtle Kid")
            };
            Assert.That(actual.Value[1].author, Is.EqualTo(quoteArr[1].author));
            Assert.That(actual.Value[2].author, Is.EqualTo(quoteArr[2].author));
            Assert.That(actual.Value[3].author, Is.EqualTo(quoteArr[3].author));
        }

        /// <summary>
        /// Making sure only one quote is returned from getRandomQuote.
        /// </summary>
        [Test]
        public void Test_Get_Random()
        {
            RandomQuoteProvider Provider = new SimpleRandomQuoteProvider();
            QuoteController controller = new QuoteController(Provider);
            var actual = controller.GetRandomQuote();
            Assert.That(actual.Value, Is.Not.Null.Or.Empty);
        }
    }
}