using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Identity.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Cccd_id { get; set; }

        public string AuthCode { get; set; }

        public DateTime CreateDateAuthCode { get; set; }

        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}
