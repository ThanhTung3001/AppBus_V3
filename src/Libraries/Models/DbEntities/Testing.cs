using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Testing
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
    }
}
