using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class HbTicketPrice
    {
        public HbTicketPrice()
        {
            HbBangGiaVes = new HashSet<HbBangGiaVe>();
            HbCartDetails = new HashSet<HbCartDetail>();
        }

        public int Id { get; set; }
        public int CustomerTypeId { get; set; }
        public int TiketTypeId { get; set; }
        public int Price { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? UpdateById { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string IsActive { get; set; }

        public virtual HbCustomerType CustomerType { get; set; }
        public virtual HbTicketType TiketType { get; set; }
        public virtual ICollection<HbBangGiaVe> HbBangGiaVes { get; set; }
        public virtual ICollection<HbCartDetail> HbCartDetails { get; set; }
    }
}
