using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class OrderInvoice
    {
        public string Fid { get; set; }
        public string OrderId { get; set; }
        public int? InvoiceId { get; set; }
        public int? Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Pattern { get; set; }
        public string Serial { get; set; }
        public string CusCode { get; set; }
        public string BuyerName { get; set; }
        public int? TotalAmount { get; set; }
        public string TaxCode { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
