using Autofac;
using Autofac.Integration.WebApi;
using DIWorkshop.Homework.WebApi.Controllers;
using DIWorkshop.Interfaces;
using DIWorkshop.Managers;
using DIWorkshop.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DIWorkshop.Homework.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var builder = new ContainerBuilder();

            builder.RegisterType<DbContext>().SingleInstance();
            builder.RegisterType<DriverController>();
            builder.RegisterType<CarRepository>().As<ICarRepository>();
            builder.RegisterType<DriverRepository>().As<IDriverRepository>();
            builder.RegisterType<DriverManager>().As<IDriverManager>();

            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            config.DependencyResolver = resolver;

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
