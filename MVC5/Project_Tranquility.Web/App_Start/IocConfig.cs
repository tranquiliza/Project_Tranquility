using Autofac;
using Autofac.Integration.Mvc;
using Project_Tranquility.Core.Data;
using Project_Tranquility.Core.Logging;
using Project_Tranquility.Core.Services;
using Project_Tranquility.Data;
using Project_Tranquility.Infrastructure.Logging;
using Project_Tranquility.Services;
using Project_Tranquility.Web;
using System.Web.Mvc;

//[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(IocConfig), "RegisterDependencies")]
namespace Project_Tranquility.Web
{
    public class IocConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();
            //AppContext
            //Data Source=(localdb)/ProjectsV13;Initial Catalog=TestBed;Integrated Security=True;
            const string dbConnectionString = "name=AppContext";

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
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

            builder.Register(b => NLogLogger.Instance).SingleInstance();
            builder.RegisterModule(new IdentityModule());
            //This continues to throw an exception trying to load an earlier version than what is installed.
            // how to fix?
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}