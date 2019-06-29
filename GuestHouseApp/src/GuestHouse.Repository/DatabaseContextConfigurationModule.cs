using System.Data.Entity;
using GuestHouse.Repository.Configurations;
using GuestHouse.Repository.Contracts;

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
