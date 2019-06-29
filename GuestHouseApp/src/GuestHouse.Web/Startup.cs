using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using GuestHouse.Web.App_Start;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(GuestHouse.Web.Startup))]
namespace GuestHouse.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            // Create builder and register dependency modules.
            var builder = new ContainerBuilder();
            builder.RegisterModule<WebModule>();

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            // Configure the HttpConfiguration for WebApi
            WebApiConfig.Register(config);

            // Instruct OWIN to use WebApi
            app.UseWebApi(config);
        }
    }
}
