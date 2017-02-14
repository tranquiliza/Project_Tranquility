using System;
using System.Collections.Generic;
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
    }
}
