﻿using System;
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
    public class ApplicationDbInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            InitializeIdentityForEF(context);
            base.Seed(context);
        }

        public void InitializeIdentityForEF(ApplicationContext db)
        {
            // This is only for testing purpose
            const string name = "admin@admin.com";
            const string password = "Admin@123456";
            const string roleName = "Admin";
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
            var context = new ApplicationContext("name=AppContext", new DebugLogger());
            //var image = new Image { Path = "http://lorempixel.com/400/200/" };
            //context.Set<Image>().Add(image);
            //for (var i = 0; i < 100; i++)
            //{
            //    context.Set<Product>().Add(new Product { Name = "My Product", Description = "My Product", Image = image });
            //}
            context.SaveChanges();

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
