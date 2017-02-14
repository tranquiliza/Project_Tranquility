using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Tranquility.Core.Entities;

namespace Project_Tranquility.EntityFramework
{
    public class ApplicationContext : DbContext
    {
        private static string DefaultConnection = "Data Source=DESKTOP-UE3MGBI;Initial Catalog=Project_Tranquility;Integrated Security=True;";
        public ApplicationContext() : base(DefaultConnection)
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<MaintainanceTask> Tasks { get; set; }

        public void Commit()
        {
            base.SaveChanges();
        }
    }
}
