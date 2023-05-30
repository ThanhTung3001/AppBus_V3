using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class TicketUsedLog
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public int? TicketTypeId { get; set; }
        public DateTime? UsedDate { get; set; }
        public string IsUsed { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
