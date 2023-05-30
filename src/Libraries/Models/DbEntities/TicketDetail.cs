using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class TicketDetail
    {
        public int Id { get; set; }
        public Guid? TicketId { get; set; }
        public int? PlaceId { get; set; }
        public int? ServiceId { get; set; }
        public int? EventId { get; set; }
        public int? ChildrenQuantity { get; set; }
        public int? AdultQuantity { get; set; }
        public string OrderId { get; set; }
        public int? CustomerType { get; set; }
        public int? Quantity { get; set; }
        public int? QuantityRemain { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public int? TicketTypeId { get; set; }
        public int? QrId { get; set; }
    }
}
