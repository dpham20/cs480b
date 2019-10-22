using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quotable.core;
using quotable.api.Controllers;
using quotable.api.Models;

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
        private RandomQuoteProvider Provider { get; }
        /// <summary>
        /// Sets a RandomQuoteProvider object "Provider"
        /// </summary>
        /// <param name="provider"></param>
        public QuoteController(RandomQuoteProvider provider)
        {
            Provider = provider;
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
            return new string[] { "/Quote/(number) for specific quote.", "/Quote/GetAll for all quotes." };
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
            var data = new Quote("","","");
            data = Provider.returnQuoteById(id);
            return data;
        }

        /// <summary>
        ///Returns all quotes available. 
        /// </summary>
        /// <returns></returns>
        [Route("GetAllQuotes")]
        [HttpGet]
        public ActionResult<Quote[]> GetAllQuotes()
        {
           IEnumerable<Quote> data =  Provider.returnQ(100);
           return data.Cast<Quote>().ToArray();
        }

        /// <summary>
        ///Returns a random quote from 1-4 since my default array only has four quotes.
        /// </summary>
        /// <returns></returns>
        [Route("GetRandomQuote")]
        [HttpGet]
        public ActionResult<Quote> GetRandomQuote()
        {
            var data = new Quote("", "", "");
            Random rnd = new Random();
            var id = rnd.Next(0, 4);
            data = Provider.returnQuoteById(id);
            return data;
        }
    }
}
