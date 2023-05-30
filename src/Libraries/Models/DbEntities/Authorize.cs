using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Authorize
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public int? RoleId { get; set; }
        public string Username { get; set; }
        public string IsAuthorize { get; set; }
        public Guid? UserId { get; set; }
    }
}
