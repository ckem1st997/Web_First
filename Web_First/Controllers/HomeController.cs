using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web_First.Data;
using Web_First.Models;
using X.PagedList;

namespace Web_First.Controllers
{
    public class HomeController : Controller
    {
        private readonly MvcSPContext _context;
        public HomeController(MvcSPContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // sale
            var products = (from a in _context.San_Pham_Sale
                           select a).Take(20);
            ViewBag.SP_Sale = products.ToPagedList(1, 20); 
            // sale
            var products1 =( from a in _context.San_Pham_New
                           select a).Take(20);
            ViewBag.SP_New = products1.ToPagedList(1,20);
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
