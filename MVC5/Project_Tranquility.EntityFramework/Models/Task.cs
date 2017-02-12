using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.EntityFramework.Models
{
    public enum Status
    {
        New,
        InProgress,
        Completed,
        AwaitingApproval
    }

    public class MaintainanceTask
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
    }
}
