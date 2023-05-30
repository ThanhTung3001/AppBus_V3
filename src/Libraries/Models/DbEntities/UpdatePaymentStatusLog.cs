using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class UpdatePaymentStatusLog
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
        public string MsgType { get; set; }
        public string TxnId { get; set; }
        public string QrTrace { get; set; }
        public string BankCode { get; set; }
        public string Mobile { get; set; }
        public string AccountNo { get; set; }
        public string Amount { get; set; }
        public string PayDate { get; set; }
        public string Checksum { get; set; }
        public string CreatedDate { get; set; }
    }
}
