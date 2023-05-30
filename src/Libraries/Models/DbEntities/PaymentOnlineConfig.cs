using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class PaymentOnlineConfig
    {
        public int Id { get; set; }
        public string TextName { get; set; }
        public string TextValue { get; set; }
        public string Description { get; set; }
        public string IsActive { get; set; }
    }
}
