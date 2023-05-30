using System;

namespace WebApi.Models
{
    public partial class HbNhatKy
    {
        public int Id { get; set; }
        public int? XeId { get; set; }
        public short? TramId { get; set; }
        public DateTime? ThoiDiemDen { get; set; }
        public DateTime? ThoiDiemDi { get; set; }
        /// <summary>
        /// Lý do trễ chuyến: 0 – Đúng giờ (mặc định); 1 – Tắc đường; 2 – Xe hỏng; 3 – Tai nạn; 4 – Khác
        /// </summary>
        public byte? LyDo { get; set; }
        public string GhiChu { get; set; }

        public virtual HbDiem Tram { get; set; }
        public virtual HbXe Xe { get; set; }
    }
}
