using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CoreStore.Web.Models;

namespace CoreStore.Web.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var products = new List<Product>
            {
                new Product {ID = 1, Name = "Apples", Price = 1.50m},
                new Product {ID = 2, Name = "Bananas", Price = 2.00m}
            };

            return View(products);
        }
    }
}