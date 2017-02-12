using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Models
{
    public enum Status
    {
        New,
        InProgress,
        Complete,
        AwaitingApproval
    }

    public class Task
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Status? Status { get; set; }
    }
}
