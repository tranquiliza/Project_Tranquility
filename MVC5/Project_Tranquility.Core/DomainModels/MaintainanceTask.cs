using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        //public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Status Status { get; set; }
        [DataType(DataType.DateTime)]
        public virtual DateTime? Start { get; set; }
        [DataType(DataType.DateTime)]
        public virtual DateTime? Deadline { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual decimal Price { get; set; }
        public virtual bool IsPriority { get; set; }
        public virtual Department Department { get; set; }
        //- SubTask Another Domain Entity - Not Sure how to handle these: Assuming they start the same day as the original task (On which they are attached)
        //Each have their own status, description, creation date is inherited.
        //Other properties are overwritten.
        //public subtask SubTask { get; set; }
        [DataType(DataType.DateTime)]
        public virtual DateTime CreationDate { get; set; }
        [DataType(DataType.DateTime)]
        public virtual DateTime? CompletionDate { get; set; }
        [DataType(DataType.DateTime)]
        public virtual DateTime? ApprovedDate { get; set; }
        public virtual bool ApprovedComplete { get; set; }

        //Constructor for EF?
        private MaintainanceTask()
        {
        }
        public MaintainanceTask(string name, string description, decimal price, bool isPriority = false, Staff staff = null, Department department = null)
        {
            Name = name;
            Description = description;
            Price = price;
            IsPriority = IsPriority;

            //set creationDate
            CreationDate = DateTime.Now;
            //set status to default?
            Status = Status.AwaitingApproval;
        }
    }
}
