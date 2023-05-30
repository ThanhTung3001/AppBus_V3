using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class HbEmailConfig
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Content { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string Subject { get; set; }
    }
}
