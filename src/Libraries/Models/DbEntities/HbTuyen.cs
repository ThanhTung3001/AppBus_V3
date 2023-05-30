using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class HbTuyen
    {
        public HbTuyen()
        {
            HbBangGiaVes = new HashSet<HbBangGiaVe>();
            HbLichTrinhs = new HashSet<HbLichTrinh>();
            HbTuyenDiems = new HashSet<HbTuyenDiem>();
        }

        public byte Id { get; set; }
        public string SoHieu { get; set; }
        public string TenTuyen { get; set; }
        public string MoTa { get; set; }
        public string DiemDau { get; set; }
        public string DiemCuoi { get; set; }
        public decimal? CuLy { get; set; }
        public string KhungGio { get; set; }
        public string TanSuat { get; set; }
        public byte? SoChuyen { get; set; }
        public bool? HoatDong { get; set; }
        public int? SoLuotThich { get; set; }

        public virtual ICollection<HbBangGiaVe> HbBangGiaVes { get; set; }
        public virtual ICollection<HbLichTrinh> HbLichTrinhs { get; set; }
        public virtual ICollection<HbTuyenDiem> HbTuyenDiems { get; set; }
    }
}
