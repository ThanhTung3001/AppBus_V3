using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class HbCustomer
    {
        public HbCustomer()
        {
            HbCarts = new HashSet<HbCart>();
            HbGopies = new HashSet<HbGopY>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime CreatedTime { get; set; }
        public int UpdateById { get; set; }
        public DateTime UpdateTime { get; set; }
        public string CreatedById { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<HbCart> HbCarts { get; set; }
        public virtual ICollection<HbGopY> HbGopies { get; set; }
    }
}
