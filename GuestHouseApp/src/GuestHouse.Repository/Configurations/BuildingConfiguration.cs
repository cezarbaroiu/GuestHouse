using System.Data.Entity.ModelConfiguration;
using GuestHouse.Core.Models;

namespace GuestHouse.Repository.Mapping
{
    public class BuildingMapping : EntityTypeConfiguration<Building>
    {
        public BuildingMapping()
        {
            ToTable("Building");

            HasKey(c => c.BuildingId);

            HasMany(c => c.Rooms)
                .WithRequired(b => b.Building)
                .HasForeignKey(b => b.BuildingId);
        }
    }
}
