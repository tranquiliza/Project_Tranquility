using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.Entities
{
    public enum Status
    {
        New,
        InProgress,
        Completed,
        AwaitingApproval
    }

    public class MaintainanceTask : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? Start { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? Deadline { get; set; }
        public Staff Staff { get; set; }
        public decimal Price { get; set; }
        public bool IsPriority { get; set; }
        public Department Department { get; set; }
        //- SubTask Another Domain Entity - Not Sure how to handle these: Assuming they start the same day as the original task (On which they are attached)
        //Each have their own status, description, creation date is inherited.
        //Other properties are overwritten.
        //public subtask SubTask { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? CompletionDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? ApprovedDate { get; set; }
        public bool ApprovedComplete { get; set; }

    }
}
