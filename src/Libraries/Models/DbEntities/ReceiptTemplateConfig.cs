using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class ReceiptTemplateConfig
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IsActive { get; set; }
    }
}
