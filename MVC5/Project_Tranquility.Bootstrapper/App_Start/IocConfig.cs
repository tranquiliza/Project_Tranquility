using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Tranquility.Bootstrapper;
using Project_Tranquility.Core.Data;
using Project_Tranquility.Core.Logging;
using Project_Tranquility.Core.Services;
using Project_Tranquility.Data;
using Project_Tranquility.Services;
using System.Web.Mvc;
//using Project_Tranquility.Web;

namespace Project_Tranquility.Bootstrapper.App_Start
{
    public class IocConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();
            const string dbConnectionString = "Data Source=(localdb)/ProjectsV13;Initial Catalog=TestBed;Integrated Security=True;";

            //builder.RegisterControllers(typeof(MvcApplication).Assembly); TODO
            builder.RegisterModule<AutofacWebTypesModule>();
            builder.RegisterGeneric(typeof(EntityRepository<>)).As(typeof(IRepository<>)).InstancePerRequest();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerRequest();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();
            builder.Register<IEntitiesContext>(b =>
            {
                var logger = b.Resolve<ILogger>();
                var context = new ApplicationContext(dbConnectionString, logger);
                return context;
            }).InstancePerRequest();

            //builder.Register(b => NLogLogger.Instance).SingleInstance(); TODO
            builder.RegisterModule(new IdentityModule());

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}
