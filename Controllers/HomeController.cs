using Microsoft.AspNetCore.Mvc;
using AspHw3.Models;

namespace AspHw3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Car> cars = new List<Car>
            {
                new Car { Brand = "BMW", Model = "M5", Price = 120000 },
                new Car { Brand = "Mercedes", Model = "E63", Price = 110000 },
                new Car { Brand = "Audi", Model = "RS7", Price = 150000 },
                new Car { Brand = "Porsche", Model = "911", Price = 130000 }
            };
            return View(cars);
        }
    }
}