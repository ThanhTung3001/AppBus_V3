using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class SubOrderDetail
    {
        public Guid Id { get; set; }
        public string OrderId { get; set; }
        public int? TicketTypeId { get; set; }
        public int? Quantity { get; set; }
        public int? CustomerType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? OrderQuantity { get; set; }
        public int? QrId { get; set; }
    }
}
