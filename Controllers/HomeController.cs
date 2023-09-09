using ASP.Net_KW_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP.Net_KW_Project.Controllers
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
        public IActionResult Model()
        {
            return View();
        }
        public IActionResult Controller()
        {
            return View();
        }
        public IActionResult View() => base.View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}