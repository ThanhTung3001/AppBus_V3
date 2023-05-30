using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class UpdatePaymentStatusLogDetail
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public string ProductId { get; set; }
        public string Amount { get; set; }
        public string TipAndFee { get; set; }
        public string Ccy { get; set; }
        public string Qty { get; set; }
        public string Note { get; set; }
    }
}
