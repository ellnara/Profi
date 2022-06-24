using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Profi.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string OperationName { get; set; }
        public string Comment { get; set; }
        public float Stars { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
