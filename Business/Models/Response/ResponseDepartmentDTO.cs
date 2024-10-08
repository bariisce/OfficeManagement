using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class ResponseDepartmentDTO
    {
        public int Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public ICollection<Employee> Employees { get; set; } = default!;

    }
}
