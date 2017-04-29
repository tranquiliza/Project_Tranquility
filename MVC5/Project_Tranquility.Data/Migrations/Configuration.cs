namespace Project_Tranquility.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Project_Tranquility.Core.DomainModels;
    using Project_Tranquility.Data.Identity;
    using Project_Tranquility.Data.Identity.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Project_Tranquility.Data.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Project_Tranquility.Data.ApplicationContext context)
        {
            InitializeIdentityForEF(context);
            base.Seed(context);
        }

        public void InitializeIdentityForEF(ApplicationContext context)
        {
            // This is only for testing purpose
            string name = "admin@admin.com";
            string password = "123456";
            string roleName = "Developer";
            var applicationRoleManager = IdentityFactory.CreateRoleManager(context);
            var applicationUserManager = IdentityFactory.CreateUserManager(context);

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
            context.SaveChanges();

        }
    }
}
