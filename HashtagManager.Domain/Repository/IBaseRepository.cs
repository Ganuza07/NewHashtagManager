using System;
using System.Collections.Generic;
using System.Linq;

namespace NewHashtagManager.Domain.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        T Add(T entity);
        IQueryable<T> GetAll();
        T GetById(Guid entity);
        IEnumerable<T> GetQuery(Func<T, bool> expression);
        void Delete(Guid entity);
        T Update(T entity);
        void Save();
    }
}