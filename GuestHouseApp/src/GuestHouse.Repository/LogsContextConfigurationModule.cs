using System.Data.Entity;
using GuestHouse.Core.Contracts;
using GuestHouse.Repository.Configurations;

namespace GuestHouse.Repository
{
    public class LogsContextConfigurationModule : IConfigurationModule
    {
        public void Register(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LogConfiguration());
        }
    }
}
