using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class HbFeedback
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public string IsReply { get; set; }
    }
}
