using System;

namespace WebApi.Models
{
    public partial class HbLichTrinh
    {
        public int Id { get; set; }
        public int? XeId { get; set; }
        public byte? TuyenId { get; set; }
        /// <summary>
        /// 1 - Chiều đi; 0 - Chiều về
        /// </summary>
        public bool? ChieuDi { get; set; }
        public TimeSpan? GioDi { get; set; }
        public TimeSpan? GioDen { get; set; }

        public virtual HbTuyen Tuyen { get; set; }
        public virtual HbXe Xe { get; set; }
    }
}
