using Microsoft.AspNetCore.Mvc;
using PortalFramework;
using System;
using System.Collections.Generic;
using System.Text;
//using ClTagHelpers;

namespace Module1.Controllers
{
    public class HomeController : BaseController
    {
        private IMyRepository _repository;

        public HomeController(IMyRepository repository)
        {
            _repository = repository;
        }
        
        public IActionResult Index()
        {
            DoStuff();
            ViewBag.Value = $"{_repository.GetStuff()} : {Now}";
            return View();
        }
    }
}
