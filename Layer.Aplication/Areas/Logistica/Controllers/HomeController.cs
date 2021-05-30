using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layer.Aplication.Areas.Logistica.Controllers
{
    [Area("Logistica")]
    public class HomeController : Controller
    {
        [HttpGet, Route("~/Logistica/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
