using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Models
{
    public class Task
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<SubTask> SubTasks { get; set; }
    }
}
