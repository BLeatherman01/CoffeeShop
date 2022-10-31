using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        CoffeeProductsContext cp = new CoffeeProductsContext();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Product> products = cp.Products.ToList();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult LoginForm()
        {
            return View();
        }
       
        public IActionResult LoginWelcome(Login l)
        {
            return View(l);
        }
        public IActionResult ProductList()
        {
            List<Product> products = cp.Products.ToList();
            return View(products);
        }

        public IActionResult ProductDescription(int Id)
        {
            Product result = cp.Products.Find(Id);
            return View(result);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}