using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public int TicketTypeId { get; set; }
        public int Quantity { get; set; }
        public int? CustomerType { get; set; }
        public int UnitPrice { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
