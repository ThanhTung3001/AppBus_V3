using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class HbDoanhNghiep
    {
        public HbDoanhNghiep()
        {
            HbBangGiaVes = new HashSet<HbBangGiaVe>();
            HbGopies = new HashSet<HbGopY>();
            HbXes = new HashSet<HbXe>();
        }

        public byte Id { get; set; }
        public string MaSoThue { get; set; }
        public string Ten { get; set; }
        public string GioiThieu { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string HopThu { get; set; }
        public string TrangChu { get; set; }

        public string ViTri {get;set;}
        public bool? HoatDong { get; set; }

        public virtual ICollection<HbBangGiaVe> HbBangGiaVes { get; set; }
        public virtual ICollection<HbGopY> HbGopies { get; set; }
        public virtual ICollection<HbXe> HbXes { get; set; }
    }
}
