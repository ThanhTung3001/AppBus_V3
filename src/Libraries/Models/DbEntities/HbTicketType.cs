using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class HbTicketType
    {
        public HbTicketType()
        {
            HbTicketPrices = new HashSet<HbTicketPrice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int? UpdateById { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? CreatedById { get; set; }
        public bool? IsVeTuyen { get; set; }
        public string ListEventId { get; set; }
        public bool? Active { get; set; }
        public int TypeValue { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int? DateToExpired { get; set; }
        public int? NumberOfDayCanUse { get; set; }
        public int? ImageId { get; set; }

        public virtual ICollection<HbTicketPrice> HbTicketPrices { get; set; }
    }
}
