using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BookCarWOnion.WebUI.Controllers
{
  
    public class ServicesController : Controller
    { 
        public IActionResult Index()
        {
            ViewBag.v1 = "Hizmetler";
            ViewBag.v1 = "Hizmetlerimiz";
            return View();
        }
    }
}