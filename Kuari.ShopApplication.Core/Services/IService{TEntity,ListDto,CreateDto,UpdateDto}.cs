using Kuari.ShopApplication.SharedLibrary.ResponseResultPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.ShopApplication.Core.Services
{
    public interface IService<TEntity,ListDto,CreateDto,UpdateDto>
        where TEntity : class,new()
        where ListDto : class,new()
        where CreateDto : class,new()
        where UpdateDto : class,new()
    {
        Task<CustomResponseDto<IReadOnlyList<ListDto>>> GetAllAsync();
        Task<CustomResponseDto<ListDto>> GetByIdAsync(int id);
        Task<CustomResponseDto<IEnumerable<ListDto>>> GetByFilterAsync(Expression<Func<TEntity,bool>> filter);
        Task<CustomResponseDto<CreateDto>> AddAsync(CreateDto createDto);
        Task<CustomResponseDto<IEnumerable<CreateDto>>> AddRangeAsync(IEnumerable<CreateDto> createDto);
        Task<CustomResponseDto<NoContentDto>> DeleteAsync(int id);
        Task<CustomResponseDto<UpdateDto>> UpdateAsync(UpdateDto updateDto, int id);

    }
}
