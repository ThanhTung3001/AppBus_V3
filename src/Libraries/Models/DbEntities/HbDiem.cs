using System.Collections.Generic;
using Models.DbEntities;

namespace WebApi.Models
{
    public class HbDiem : BaseEntity
    {
        public HbDiem()
        {
            HbNhatKies = new HashSet<HbNhatKy>();
            HbTuyenDiems = new HashSet<HbTuyenDiem>();
        }

        //  public short Id { get; set; }
        public string SoHieu { get; set; }
        public string DiaDiem { get; set; }
        public bool? HoatDong { get; set; }

        public string? ViTri { get; set; }

        public double ?Lat { get; set; }

        public double ?Long { get; set; }

        public virtual ICollection<HbNhatKy> HbNhatKies { get; set; }
        public virtual ICollection<HbTuyenDiem> HbTuyenDiems { get; set; }
    }
}
