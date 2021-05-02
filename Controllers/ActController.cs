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
    public class ActController : Controller
    {
        private readonly ILogger<ActController> _logger;
        private readonly Story _story;

        public ActController(ILogger<ActController> logger, Story story)
        {
            _logger = logger;
            _story = story;
        }

        [Route("[controller]/{actId}")]
        public IActionResult Index(int actId)
        {   
            var act = _story.GetAct(actId);

            var sceneId = act.Scenes.First().ID;

            return RedirectToAction(nameof(Scene), new {
                actId = actId,
                sceneId = sceneId
            });
            // return View(act);
        }

        [Route("[controller]/{actId}/[action]/{sceneId}")]
        public IActionResult Scene(int actId, string sceneId)
        {
            // var act = _story.GetAct(actId);
            // var scene = act.GetScene(sceneId);
            var scene = _story.Acts.First().Scenes.First(x => x.ID == sceneId);
            return View(scene);
        }

        public IActionResult Privacy()
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
