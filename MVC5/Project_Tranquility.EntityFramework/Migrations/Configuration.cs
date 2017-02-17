namespace Project_Tranquility.EntityFramework.Migrations
{
    using Project_Tranquility.Core.Entities;
    using System;
    using System.Collections.Generic;
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
            var department = new Department
            {
                Name = "Development"
            };

            var employee = new Staff
            {
                Name = "Daniel Olsen",
                Department = department
            };

            var listOfTask = new List<MaintainanceTask>();
            for (int i = 0; i < 10; i++)
            {
                listOfTask.Add(new MaintainanceTask
                {
                    Name = "Task" + i,
                    Description = "Test Task Number " + i,
                    IsPriority = false,
                    Status = Status.New,
                    Staff = employee,
                    Department = department,
                    CreationDate = DateTime.Now,
                    Price = 0,
                    ApprovedComplete = false
                });
            }
            context.Tasks.AddRange(listOfTask);
        }
    }
}
