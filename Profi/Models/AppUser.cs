using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Profi.Models
{
    public class AppUser:IdentityUser
    {
        public bool IsActivated { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CheckPassword { get; set; }
    }
}
