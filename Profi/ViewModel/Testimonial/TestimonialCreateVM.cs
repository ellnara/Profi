using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Profi.ViewModel.Testimonial
{
    [Area("AdminPanel")]
    public class TestimonialCreateVM
    {
        [Required]
        public string Name { get; set; }
        public string Comment { get; set; }
        public string OperationName { get; set; }
        public float Stars { get; set; }
        public IFormFile Photo { get; set; }
    }
}
