using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels
{
    public enum Status
    {
        New,
        InProgress,
        Completed,
        AwaitingApproval
    }

    public class MaintainanceTask : BaseEntity
    {
        #region Properties
        public virtual string Name { get; private set; }
        public virtual string Description { get; private set; }
        public virtual Status Status { get; private set; }
        public virtual DateTime? Start { get; private set; }
        public virtual DateTime? Deadline { get; private set; }
        public virtual Staff Staff { get; private set; }
        public virtual decimal Price { get; private set; }
        public virtual bool IsPriority { get; private set; }
        public virtual Department Department { get; private set; }
        //- SubTask Another Domain Entity - Not Sure how to handle these: Assuming they start the same day as the original task (On which they are attached)
        //Each have their own status, description, creation date is inherited.
        //Other properties are overwritten.
        //public subtask SubTask { get; set; }
        public virtual DateTime CreationDate { get; private set; }
        public virtual DateTime? CompletionDate { get; private set; }
        public virtual DateTime? ApprovedDate { get; private set; }
        public virtual bool ApprovedComplete { get; private set; }
        public virtual int? UserId { get; private set; }
        #endregion

        //Constructor for EF?
        private MaintainanceTask()
        {
        }

        public MaintainanceTask(string name, string description, decimal price, bool isPriority = false, Staff staff = null, Department department = null, int? userId = null)
        {
            Name = name;
            Description = description;
            Price = price;
            IsPriority = IsPriority;


            CreationDate = DateTime.Now;
            Status = Status.AwaitingApproval;
            Staff = staff;
            Department = department;
            UserId = userId;
        }

        public void SetStatus(Status newStatus)
        {
            Status = newStatus;
        }
    }
}
