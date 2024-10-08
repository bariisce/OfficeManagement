using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.AspNetCore.Mvc;
using OfficeManagement.Controllers.Base;

namespace OfficeManagement.Controllers
{
    public class RoleController : BaseCRUDController<Role, int, CreateRoleDTO, UpdateRoleDTO, ResponseRoleDTO>
    {
        public RoleController(IRoleService service) : base(service)
        {
            
        }
    }
}
