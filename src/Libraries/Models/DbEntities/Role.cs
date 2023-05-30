using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Role
    {
        public Role()
        {
            Employees = new HashSet<Employee>();
        }
        public int Id { get; set; }
        public string RoleName { get; set; }
        public DateTime CreatedTime { get; set; }
        public int UpdateById { get; set; }
        public DateTime UpdateTime { get; set; }
        public int CreatedById { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
