using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class TicketScanLog
    {
        public string OrderId { get; set; }
        public int PlaceId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateUse { get; set; }
        public int CustomerTypeId { get; set; }
        public string IsSuccess { get; set; }
        public string Reason { get; set; }
        public string DeviceId { get; set; }
        public string Action { get; set; }
    }
}
