using Autofac;
using DIWorkshop.Homework.WebApi.Controllers;
using DIWorkshop.Interfaces;
using DIWorkshop.Managers;
using DIWorkshop.Persistence;

namespace DIWorkshop.Homework.WebApi
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DbContext>().SingleInstance();
            builder.RegisterType<DriverController>();
            builder.RegisterType<CarRepository>().As<ICarRepository>();
            builder.RegisterType<DriverRepository>().As<IDriverRepository>();
            builder.RegisterType<DriverManager>().As<IDriverManager>();

            return builder.Build();
        }
    }
}