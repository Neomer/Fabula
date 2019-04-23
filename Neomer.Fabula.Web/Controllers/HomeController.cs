using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Neomer.Fabula.Web.Models;
using Neomer.Fabula.SDK.Web.Core;
using Neomer.Fabula.SDK.Core.Injection;
using Neomer.Fabula.SDK.Models;
using System;

namespace Neomer.Fabula.Web.Controllers
{
    [InjectProperties]
    public class HomeController : FbBaseWebController
    {
        [Injected]
        public IComponentManager ComponentManager { get; set; }

        public IActionResult Index()
        {
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
