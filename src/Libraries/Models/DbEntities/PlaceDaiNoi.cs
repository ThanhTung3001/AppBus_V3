using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class PlaceDaiNoi
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }
        public string Introduce { get; set; }
        public string TitleEn { get; set; }
        public string SubTitleEn { get; set; }
        public string ContentEn { get; set; }
        public int? VideoId { get; set; }
        public int? ImageId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? UpdateById { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? UpdateTime { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? DisplayOrder { get; set; }
        public int? Type { get; set; }
        public bool? Active { get; set; }
    }
}
