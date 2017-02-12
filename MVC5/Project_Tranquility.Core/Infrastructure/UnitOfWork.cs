﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.Infrastructure
{
    public interface IUnitOfWork
    {
        IGenericRepository<MaintainanceTask>
        void Commit();
    }
    public class UnitOfWork : IUnitOfWork
    {
    }
}
