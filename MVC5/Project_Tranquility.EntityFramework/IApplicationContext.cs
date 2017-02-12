using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Tranquility.EntityFramework.Models;
using System.Data.Entity;

namespace Project_Tranquility.EntityFramework
{
    public interface IApplicationContext
    {
        DbSet<MaintainanceTask> Tasks { get; set; }
        void Commit();
    }
}
