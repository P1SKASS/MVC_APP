using Microsoft.AspNetCore.Mvc;
using MVC_APP.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace MVC_APP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Required]
        [ViewData]
        public string Name { get; set; }

        public IActionResult First()
        {
            return View();
        }

        public IActionResult Second(string name)
        {
            ViewData["Name"] = name;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
