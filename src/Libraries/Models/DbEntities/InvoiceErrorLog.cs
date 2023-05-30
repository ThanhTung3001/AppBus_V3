using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class InvoiceErrorLog
    {
        public int Id { get; set; }
        public string Fid { get; set; }
        public string OrderId { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
