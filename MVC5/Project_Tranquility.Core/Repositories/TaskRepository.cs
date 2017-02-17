using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Tranquility.Core.Helpers;
using Project_Tranquility.Core.Entities;

namespace Project_Tranquility.Core.Repositories
{
    public class TaskRepository
    {
        private readonly IUnitOfWork _UnitOfWork;
        private IRepository<MaintainanceTask> _TaskRepository;

        public TaskRepository(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
            _TaskRepository = _UnitOfWork.Tasks;
        }

        public void Create(MaintainanceTask Task)
        {
            _TaskRepository.Add(Task);
        }

        public void Delete(int id)
        {
            var taskToDelete = _TaskRepository.First(m => m.Id == id);
            if (taskToDelete != null)
            {
                _TaskRepository.Delete(taskToDelete);
            }
            //Don't delete, just flag for delete possibly?
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
            return _TaskRepository.GetByID(id);
        }

        public void Update(MaintainanceTask Task)
        {
            _TaskRepository.Attach(Task);
        }
    }
}
