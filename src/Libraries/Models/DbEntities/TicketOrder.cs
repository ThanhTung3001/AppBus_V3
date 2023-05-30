using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class TicketOrder
    {
        public Guid Id { get; set; }
        public decimal? TotalPrice { get; set; }
        public string OrderTempId { get; set; }
        public int? PayStatus { get; set; }
        public string IsDelete { get; set; }
        public string IsUsed { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string IsForeign { get; set; }
        public string IsCash { get; set; }
        public string PaymentId { get; set; }
        public string IsSell { get; set; }
        public string ReceiptId { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? PayType { get; set; }
        /// <summary>
        /// 1 là in chung
        /// 2 là in riêng
        /// </summary>
        public int? PrintType { get; set; }
        public int? CounterId { get; set; }
        public string Remark { get; set; }
        public string IsUsePosMachine { get; set; }
    }
}
