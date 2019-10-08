using NUnit.Framework;
using quotable.api.Controllers;
using quotable.core;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Testing_Get_By_Id()
        {
            RandomQuoteProvider Provider = new SimpleRandomQuoteProvider();
            QuoteController controller = new QuoteController(Provider);

            var actual = controller.GetQuoteById(2);

            Assert.That(actual.Value.Id, Is.EqualTo(2));
            Assert.That(actual.Value.Author, Is.EqualTo("Dan"));
            Assert.That(actual.Value.quote, Is.EqualTo("[Quote1, Quote2]"));
        }

        [Test]
        public void Testing_Get_All()
        {
            RandomQuoteProvider Provider = new SimpleRandomQuoteProvider();
            QuoteController controller = new QuoteController(Provider);

            var actual = controller.GetAllQuotes();

            Assert.That(actual.Value.Id, Is.EqualTo("Dan"));
            Assert.That(actual.Value.quote, Is.EqualTo("[Quote1, Quote2, Quote3, TwoDollah"));
        }

    }
}