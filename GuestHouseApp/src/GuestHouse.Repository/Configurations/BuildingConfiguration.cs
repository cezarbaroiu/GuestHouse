using System.Data.Entity.ModelConfiguration;
using GuestHouse.Entities;


namespace GuestHouse.Repository.Configurations
{
    public class BuildingConfiguration : EntityTypeConfiguration<Building>
    {
        public BuildingConfiguration()
        {
            ToTable("Building");

            HasKey(c => c.Id);

            HasMany(c => c.Rooms)
                .WithRequired(b => b.Building)
                .HasForeignKey(b => b.BuildingId);
        }
    }
}