using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CorporateArchitecture.WebUI.Models;
using CorporateArchitecture.Bll.Abstract;
using CorporateArchitecture.Entity.ComplexTypes.Model;
using CorporateArchitecture.Entity.Concrete;

namespace CorporateArchitecture.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public IActionResult Index()
        {
            //Aspect Validation Test 
            var paramaters = new Product() { ProdName = "s",ProdUnitPrice=1000 };
            var data = _productService.Add(new ProductModel()
            {
                Product = paramaters
            }) ;

            //Aspect Cache Testi
            //_productService.GetAll();
            //_productService.GetAll();
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
