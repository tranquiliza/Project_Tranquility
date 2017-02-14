namespace Project_Tranquility.EntityFramework.Migrations
{
    using Project_Tranquility.Core.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Project_Tranquility.EntityFramework.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Project_Tranquility.EntityFramework.ApplicationContext context)
        {
            var tasks = new MaintainanceTask[]
            {
                new MaintainanceTask { Name = "New", Description = "New Task", Status = Status.New },
                new MaintainanceTask { Name = "In Progress", Description = "In Progress Task", Status = Status.InProgress },
                new MaintainanceTask { Name = "Completed", Description = "Completed Task", Status = Status.Completed },
                new MaintainanceTask { Name = "Awaiting Approval", Description = "Awaiting Approval Task", Status = Status.AwaitingApproval }
            };

            context.Tasks.AddRange(tasks);
        }
    }
}
