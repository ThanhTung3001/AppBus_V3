using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class RequestLogger
    {
        public int Id { get; set; }
        public string IpAddress { get; set; }
        public DateTime? RequestDate { get; set; }
    }
}
