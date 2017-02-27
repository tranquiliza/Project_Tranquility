using Project_Tranquility.Core.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Tranquility.Web.Models
{
    public class TaskViewModel
    {
        public List<MaintainanceTask> Tasks { get; set; }
    }
}