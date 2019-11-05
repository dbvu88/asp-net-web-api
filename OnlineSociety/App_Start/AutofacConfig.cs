﻿using Autofac;
using Autofac.Integration.WebApi;
using OnlineSociety.Data;
using OnlineSociety.Model;
using OnlineSociety.Model.UsersTbl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
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

            bldr.RegisterType<OnlineSocietyContext>()
              .InstancePerRequest();

            bldr.RegisterType<UsersTbl>()
              .As<IUsersTbl>()
              .InstancePerRequest();
        }
    }
}