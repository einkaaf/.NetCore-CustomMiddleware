using CustomMiddleware.Models;
using CustomMiddleware.Models.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMiddleware.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            PersonService service = new PersonService();

            return View(service.getAllPerson());
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
