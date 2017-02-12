using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework
{
    public interface IApplicationContext
    {
        DbSet<Task> Tasks { get; set; }
        void Commit();
    }
}
