using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using OnlineSociety.DataService;
using OnlineSociety.DataService.Tables;
using System.Reflection;
using System.Web.Http;

namespace OnlineSociety.App_Start
{
    public class AutofacConfig
    {
        public static void Register()
        {
            var bldr = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;
            bldr.RegisterApiControllers(Assembly.GetExecutingAssembly());
            RegisterServices(bldr);
            bldr.RegisterWebApiFilterProvider(config);
            bldr.RegisterWebApiModelBinderProvider();
            var container = bldr.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static void RegisterServices(ContainerBuilder bldr)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserMappingProfile());
                cfg.AddProfile(new PetMappingProfile());
            });

            bldr.RegisterInstance(config.CreateMapper())
                .As<IMapper>()
                .SingleInstance();

            bldr.RegisterType<OnlineSocietyContext>()
              .InstancePerRequest();

            bldr.RegisterType<UsersTable>()
              .As<IUsersTable>()
              .InstancePerRequest();
        }
    }
}