using System.Data.Entity;
using GuestHouse.Entities;

namespace GuestHouse.Repository
{
    public class DatabaseContext : DbContextBase
    {
        public DatabaseContext() : 
            base("name=GuestHouseConnection", new DatabaseContextConfigurationModule())
        {
        }

        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<Building> Building { get; set; }
    }
}
