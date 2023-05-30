using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class HbCauHinh
    {
        public byte Id { get; set; }
        /// <summary>
        /// Thời gian đồng bộ dữ liệu phản ánh hiện trường (đơn vị: phút). 
        /// </summary>
        public short? PhanAnhHienTruong { get; set; }
        /// <summary>
        /// Thời gian đồng bộ dữ liệu tiện ích xung quanh (đơn vị: phút). 
        /// </summary>
        public short? TienIchXungQuanh { get; set; }
    }
}
