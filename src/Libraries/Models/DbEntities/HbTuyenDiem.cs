namespace WebApi.Models
{
    public partial class HbTuyenDiem
    {
        public int Id { get; set; }
        public byte? TuyenId { get; set; }
        public short? DiemId { get; set; }
        public int? ThuTu { get; set; }
        /// <summary>
        /// 1 - Chiều đi; 0 - Chiều về
        /// </summary>
        public bool? ChieuDi { get; set; }

        public virtual HbDiem Diem { get; set; }
        public virtual HbTuyen Tuyen { get; set; }
    }
}
