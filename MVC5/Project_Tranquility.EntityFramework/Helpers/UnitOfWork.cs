using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Tranquility.Core.Entities;
using Project_Tranquility.Core.Helpers;
using Project_Tranquility.Core.Repositories;
using Project_Tranquility.EntityFramework.Repositories;
using System.Data.Entity;

namespace Project_Tranquility.EntityFramework.Helpers
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _DbContext;
        private IRepository<MaintainanceTask> _TaskRepository;

        public UnitOfWork(DbContext context)
        {
            _DbContext = context;
        }

        #region .Repos.
        public IRepository<MaintainanceTask> Tasks
        {
            get
            {
                return _TaskRepository ?? (_TaskRepository = new Repository<MaintainanceTask>(_DbContext));
            }
        }
        #endregion

        public void Commit()
        {
            throw new NotImplementedException();
        }
    }
}
