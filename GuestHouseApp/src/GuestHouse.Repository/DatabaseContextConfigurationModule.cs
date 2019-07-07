using System.Data.Entity;
using GuestHouse.Core.Contracts;
using GuestHouse.Repository.Configurations;

namespace GuestHouse.Repository
{
    public class DatabaseContextConfigurationModule : IConfigurationModule
    {
        public void Register(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BuildingConfiguration());
            modelBuilder.Configurations.Add(new RoomConfiguration());
        }
    }
}
