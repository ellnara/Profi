using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Profi.DAL;
using Profi.Helpers;
using Profi.Models;
using Profi.ViewModel.Testimonial;

namespace Profi.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class TestimonialsController : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _env { get; }

        public TestimonialsController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            return View(_context.Testimonials.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TestimonialCreateVM testimonial)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Testimonial newTestimonial = new Testimonial
            {
                Url = testimonial.Photo.FileName,
                Name = testimonial.Name,
                OperationName = testimonial.OperationName,
                Comment = testimonial.Comment,
                Stars = testimonial.Stars
            };
            await _context.Testimonials.AddAsync(newTestimonial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var testimonial = _context.Testimonials.Find(id);
            if (testimonial == null)
            {
                return NotFound();
            }
            var path = Helper.GetPath(_env.WebRootPath, "img", testimonial.Url);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _context.Testimonials.Remove(testimonial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testimonial = await _context.Testimonials.FindAsync(id);
            if (testimonial == null)
            {
                return NotFound();
            }
            return View(testimonial);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Testimonial testimonial,int? id)
        {
            if (id != testimonial.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                    _context.Update(testimonial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(testimonial);
        }
    }
}
