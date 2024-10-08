using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Employee : Entity<int>
    {
        public string FirstName { get; set; } = default!; 
        public string LastName { get; set;} = default!;
        public string FullName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = default!;

        public ICollection<EmployeeRole> EmployeeRoles { get; set; } = default!;
    }
}
