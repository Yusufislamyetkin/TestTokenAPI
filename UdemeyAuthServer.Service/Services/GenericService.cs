using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UdemyAuthServer.Core.Repositories;
using UdemyAuthServer.Core.Services;
using UdemyAuthServer.Core.UnitOfWork;

namespace UdemeyAuthServer.Service.Services
{
    public class GenericService<T, TDto> : IGenericService<T, TDto> where T : class where TDto : class
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<T> _genericRepository;

        public GenericService(IUnitOfWork unitOfWork, IGenericRepository<T> genericRepository)
        {
            _unitOfWork = unitOfWork;
            _genericRepository = genericRepository;
        }

        public async Task<Response<TDto>> AddAsync(TDto entity)
        {
            var newEntity = ObjectMapper.Mapper.Map<T>(entity);
            await _genericRepository.AddAsync(newEntity);
            await _unitOfWork.SaveChangesAsync();
            var newDto = ObjectMapper.Mapper.Map<TDto>(newEntity);
            return Response<TDto>.Success(newDto, 200);
        }

        public async Task<Response<IEnumerable<TDto>>> GetAllAsync()
        {
            var products = ObjectMapper.Mapper.Map<List<TDto>>(await _genericRepository.GetAllAsync());

            return Response<IEnumerable<TDto>>.Success(products, 200);
        }

        public async Task<Response<TDto>> GetByIdAsync(int id)
        {
            var product = await _genericRepository.GetByIdAsync(id);
            if (product == null)
            {
                return Response<TDto>.Fail("Id not found", 404, true);

            }
            return Response<TDto>.Success(ObjectMapper.Mapper.Map<TDto>(product), 200);


        }

        public async Task<Response<NoDataDto>> Remove(int id)
        {
            var product = await _genericRepository.GetByIdAsync(id);
            if (product == null)
            {
                return Response<NoDataDto>.Fail("Id Not Found", 404, true);
            }
            else
            {
                _genericRepository.Remove(product);
                await _unitOfWork.SaveChangesAsync();
                return Response<NoDataDto>.Success(204);
            }
        }

        public async Task<Response<NoDataDto>> Update(int id,TDto entity)
        {
            var product = _genericRepository.GetByIdAsync(id);
            if (product == null)
            {
               return Response<NoDataDto>.Fail("Id not found.", 404, true);

            }
            else
            {
                _genericRepository.Update(ObjectMapper.Mapper.Map<T>(entity));
               await  _unitOfWork.SaveChangesAsync();
                return Response<NoDataDto>.Success( 204);
            }
        }

        public Task<Response<IEnumerable<TDto>>> Where(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
