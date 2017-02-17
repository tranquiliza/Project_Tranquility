using Project_Tranquility.Core.Entities;
using Project_Tranquility.Core.Helpers;
using Project_Tranquility.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.Services
{
    public interface ITaskService
    {
        void CommitChanges();
        IEnumerable<MaintainanceTask> GetAll();
        void Create(MaintainanceTask Task);
        void Update(MaintainanceTask Task);
        MaintainanceTask GetById(int id);
        void Delete(int id);
        void Delete(MaintainanceTask Task);
    }
    public class TaskService : ITaskService
    {
        private readonly IUnitOfWork _UnitOfWork;
        private TaskRepository _TaskRepository;

        public TaskService(IUnitOfWork unitOfWork, TaskRepository taskRepository)
        {
            _UnitOfWork = unitOfWork;
            _TaskRepository = taskRepository;
        }

        public void Create(MaintainanceTask Task)
        {
            _TaskRepository.Create(Task);
        }

        public void Delete(int id)
        {
            _TaskRepository.Delete(id);//Don't delete, just flag for delete possibly?
        }

        public void Delete(MaintainanceTask Task)
        {
            _TaskRepository.Delete(Task);
        }

        public IEnumerable<MaintainanceTask> GetAll()
        {
            return _TaskRepository.GetAll();
        }

        public MaintainanceTask GetById(int id)
        {
            return _TaskRepository.GetById(id);
        }

        public void Update(MaintainanceTask Task)
        {
            _TaskRepository.Update(Task);
        }

        public void CommitChanges()
        {
            _UnitOfWork.Commit();
        }
    }
}
