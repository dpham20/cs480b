using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using quotable.core;
using Microsoft.AspNetCore.Mvc;
using Quote = quotable.api.Models.Quote;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace quotable.api.Controllers
{

    /// <summary>
    /// Controller class to handle resources for Quote
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : Controller
    {
        private readonly QuoteContext _context;
        //private RandomQuoteProvider Provider { get; }
        /// <summary>
        /// Sets a RandomQuoteProvider object "Provider"
        /// </summary>
        /// <param name="provider"></param>
        public QuoteController(QuoteContext context)
        {
            _context = context;
        }

        // GET: /Quote/
        /// <summary>
        /// Returns the View for the API project.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Default resource URL that reutrns an array of other resource links.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "/Quote/(number) for specific quote.", "/Quote/GetAll for all quotes.", "/Quote/GetRandomQuote for a random quote (not versioned for this assignment)." };
        }

        /// <summary>
        /// Returns a quote based on a parameter based to it.
        /// api/quotes/0 for example.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: /Quote/5
        [HttpGet("{id}")]
        public ActionResult<Quote> GetQuoteById(int id)
        {
            var quote = _context.Quotes.SingleOrDefault(d => d.id == id.ToString());
            if (quote == null)
            {
                return NotFound();
            }
            return new Quote()
            {
                quote = quote.quote
            };
        }

        /// <summary>
        ///Returns all quotes available. 
        /// </summary>
        /// <returns></returns>
        [Route("GetAllQuotes")]
        [HttpGet]
        public IEnumerable<Quote> GetAllQuotes()
        {
            return from quote in _context.Quotes
                   select new Quote()
                   {
                       quote = quote.quote
                   };
        }

        /// <summary>
        ///Returns a random quote from 1-4 since my default array only has four quotes.
        /// </summary>
        /// <returns></returns>
        [Route("GetRandomQuote")]
        [HttpGet]
        public ActionResult<Quote> GetRandomQuote()
        {
            Random rnd = new Random();
            int id = rnd.Next(1, 5);
           
            var data = _context.Quotes.SingleOrDefault(d => d.id == id.ToString());

            if (data == null)
            {
                return NotFound();
            }
            return new Quote()
            {
                quote = data.quote
            };
        }
    }
}
