using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Project_Tranquility.Core.DomainModels;
using Project_Tranquility.Core.Logging;
using Project_Tranquility.Data.Identity;
using Project_Tranquility.Data.Identity.Models;
using System.Data.Entity.Infrastructure;

namespace Project_Tranquility.Data
{
    public class ApplicationDbInitializer : DropCreateDatabaseIfModelChanges<ApplicationContext> //DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            InitializeIdentityForEF(context);
            InitializeTaskManagerForEF(context);
            base.Seed(context);
        }

        public void InitializeTaskManagerForEF(ApplicationContext db)
        {
            var userManager = IdentityFactory.CreateUserManager(db);

            var Department = new Department
            {
                Name = "Development"
            };

            var Staff = new Staff
            {
                Name = "Daniel Olsen",
                Department = Department
            };

            var amountOfTasks = 100;
            var listOfTasks = new List<MaintainanceTask>();
            for (int i = 0; i < amountOfTasks; i++)
            {

                listOfTasks.Add(new MaintainanceTask("Task" + i, "Description", 0, false));
            }
            var newTask = new MaintainanceTask("New Task", "Desc", 0, false, Staff);
            newTask.SetStatus(Status.New);

            var inProgressTask = new MaintainanceTask("InProgress Task", "Desc", 0, false, null, Department);
            inProgressTask.SetStatus(Status.InProgress);

            var completedTask = new MaintainanceTask("Completed Task", "Desc", 0, false, null, Department);
            completedTask.SetStatus(Status.Completed);

            var awaitingApprovalTask = new MaintainanceTask("Awaiting Approval Task", "Desc", 55.2m, false, null, null, 1);
            awaitingApprovalTask.SetStatus(Status.AwaitingApproval);

            var context = new ApplicationContext("name=AppContext", new DebugLogger());
            db.Set<Department>().Add(Department);
            db.Set<Staff>().Add(Staff);


            db.Set<MaintainanceTask>().Add(newTask);
            db.Set<MaintainanceTask>().Add(inProgressTask);
            db.Set<MaintainanceTask>().Add(completedTask);
            db.Set<MaintainanceTask>().Add(awaitingApprovalTask);


            for (int i = 0; i < listOfTasks.Count; i++)
            {
                db.Set<MaintainanceTask>().Add(listOfTasks[i]);
            }
            


            db.SaveChanges();
        }

        public void InitializeIdentityForEF(ApplicationContext db)
        {
            // This is only for testing purpose
            string name = "admin@admin.com";
            string password = "Admin123";
            string roleName = "Developer";
            var applicationRoleManager = IdentityFactory.CreateRoleManager(db);
            var applicationUserManager = IdentityFactory.CreateUserManager(db);

            //Create Role Admin if it does not exist
            var role = applicationRoleManager.FindByName(roleName);
            if (role == null)
            {
                role = new ApplicationIdentityRole { Name = roleName };
                applicationRoleManager.Create(role);
            }

            var user = applicationUserManager.FindByName(name);
            if (user == null)
            {
                user = new ApplicationIdentityUser { UserName = name, Email = name };
                applicationUserManager.Create(user, password);
                applicationUserManager.SetLockoutEnabled(user.Id, false);
            }

            // Add user admin to Role Admin if not already added
            var rolesForUser = applicationUserManager.GetRoles(user.Id);
            if (!rolesForUser.Contains(role.Name))
            {
                applicationUserManager.AddToRole(user.Id, role.Name);
            }
            db.SaveChanges();

        }

        class DebugLogger : ILogger
        {
            public void Log(Exception ex)
            {

            }

            public void Log(string message)
            {

            }
        }
    }
}
