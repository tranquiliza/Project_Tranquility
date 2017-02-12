using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityFramework.Models;

namespace EntityFramework
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureCreated();
            if (context.Tasks.Any())
            {

                //return;
            }

            var tasks = new Task[]
            {
                new Task { Name="New",                  Description = "New Task",                   Status = Status.New },
                new Task { Name="In Progress",          Description = "A task in Progress",         Status = Status.InProgress },
                new Task { Name="Completed Task",       Description = "A task that is complete",    Status = Status.Complete },
                new Task { Name="Awaiting Approval",    Description = "Task awaiting Approval",     Status = Status.AwaitingApproval }
            };

            foreach (Task t in tasks)
            {
                context.Tasks.Add(t);
            }

            context.SaveChanges();
        }
    }
}
