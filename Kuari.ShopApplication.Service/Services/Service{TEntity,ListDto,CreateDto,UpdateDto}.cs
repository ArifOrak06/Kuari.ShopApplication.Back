using Kuari.ShopApplication.Core.Repositories;
using Kuari.ShopApplication.Core.Services;
using Kuari.ShopApplication.Core.UnitOfWork;
using Kuari.ShopApplication.Repository.Contexts;
using Kuari.ShopApplication.Service.Mappings;
using Kuari.ShopApplication.SharedLibrary.ResponseResultPattern;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.ShopApplication.Service.Services
{
    internal class Service<TEntity, ListDto, CreateDto, UpdateDto> : IService<TEntity, ListDto, CreateDto, UpdateDto>
        where TEntity : class, new()
        where ListDto : class, new()
        where CreateDto : class, new()
        where UpdateDto : class, new()
    {
        private readonly IRepository<TEntity> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public Service(IRepository<TEntity> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<CustomResponseDto<CreateDto>> AddAsync(CreateDto createDto)
        {
            if (createDto == null)
            {
                return CustomResponseDto<CreateDto>.Fail(404, $"{createDto} bulunamamıştır.");
            }
            var addedEntity = ObjectMapper.Mapper.Map<TEntity>(createDto);
            await _repository.AddAsync(addedEntity);
            await _unitOfWork.CommitAsync();
            var newAddedDto = ObjectMapper.Mapper.Map<CreateDto>(addedEntity);

            return CustomResponseDto<CreateDto>.Success(200, newAddedDto); 
        }

        public async Task<CustomResponseDto<IEnumerable<CreateDto>>> AddRangeAsync(IEnumerable<CreateDto> createDto)
        {
            if (createDto == null)
            {
                return CustomResponseDto<IEnumerable<CreateDto>>.Fail(404, $"{createDto} listesi eklenme sırasında oluşan hata nedeniyle eklenememiştir.");
            }
            var newAddedListEntity = ObjectMapper.Mapper.Map<IEnumerable<TEntity>>(createDto);
            await _repository.AddRangeAsync(newAddedListEntity);
            await _unitOfWork.CommitAsync();
            var newAddedListDto = ObjectMapper.Mapper.Map<IEnumerable<CreateDto>>(newAddedListEntity);

            return CustomResponseDto<IEnumerable<CreateDto>>.Success(200, newAddedListDto);
            
        }

        public async Task<CustomResponseDto<NoContentDto>> DeleteAsync(int id)
        {
            var data = await _repository.GetByIdAsync(id);
            if (data == null)
            {
                return CustomResponseDto<NoContentDto>.Fail(404, $"Girilen {id} numaralı id'ye data bulunamaması nedeniyle silme işlemi başarısız olmuştur.");
            }
            _repository.Delete(data);
            await _unitOfWork.CommitAsync();

            return CustomResponseDto<NoContentDto>.Success(200);
        }

        public async Task<CustomResponseDto<IReadOnlyList<ListDto>>> GetAllAsync()
        {
            var data = await _repository.GetAllAsync();
            if (data == null)
            {
                return CustomResponseDto<IReadOnlyList<ListDto>>.Fail(404, "Data olmaması nedeniye listeleme başarısız");
            }
            var dataDtos = ObjectMapper.Mapper.Map<IReadOnlyList<ListDto>>(data);
            return CustomResponseDto<IReadOnlyList<ListDto>>.Success(200,dataDtos);
        }

        public async Task<CustomResponseDto<IEnumerable<ListDto>>> GetByFilterAsync(Expression<Func<TEntity, bool>> filter)
        {
            var data =  await _repository.GetByFilter(filter).ToListAsync();
            if (data == null)
            {
                return CustomResponseDto<IEnumerable<ListDto>>.Fail(404, "Filtreye uygun data bulunamamıştır.");
            }
            var dataDto = ObjectMapper.Mapper.Map<IEnumerable<ListDto>>(data);
            return CustomResponseDto<IEnumerable<ListDto>>.Success(200,dataDto);
            

        }

        public async Task<CustomResponseDto<ListDto>> GetByIdAsync(int id)
        {
            var data = await _repository.GetByIdAsync(id);
            if (data == null)
            {
                return CustomResponseDto<ListDto>.Fail(404, "Parametre olarak girilen id'ye sahip data bulunamamıştır.");
            }
            var dataDto = ObjectMapper.Mapper.Map<ListDto>(data);
            return CustomResponseDto<ListDto>.Success(200, dataDto);
        }

        public async Task<CustomResponseDto<UpdateDto>> UpdateAsync(UpdateDto updateDto, int id)
        {
            var unchangedEntity = await _repository.GetByIdAsync(id);
            if (unchangedEntity==null)
            {
                return CustomResponseDto<UpdateDto>.Fail(404, $"Girilen {id} numaralı id'ye sahip data bulunamaması nedeniyle güncelleme işlemi başarısızlıkla sonuçlanmıştır.");
            }
            if (updateDto == null)
            {
                return CustomResponseDto<UpdateDto>.Fail(404, "Eksik parametre gönderilmesi nedeniyle güncelleme işlemi başarısızlıkla sonuçlanmıştır.");
            }
            var updatedEntity = ObjectMapper.Mapper.Map<TEntity>(updateDto);
            _repository.Update(updatedEntity);
            await _unitOfWork.CommitAsync();
            var newUpdatedDto = ObjectMapper.Mapper.Map<UpdateDto>(updatedEntity);
            return CustomResponseDto<UpdateDto>.Success(200, newUpdatedDto);
        }
    }
}
