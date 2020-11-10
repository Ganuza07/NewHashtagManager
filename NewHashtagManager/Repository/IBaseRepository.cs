using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewHashtagManager.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        T Add(T entity);
        IQueryable<T> GetAll();
        IEnumerable<T> GetQuery(Func<T, bool> expression);
        T GetById(Guid entity);
        void Delete(Guid entity);
        T Update(T entity);
        void Save();
    }
}