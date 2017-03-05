using Project_Tranquility.Core.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Tranquility.Web.Models.ProjectManagerViewModels
{
    public class IndexViewModel
    {
        public PaginatedList<MaintainanceTask> Tasks { get; set; }
    }
}