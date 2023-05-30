using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Service
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string PriceDescription { get; set; }
        public int? VideoId { get; set; }
        public int? ImageId { get; set; }
    }
}
