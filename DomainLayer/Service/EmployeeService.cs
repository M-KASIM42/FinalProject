using DomainLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using PercistanceLayer.DAL.EfCore;
using PercistanceLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DomainLayer.Service
{
    public class EmployeeService : IEmployeeService
    {
        public void Add(Employee entity)
        {
            using (var context = new BigCompanyDbContext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Employee entity)
        {
            using (var context = new BigCompanyDbContext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Employee Get(Expression<Func<Employee, bool>> filter)
        {
            using (var context = new BigCompanyDbContext())
            {
                return context.Set<Employee>().SingleOrDefault(filter);
            }
        }

        public List<Employee> GetAll(Expression<Func<Employee, bool>> filter = null)
        {
            using (var context = new BigCompanyDbContext())
            {
                return filter == null ?
                        context.Set<Employee>().ToList() :
                        context.Set<Employee>().Where(filter).ToList();
            }
        }

        public void Update(Employee entity)
        {
            using (var context = new BigCompanyDbContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
