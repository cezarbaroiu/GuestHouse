using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using GuestHouse.Core.Repository;
using GuestHouse.Core.Services;
using GuestHouse.Services.Services;

namespace GuestHouse.Services
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BuildingServices>().As<IBuildingServices>().InstancePerLifetimeScope();
            builder.RegisterType<RoomServices>().As<IRoomServices>().InstancePerLifetimeScope();
        }
    }
}
