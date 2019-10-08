using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace quotable.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : Controller
    {
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
        public ActionResult<IEnumerable> GetQuoteById(int id)
        {
            return "hi";
        }

        /// <summary>
        ///Returns all quotes available. 
        /// </summary>
        /// <returns></returns>
        [Route("GetAllQuotes")]
        [HttpGet]
        public ActionResult<IEnumerable> GetAllQuotes()
        {
            return "all quotes";
        }
    }
}
