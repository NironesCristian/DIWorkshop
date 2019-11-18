using Autofac;
using DIWorkshop.Entities;
using DIWorkshop.Homework.WebApi.Controllers;
using DIWorkshop.Managers;
using DIWorkshop.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace DIWorkshop.Homework.WebApi
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DriverController>();
            builder.RegisterType<DbContext>().SingleInstance();
            builder.RegisterType<DriverManager>().As<IDriverManager>();
            builder.RegisterType<Driver>().As<IDriver>();
            builder.RegisterType<Car>().As<ICar>();
            builder.RegisterType<DriverRepository>().As<IDriverRepository>();
            builder.RegisterType<CarRepository>().As<ICarRepository>();


            return builder.Build();
        }
    }
}