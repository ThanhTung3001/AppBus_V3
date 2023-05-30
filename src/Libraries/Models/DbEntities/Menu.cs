using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Menu
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string IsActive { get; set; }
        public string Path { get; set; }
        public int? DisplayOrder { get; set; }
        public string IsLeaf { get; set; }
        public string IsAdminTool { get; set; }
    }
}
