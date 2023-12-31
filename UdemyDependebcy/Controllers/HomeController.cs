﻿using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using UdemyDependency.Services;

namespace UdemyDependency.Controllers
{
    public class HomeController : Controller
    { 
       private readonly IProductService _productService;
        private readonly ITransientService _transientService;
        private readonly ISingletonService _singletonService;
        private readonly IScopedService _scopedService;

      

      

        public HomeController( IProductService productService, ITransientService transientService, ISingletonService singletonService,
            IScopedService scopedService)
        {
           _productService = productService;
            _transientService = transientService;
           _singletonService = singletonService;
            _scopedService = scopedService;
        }

        public IActionResult Index()
        {
            ViewBag.Singleton  = _singletonService.GuidId;
            ViewBag.Transipent =_transientService.GuidId;
          ViewBag.Scoped= _scopedService.GuidId;
           
            return View();
        }
    }
    public interface IProductService
    {
        int GetTotal();
    }
    public class ProductManager: IProductService
    {
        public int GetTotal()
        {
            return 40;
        }
    }
}
