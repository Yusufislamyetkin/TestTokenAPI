using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAuthServer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        //Temel IRepository Yapısı Bu Repository ile temel crud işlemleri gibi eylem ve sorguları burada gerçekleştiririz.
        //Task olarak belirtmemizin sebebi işlemin ASYNC olması.
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        void Remove(T entity);
        void Update(T entity);
        IQueryable<T> Where(Expression<Func<T, bool>> filter);
         
         

    }
}
