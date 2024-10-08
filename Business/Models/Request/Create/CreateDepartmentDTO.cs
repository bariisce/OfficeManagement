using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CreateDepartmentDTO
    {
        public string Name { get; set; } = default!;
        public List<Employee> Employees { get; set; } = default!;
    }
}
