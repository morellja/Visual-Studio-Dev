using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        // here we return a View object in IActionResult - this is how Controllers interact with Views
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome
        public IActionResult Welcome(string  name, int numTimes)
        {
            // before, were just returning a string directly
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes: {numtimes}");

            // now using ViewData dynamic object to store new values to its dictionary
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
