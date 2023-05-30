using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Place
    {
        public int Id { get; set; }
        public string TitleEn { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ContentEn { get; set; }
        public string Introduce { get; set; }
        public string Content { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? UpdateById { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? VideoId { get; set; }
        public int? ImageId { get; set; }
        public double? Lattitude { get; set; }
        public double? Longtidute { get; set; }
        public string Address { get; set; }
        public string SlideShow { get; set; }
        public bool? Active { get; set; }
        public string ShortTitle { get; set; }
    }
}
