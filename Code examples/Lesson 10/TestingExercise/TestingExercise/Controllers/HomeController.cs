using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TestingExercise.Models;

namespace TestingExercise.Controllers
{
    public class HomeController : Controller
    {
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

        public IActionResult ValidateUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new Exception("No url provided");

            var uri = new Uri(url);

            return Ok(url);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
