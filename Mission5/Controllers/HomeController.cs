using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Mission5.Models;

namespace Mission5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Main Hobby Page
        public IActionResult Index()
        {
            // This will render Views/Home/Index.cshtml
            return View();
        }

        // Calculator Page
        public IActionResult Calculator()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel 
            { 
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier 
            });
        }
    }
}