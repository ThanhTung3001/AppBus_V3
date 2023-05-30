using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class UserCard
    {
        public Guid Id { get; set; }
        public string OrderId { get; set; }
        public string CardHolderName { get; set; }
        public string Pan { get; set; }
        public int? AmountAuthorized { get; set; }
        public string ApplicationLabel { get; set; }
        public string AuthCode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
