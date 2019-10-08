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
    public class RandomController : Controller
    {
        private RandomQuoteProvider Provider;
        
        public RandomController(DefaultRandomQuoteProvider provider)
        {
            Provider = provider;
        }
        // GET: /<controller>/
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
        public ActionResult<QuoteData> GetRandomQuote()
        {
            var data = new QuoteData();
            Random rnd = new Random();
            data.quote = Provider.returnQ(rnd.Next(1, 4));
            data.Author = "me";
            data.Id = "1";
            return data;
        }
    }
}
