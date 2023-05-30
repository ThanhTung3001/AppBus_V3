using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class ReceiptConfig
    {
        public int Id { get; set; }
        public string TaiKhoanPhatHanh { get; set; }
        public string MatKhauPhatHanh { get; set; }
        public string TaiKhoanDichVu { get; set; }
        public string MatKhauDichVu { get; set; }
        public string PublishServiceUrl { get; set; }
        public string PortalServiceUrl { get; set; }
        public string BusinessServiceUrl { get; set; }
    }
}
