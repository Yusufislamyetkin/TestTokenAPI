﻿using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAuthServer.Core.Services
{
    public interface IGenericService<T, TDto> where T : class where TDto : class
    {
        Task<Response<TDto>> GetByIdAsync(int id);
        Task<Response<IEnumerable<TDto>>> GetAllAsync();
        Task<Response<IEnumerable<TDto>>> Where(Expression<Func<T, bool>> filter);
        Task<Response<TDto>> AddAsync(TDto entity);
        Task<Response<NoDataDto>> Remove(int id);
        Task<Response<NoDataDto>> Update(int id,TDto entity);

    }
}
