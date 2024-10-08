using Business.Models.Request.Create;
using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;
using Core.Results;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class EmployeeService : BaseService<Employee, int, ResponseEmployeeDTO>, IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper, IEmployeeRepository employeeRepository) : base(unitOfWork, unitOfWork.Employees, mapperHelper)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Result> AddFromDtoAsync(CreateEmployeeDTO createEmployeeDto)
        {
            if (await _employeeRepository.EmailExistAsync(createEmployeeDto.Email))
            {
                return Result.Failure("This mail address already exist !");
            }

            var employee = new Employee
            {
                FirstName = createEmployeeDto.FirstName,
                LastName = createEmployeeDto.LastName,
                FullName = createEmployeeDto.FullName,
                Email = createEmployeeDto.Email,
                Phone = createEmployeeDto.Phone,
                DepartmentId = createEmployeeDto.DepartmentId
            };

            await _employeeRepository.AddAsync(employee);
            return Result.Success();
        }
    }
}
