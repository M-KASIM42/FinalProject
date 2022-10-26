using Microsoft.EntityFrameworkCore;
using PercistanceLayer.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PercistanceLayer.DAL.EfCore
{
    public class BaseRepository<T> : IEntityRepository<T>
        where T : class, new()
    {
        public void Add(T entity)
        {
            using(var context = new BigCompanyDbContext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = new BigCompanyDbContext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (var _context = new BigCompanyDbContext())
            {
                return filter == null ?
                    _context.Set<T>().ToList() :
                    _context.Set<T>().Where(filter).ToList();
            }

        }

        public T GetT(Expression<Func<T, bool>> filter)
        {
            using (var context = new BigCompanyDbContext())
            {
                return context.Set<T>().SingleOrDefault(filter);
            }
        }

        public void Update(T entity)
        {
            using (var context = new BigCompanyDbContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }


}
