using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Tranquility.Core.Repositories;
using Project_Tranquility.Core.Entities;

namespace Project_Tranquility.Core.Helpers
{
    public interface IUnitOfWork
    {
        IRepository<MaintainanceTask> Tasks { get; }
        void Commit();
    }
}
