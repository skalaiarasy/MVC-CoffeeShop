using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCCoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoffeeShop.Controllers
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
        public IActionResult Input()
        {
            return View();
        }       

        public IActionResult Output(CoffeeShop coffeeShop)
        {
            ViewData["FirstName"] = coffeeShop.FirstName;
            ViewData["LastName"] = coffeeShop.LastName;
            ViewData["Email"] = coffeeShop.Email;
            ViewData["Password"] = coffeeShop.Password;
            ViewData["Venilla"] = coffeeShop.Venilla;
            ViewData["Mocha"] = coffeeShop.Mocha;
            ViewData["Caramel"] = coffeeShop.Cramel;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
