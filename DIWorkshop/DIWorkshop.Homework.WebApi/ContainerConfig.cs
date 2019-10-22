using Autofac;
using DIWorkshop.Homework.WebApi.Controllers;
using DIWorkshop.Managers;
using DIWorkshop.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIWorkshop.Homework.WebApi
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DriverManager>().As<IDriverManager>();
            builder.RegisterType<DriverController>();
            builder.RegisterType<DriverRepository>().As<IDriverRepository>();
            builder.RegisterType<DbContext>().SingleInstance();

            return builder.Build();
        }
    }
}