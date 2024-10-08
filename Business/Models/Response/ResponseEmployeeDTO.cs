using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class ResponseEmployeeDTO
    {
        public int Id { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string FullName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public ResponseDepartmentDTO Department { get; set; } = default!;
        public ICollection<ResponseEmployeeRoleDTO> EmployeeRoles { get; set; } = default!;
    }
}
