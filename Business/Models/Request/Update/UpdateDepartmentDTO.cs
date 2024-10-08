using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class UpdateDepartmentDTO
    {
        public string Name { get; set; } = default!;
        public ICollection<Employee> Employees { get; set; } = default!;
    }
}
