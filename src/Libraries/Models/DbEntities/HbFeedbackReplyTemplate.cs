using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class HbFeedbackReplyTemplate
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string IsActive { get; set; }
    }
}
