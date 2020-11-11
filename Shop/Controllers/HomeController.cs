using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System.Diagnostics;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public ViewResult Index() 
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredProducts = _productRepository.PreferredProducts
            };
            return View(homeViewModel);
        }
    }
}
