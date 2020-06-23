using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HayEquipo.Models;
using HayEquipo.data;

namespace HayEquipo.Controllers
{
    public class HomeController : Controller
    {
        private HayEquipoContext _context;

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public HomeController (HayEquipoContext context)
        {
            _context = context;
        }
    }
}
