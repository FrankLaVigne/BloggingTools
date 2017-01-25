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
        public async Task<IActionResult> Index()
        {
            Channel9Post c9post = await Load();

            var desc = c9post.Description;
            var raw = c9post.RawHtml;

            return View();
        }

        private static async Task<Channel9Post> Load()
        {
            Channel9Post c9post = new Channel9Post("https://channel9.msdn.com/Shows/Data-Exposed/Big-Data-Partner-Program");
            await c9post.Parse();
            return c9post;
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
