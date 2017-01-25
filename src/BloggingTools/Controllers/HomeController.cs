using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BloggingUtilities.Video;

namespace BloggingTools.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            Channel9Post c9post = new Channel9Post("https://channel9.msdn.com/Shows/Data-Exposed/Big-Data-Partner-Program");
            c9post.Parse();

            var desc = c9post.Description;
            var raw = c9post.RawHtml;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
