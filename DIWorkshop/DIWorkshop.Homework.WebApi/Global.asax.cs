using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using DIWorkshop.Homework.WebApi.Controllers;
using Autofac;

namespace DIWorkshop.Homework.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
                GlobalConfiguration.Configure(WebApiConfig.Register);

        }
    }
}
