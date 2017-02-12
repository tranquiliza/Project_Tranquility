using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.Infrastructure
{
    public interface IGenericRepository<T> where T : class
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

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //This will be our repos base.
        //Will also have UnitofWork
        //Mappers from EF -> Business Layer -> Service -> Presentation Layer.
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Attach(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public T Single(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
