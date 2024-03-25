using lr8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lr8.Controllers
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
            var products = new List<Product>
        {
            new Product { id = 1, name = "Product 1", price = 10.99m, createdDate = DateTime.Now },
            new Product { id = 2, name = "Product 2", price = 20.49m, createdDate = DateTime.Now },
            new Product { id = 3, name = "Product 3", price = 15.79m, createdDate = DateTime.Now }
        };

            return View(products);
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
