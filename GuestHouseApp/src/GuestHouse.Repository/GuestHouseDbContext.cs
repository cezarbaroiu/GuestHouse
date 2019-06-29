using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestHouse.Core.Models;

namespace GuestHouse.Repository
{
    public class GuestHouseDbContext : DbContext
    {
        public GuestHouseDbContext() : base("name=GuestHouseConnection")
        {
            
        }

        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<Building> Building { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Used to discover all types that inherit EntityTypeConfiguration and register them
           // modelBuilder.Configurations.AddFromAssembly(this.GetType().Assembly);
        }
    }
}
