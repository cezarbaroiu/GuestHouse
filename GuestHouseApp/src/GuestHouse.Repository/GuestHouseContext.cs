using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestHouse.Repository
{
    public class GuestHouseContext : DbContext
    {
        public GuestHouseContext() : base("name=GuestHouseConnection")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Used to discover all types that inherit EntityTypeConfiguration and register them
            modelBuilder.Configurations.AddFromAssembly(this.GetType().Assembly);
        }
    }
}
