using System.Data.Entity;
using GuestHouse.Repository.Configurations;
using GuestHouse.Repository.Contracts;

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
