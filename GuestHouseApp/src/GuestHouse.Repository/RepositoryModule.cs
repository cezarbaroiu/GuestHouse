using Autofac;
using GuestHouse.Core.Repository;
using GuestHouse.Repository.Repositories;

namespace GuestHouse.Repository
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RoomRepository>().As<IRoomRepository>().InstancePerLifetimeScope();
            builder.RegisterType<BuildingRepository>().As<IBuildingRepository>().InstancePerLifetimeScope();
            
        }
    }
}
