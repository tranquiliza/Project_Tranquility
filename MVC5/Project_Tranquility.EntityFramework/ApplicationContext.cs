using Microsoft.AspNet.Identity.EntityFramework;
using Project_Tranquility.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.EntityFramework
{
    public class ApplicationContext : DbContext
    {
        private static string DefaultConnection = "Data Source=DESKTOP-UE3MGBI;Initial Catalog=Project_Tranquility;Integrated Security=True;";
        public ApplicationContext() : base(DefaultConnection)
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.AddFromAssembly(typeof(EntityFramework.))

            //modelBuilder.Configurations.Add(new EntityConfiguration());
        }

        public DbSet<MaintainanceTask> Tasks { get; set; }

        public void Commit()
        {
            base.SaveChanges();
        }
        
    }
}
