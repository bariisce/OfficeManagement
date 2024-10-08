using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class ResponseEmployeeRoleDTO
    {
        public int EmployeeId { get; set; }
        public ResponseEmployeeDTO Employee { get; set; } = default!;
        public int RoleId { get; set; }
        public ResponseRoleDTO Role { get; set; } = default!;
    }
}
