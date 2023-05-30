using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class StatisticElement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int CreatedById { get; set; }
        public int UpdateById { get; set; }
    }
}
