using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class TicketCounter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? DisplayOrder { get; set; }
        public string IsActive { get; set; }
        public int? TicketTypeId { get; set; }
    }
}
