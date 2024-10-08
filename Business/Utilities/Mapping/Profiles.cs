using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Mapping
{
    public class Profiles : AutoMapper.Profile
    {
        public Profiles()
        {
            CreateMap<Department, ResponseDepartmentDTO>()
                .ForMember(dest => dest.Employees, opt => opt.MapFrom(src => src.Employees));
            CreateMap<CreateDepartmentDTO, Department>();
            CreateMap<UpdateDepartmentDTO, Department>();

            CreateMap<Employee, ResponseEmployeeDTO>()
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department));
            CreateMap<CreateEmployeeDTO, Employee>();
            CreateMap<UpdateEmployeeDTO, Employee>();

            CreateMap<Role, ResponseRoleDTO>()
                .ForMember(dest=>dest.EmployeeRoles, opt=>opt.MapFrom(src=>src.EmployeeRoles));
            CreateMap<CreateRoleDTO, Role>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.EmployeeRoles, opt => opt.Ignore());
            CreateMap<UpdateRoleDTO, Role>();

            CreateMap<EmployeeRole, ResponseEmployeeRoleDTO>()
                .ForMember(dest=>dest.EmployeeId, opt=>opt.MapFrom(src=>src.EmployeeId))
                .ForMember(dest=>dest.RoleId, opt=>opt.MapFrom(src=>src.RoleId));
        }
    }
}
