using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Profi.DAL;
using Profi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Profi.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; set; }

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Testimonials.ToList());
        }

    }
}
