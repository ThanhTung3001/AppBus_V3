using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class StatisticTemplateRole
    {
        public int Id { get; set; }
        public int TemplateId { get; set; }
        public int RoleId { get; set; }
    }
}
