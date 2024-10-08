using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.AspNetCore.Mvc;
using OfficeManagement.Controllers.Base;

namespace OfficeManagement.Controllers
{
    public class EmployeeController : BaseCRUDController<Employee, int, CreateEmployeeDTO, UpdateEmployeeDTO, ResponseEmployeeDTO>
    {
        public EmployeeController(IEmployeeService service) : base(service)
        {
            
        }
    }
}
