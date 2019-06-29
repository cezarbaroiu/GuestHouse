using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Integration.WebApi;
using GuestHouse.Core;
using GuestHouse.Repository;
using GuestHouse.Services;
using Module = Autofac.Module;

namespace GuestHouse.Web
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<CoreModule>();
            builder.RegisterModule<RepositoryModule>();
            builder.RegisterModule<ServicesModule>();

            // Register your WebApi Controllers
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // Optional: register the Autofac model binder provider
            builder.RegisterWebApiModelBinderProvider();
        }
    }
}
