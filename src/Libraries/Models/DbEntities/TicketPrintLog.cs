using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class TicketPrintLog
    {
        public string OrderId { get; set; }
        public string PrintedBy { get; set; }
        public DateTime PrintedDate { get; set; }
        public int PrintCount { get; set; }
        public int? TicketCounter { get; set; }
    }
}
