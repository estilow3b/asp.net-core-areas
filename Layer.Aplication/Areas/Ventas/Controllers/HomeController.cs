using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layer.Aplication.Areas.Ventas.Controllers
{
    [Area("Ventas")]
    public class HomeController : Controller
    {
        [HttpGet, Route("~/Ventas/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
