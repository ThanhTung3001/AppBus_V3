namespace WebApi.Models
{
    public partial class HbBangGiaVe
    {
        public int Id { get; set; }
        public byte? DoanhNghiepId { get; set; }
        public byte? TuyenId { get; set; }
        public int? TicketPriceId { get; set; }

        public virtual HbDoanhNghiep DoanhNghiep { get; set; }
        public virtual HbTicketPrice TicketPrice { get; set; }
        public virtual HbTuyen Tuyen { get; set; }
    }
}
