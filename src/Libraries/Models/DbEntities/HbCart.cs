using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class HbCart
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public int CartDetailId { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public virtual HbCartDetail CartDetail { get; set; }
        public virtual HbCustomer Customer { get; set; }
    }
}
