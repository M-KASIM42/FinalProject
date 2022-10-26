using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PercistanceLayer.DAL.Abstract
{
    public interface IEntityRepository<T> 
        where T : class, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetT(Expression<Func<T,bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
    }
}
