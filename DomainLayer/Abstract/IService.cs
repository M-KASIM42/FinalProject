using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DomainLayer.Abstract
{
    public interface IService<T>
        where T : class, new()
    {
        void Add(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Update(T entity);
        void Delete(T entity);
    }
}
