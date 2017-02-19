using System;
using Project_Tranquility.Core.Data;

namespace Project_Tranquility.Core.Services
{
    public interface IService : IDisposable
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
