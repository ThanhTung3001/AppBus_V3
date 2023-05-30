using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string Introduce { get; set; }
        public string Content { get; set; }
        public int? VideoId { get; set; }
        public int? ImageId { get; set; }
        public string Address { get; set; }
        public DateTime? OpenDate { get; set; }
        public double? Lattitude { get; set; }
        public double? Longtidute { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? UpdateById { get; set; }
        public int? CreatedById { get; set; }
        public string IsDaily { get; set; }
        public string EventTime { get; set; }
        public string IsAvatar { get; set; }
        public bool? Active { get; set; }
    }
}
