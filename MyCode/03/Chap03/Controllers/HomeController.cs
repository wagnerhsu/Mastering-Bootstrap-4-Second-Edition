using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Chap03.Models;

namespace Chap03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Step01() => View();
        public IActionResult Example01() => View();
        public IActionResult Example02() => View();
        public IActionResult Example03() => View();
        public IActionResult Example04() => View();
        public IActionResult Example05() => View();
        public IActionResult Example06() => View();
        public IActionResult Example07() => View();
        public IActionResult Example08() => View();
        public IActionResult Example09() => View();
        public IActionResult Example10() => View();
        public IActionResult Example11() => View();
        public IActionResult Example12() => View();
        public IActionResult Example13() => View();
        public IActionResult Example14() => View();
        public IActionResult Example15() => View();
        public IActionResult Example16() => View();
    }
}
