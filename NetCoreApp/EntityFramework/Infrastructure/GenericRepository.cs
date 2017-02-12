using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EntityFramework.Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private DbContext _Context;
        private DbSet<T> _DbSet;

        public GenericRepository(DbContext context)
        {
            _Context = context;
            _DbSet = context.Set<T>();
        }
        
        public void Add(T entity)
        {
            _DbSet.Add(entity);
        }

        public void Attach(T entity)
        {
            _DbSet.Attach(entity);
            _Context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _DbSet.Remove(entity);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _DbSet.Where(predicate);
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            return _DbSet.Where(predicate).First();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = _DbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in
                    includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _DbSet;
        }

        public T GetByID(int id)
        {
            return _DbSet.Find(id);
        }

        public T Single(Expression<Func<T, bool>> predicate)
        {
            return _DbSet.Where(predicate).Single();
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _DbSet.Where(predicate).SingleOrDefault();
        }
    }
}
