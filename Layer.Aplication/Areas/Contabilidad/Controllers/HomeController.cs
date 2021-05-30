using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layer.Aplication.Areas.Contabilidad.Controllers
{
    [Area("Contabilidad")]
    public class HomeController : Controller
    {

        [HttpGet, Route("~/Contabilidad/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
