using System;
using System.Collections.Generic;
using System.Text;
using EntityFramework.Models;

namespace EntityFramework.Infrastructure
{
    public interface IUnitOfWork
    {
        IGenericRepository<Task> TaskRepository { get; }
        void Commit();
    }
}
