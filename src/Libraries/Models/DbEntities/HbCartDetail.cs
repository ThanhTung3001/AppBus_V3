using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class HbCartDetail
    {
        public HbCartDetail()
        {
            HbCarts = new HashSet<HbCart>();
        }

        public int Id { get; set; }
        public int CustomerTypeId { get; set; }
        public int TicketTypeId { get; set; }
        public int TicketPriceId { get; set; }
        public int Count { get; set; }
        public int CartId { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public virtual HbTicketPrice TicketPrice { get; set; }
        public virtual ICollection<HbCart> HbCarts { get; set; }
    }
}
