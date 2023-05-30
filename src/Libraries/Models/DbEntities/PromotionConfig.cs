using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class PromotionConfig
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ExtendDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int? Rate { get; set; }
        public string Description { get; set; }
    }
}
