using LR6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LR6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private int _counter = 0;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult TaskFirst()
        {
            return View();
        }

        public IActionResult TaskSecond()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TaskFirst(string FirstCatet, string SecondCatet)
        {
            ViewBag.H = Convert.ToInt32(FirstCatet) * Convert.ToInt32(SecondCatet);
            return View();
        }
        [HttpPost]
        public IActionResult TaskSecond(string firstQuestion, string secondQuestion, string thirdQuestion)
        {
            if(firstQuestion == null || secondQuestion == null || thirdQuestion == null)
            {
                return RedirectToAction("Index");
            }

            if(firstQuestion == "12")
            {
                _counter++;
            }
            if(secondQuestion == "23")
            {
                _counter++;
            }
            if(thirdQuestion == "31")
            {
                _counter++;
            }

            ViewBag.Result = Convert.ToInt32(_counter);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}