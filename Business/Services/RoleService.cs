using Business.Models.Request.Create;
using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;
using Core.Results;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using Infrastructure.Data.Postgres.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class RoleService : BaseService<Role, int, ResponseRoleDTO>, IRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapperHelper _mapperHelper;
        private readonly IRoleRepository _repository;
        public RoleService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper, IRoleRepository repository) : base(unitOfWork, unitOfWork.Roles, mapperHelper)
        {
            _unitOfWork = unitOfWork;
            _mapperHelper = mapperHelper;
            _repository = repository;
        }

        public async Task<Result> AddFromDTOAsync(CreateRoleDTO requestDTO, int roleId)
        {
            if (requestDTO.IsAdmin && !await IsUserAdminAsync(roleId))
            {
                return Result.Failure("Only admin users can assign admin roles.");
            }

            var role = _mapperHelper.Map<Role>(requestDTO);
            await _repository.AddAsync(role);
            await _unitOfWork.CommitAsync();

            return Result.Success();
        }

        private async Task<bool> IsUserAdminAsync(int userId)
        {
            // Implement your logic to check if the user is an admin.
            var user = await _unitOfWork.Roles.FirstOrDefaultAsync(u => u.Id == userId);
            return user?.IsAdmin ?? false;
        }
    }
}
