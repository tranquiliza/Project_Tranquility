using System;
using System.Collections.Generic;
using System.Text;
using EntityFramework.Models;

namespace EntityFramework.Infrastructure
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private ApplicationContext _DbContext;
        
        public UnitOfWork(ApplicationContext context)
        {
            _DbContext = context;
        }


        private IGenericRepository<Task> _TaskRepository;
        public IGenericRepository<Task> TaskRepository
        {
            get
            {
                return _TaskRepository ?? (_TaskRepository = new GenericRepository<Task>(_DbContext));
            }
        }


        public void Commit()
        {
            try
            {
                _DbContext.Commit();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        #region IDispoable
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _DbContext.Dispose();
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
