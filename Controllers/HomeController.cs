using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using text_adventure.Models;
using text_adventure.StoryEngine;

namespace text_adventure.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Story _story;

        public HomeController(ILogger<HomeController> logger, Story story)
        {
            _logger = logger;
            _story = story;
        }

        public IActionResult Index()
        {
            return View(_story);
        }
        public IActionResult Begin()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
