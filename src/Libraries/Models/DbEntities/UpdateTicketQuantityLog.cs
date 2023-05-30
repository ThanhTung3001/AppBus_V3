using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class UpdateTicketQuantityLog
    {
        public int Id { get; set; }
        public int? OldValue { get; set; }
        public int? NewValue { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string OrderId { get; set; }
        public int? TicketTypeId { get; set; }
        public int? CustomerType { get; set; }
    }
}
