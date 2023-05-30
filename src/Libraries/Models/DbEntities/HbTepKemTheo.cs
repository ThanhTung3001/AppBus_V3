using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class HbTepKemTheo
    {
        public int Id { get; set; }
        public byte? LoaiDoiTuong { get; set; }
        public int? DoiTuongId { get; set; }
        public string NoiLuuTru { get; set; }

        public virtual HbGopY DoiTuong { get; set; }
    }
}
