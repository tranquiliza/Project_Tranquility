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
    internal sealed class ApplicationDbInitializer : MigrateDatabaseToLatestVersion<ApplicationContext, Migrations.Configuration> //DropCreateDatabaseAlways<ApplicationContext>
    {   
    }
}
