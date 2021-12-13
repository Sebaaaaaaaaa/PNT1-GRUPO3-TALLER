using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Taller.Models;
using Taller.Context;

namespace Taller.Controllers
{
    public class HomeController : Controller
    {

        private readonly TallerDBContext _context;

        public HomeController(TallerDBContext context)
        {
            _context = context;
        }
        
        
        public List<Novedades> getDatos()
        {
            List<Novedades> datos = _context.Novedades.ToList();
            return datos;
        }
        public IActionResult Index()
        {
            ViewBag.novedades = getDatos().Take(5);
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
