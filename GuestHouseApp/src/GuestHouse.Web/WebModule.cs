using System.Reflection;
using Autofac;
using Autofac.Integration.WebApi;
using GuestHouse.Core;
using GuestHouse.Core.Infrastructure;
using GuestHouse.Repository;
using GuestHouse.Services;
using Module = Autofac.Module;

namespace GuestHouse.Web
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<LoggingModule>();
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
