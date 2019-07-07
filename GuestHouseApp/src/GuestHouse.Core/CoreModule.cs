using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using GuestHouse.Core.Contracts;
using GuestHouse.Core.Infrastructure;

namespace GuestHouse.Core
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<WebConfiguration>().As<IConfiguration>().InstancePerLifetimeScope();
            builder.RegisterType<Logger>().As<ILogger>().InstancePerLifetimeScope();
            builder.RegisterModule<LoggingModule>();
        }
    }
}
