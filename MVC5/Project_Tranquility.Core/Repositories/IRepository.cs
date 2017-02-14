using Project_Tranquility.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Attach(T entity);
        void Delete(T entity);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T First(Expression<Func<T, bool>> predicate);
        IEnumerable<T> Get(
                Expression<Func<T, bool>> filter = null,
                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                string includeProperties = "");
        IEnumerable<T> GetAll();
        T GetByID(int id);
        T Single(Expression<Func<T, bool>> predicate);
        T SingleOrDefault(Expression<Func<T, bool>> predicate);
    }
}
