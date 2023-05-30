using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class UserCartDetail
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int TicketTypeId { get; set; }
        public int? CustommerTypeId { get; set; }
        public int? Quantity { get; set; }
        public int? CustomerType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
