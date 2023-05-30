using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Device
    {
        public int Id { get; set; }
        public string ValueId { get; set; }
        public string ValueName { get; set; }
        public string Description { get; set; }
    }
}
