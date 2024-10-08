using Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Base.Interface
{
    public interface IBaseService<TEntity, TId, TResponseDTO> where TEntity : class where TResponseDTO : class
    {
        Task<DataResult<TResponseDTO>> GetByIdAsync(TId id);
        Task<DataResult<IList<TResponseDTO>>> GetAllAsync();
        Task<Result> AddAsync(TEntity entity);
        Task<Result> AddFromDtoAsync(object entityDTO);
        Task<Result> UpdateAsync(TId id, object entityDTO);
        Task<Result> DeleteAsync(TId id);

    }
}
