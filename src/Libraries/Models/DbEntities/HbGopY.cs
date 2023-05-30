using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class HbGopY
    {
        public HbGopY()
        {
            HbTepKemTheos = new HashSet<HbTepKemTheo>();
        }

        public int Id { get; set; }
        public byte? DoanhNghiepId { get; set; }
        public long? CustomerId { get; set; }
        public string NoiDung { get; set; }
        public DateTime? NgayGui { get; set; }
        /// <summary>
        /// 0 - Gửi doanh nghiệp; 1 - Gửi phản ảnh hiện trường HueS
        /// </summary>
        public bool? Loai { get; set; }
        public bool? TiepNhan { get; set; }

        public virtual HbCustomer Customer { get; set; }
        public virtual HbDoanhNghiep DoanhNghiep { get; set; }
        public virtual ICollection<HbTepKemTheo> HbTepKemTheos { get; set; }
    }
}
