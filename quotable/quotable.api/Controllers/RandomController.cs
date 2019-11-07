using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quotable.core;
using quotable.api.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace quotable.api.Controllers
{
    /// <summary>
    /// Controller for sending back a random quote.
    /// </summary>
    public class RandomController : Controller
    {
        private RandomQuoteProvider Provider;
        /// <summary>
        /// Constructor takes in a provider that calls upon a created backend method.
        /// </summary>
        /// <param name="provider"></param>
        public RandomController(DefaultRandomQuoteProvider provider)
        {
            Provider = provider;
        }
        /// <summary>
        /// Default request.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
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
