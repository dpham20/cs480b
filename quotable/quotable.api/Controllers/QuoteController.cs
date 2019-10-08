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
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : Controller
    {
        private RandomQuoteProvider Provider { get; }

        public QuoteController(RandomQuoteProvider provider)
        {
            Provider = provider;
        }

        // GET: /Quote/
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
            return new string[] { "/Quote/id for specific quote.", "/Quote/GetAll for all quotes." };
        }

        /// <summary>
        /// Returns a quote based on a parameter based to it.
        /// api/quotes/5 for example.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: /Quote/5
        [HttpGet("{id}")]
        public ActionResult<QuoteData> GetQuoteById(int id)
        {
            var data = new QuoteData();
            data.quote = Provider.returnQ(id);
            data.Author = "Dan";
            data.Id = id.ToString();
            return data;
        }

        /// <summary>
        ///Returns all quotes available. 
        /// </summary>
        /// <returns></returns>
        [Route("GetAllQuotes")]
        [HttpGet]
        public ActionResult<QuoteData> GetAllQuotes()
        {
            var data = new QuoteData();
            data.quote = Provider.returnQ(100);
            data.Author = "Dan";
            data.Id = "ID";
            return data;
        }

        /// <summary>
        ///Returns a random quote from 1-4 since my default array only has four quotes.
        /// </summary>
        /// <returns></returns>
        [Route("GetRandomQuote")]
        [HttpGet]
        public ActionResult<QuoteData> GetRandomQuote()
        {
            var data = new QuoteData();
            Random rnd = new Random();
            var id = rnd.Next(1, 4);
            data.quote = Provider.returnQ(id);
            data.Author = "Dan";
            data.Id = id.ToString();
            return data;
        }
    }
}
