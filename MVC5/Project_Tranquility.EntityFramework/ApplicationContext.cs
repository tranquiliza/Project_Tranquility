using Project_Tranquility.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.EntityFramework
{

    public class ApplicationContext : DbContext, IApplicationContext
    {
        private static string _ConnString = "Data Source=DESKTOP-UE3MGBI;Initial Catalog=Project_Tranquility;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public ApplicationContext() : base(_ConnString)
        {
        }

        public DbSet<MaintainanceTask> Tasks { get; set; }

        public void Commit()
        {
            base.SaveChanges();
        }
    }
}
