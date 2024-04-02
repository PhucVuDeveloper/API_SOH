using _20DTHJA1_API_Socket.Models;
using Libs.Entities;
using Libs.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _20DTHJA1_API_Socket.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ProductService productService)
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
    }
}