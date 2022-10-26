using DomainLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using PercistanceLayer.DAL.EfCore;
using PercistanceLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Service
{
    public class EmployeeDetailService : IEmployeeDetailService
    {
        public void Add(EmployeeDetail entity)
        {
            using (var context = new BigCompanyDbContext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(EmployeeDetail entity)
        {
            using (var context = new BigCompanyDbContext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public EmployeeDetail Get(Expression<Func<EmployeeDetail, bool>> filter)
        {
            using (var context = new BigCompanyDbContext())
            {
                return context.Set<EmployeeDetail>().SingleOrDefault(filter);
            }
        }

        public List<EmployeeDetail> GetAll(Expression<Func<EmployeeDetail, bool>> filter = null)
        {
            using (var context = new BigCompanyDbContext())
            {
                return filter == null ?
                        context.Set<EmployeeDetail>().ToList() :
                        context.Set<EmployeeDetail>().Where(filter).ToList();
            }
                
            
        }

        public void Update(EmployeeDetail entity)
        {
            using (var context = new BigCompanyDbContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
