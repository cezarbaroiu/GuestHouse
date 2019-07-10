using System.Data.Entity;
using Autofac;

namespace GuestHouse.Repository
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DatabaseContext>().AsSelf().As<DbContext>().InstancePerLifetimeScope();
            builder.RegisterType<LogDatabaseContext>().AsSelf().InstancePerLifetimeScope();
        }
    }
}
