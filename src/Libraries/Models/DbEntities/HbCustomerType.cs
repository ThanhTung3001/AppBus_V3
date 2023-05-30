using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class HbCustomerType
    {
        public HbCustomerType()
        {
            HbTicketPrices = new HashSet<HbTicketPrice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? UpdateById { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? CreatedById { get; set; }
        public string ColorCode { get; set; }

        public virtual ICollection<HbTicketPrice> HbTicketPrices { get; set; }
    }
}
