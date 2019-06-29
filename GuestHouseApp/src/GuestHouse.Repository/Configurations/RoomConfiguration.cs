using System.Data.Entity.ModelConfiguration;
using GuestHouse.Core.Models;

namespace GuestHouse.Repository.Configurations
{
    public class RoomConfiguration : EntityTypeConfiguration<Room>
    {
        public RoomConfiguration()
        {
            ToTable("Room");

            HasKey(c => c.RoomId);

            Property(c => c.RoomName)
                .IsUnicode()
                .IsRequired()
                .HasMaxLength(50);
            Property(c => c.NumberOfPersons)
                .IsRequired()
                .HasColumnType("int");
            Property(c => c.HasOwnBathroom)
                .IsRequired();
            Property(c => c.PricePerNight)
                .HasPrecision(8, 2)
                .IsRequired();
            Property(c => c.Description)
                .IsUnicode()
                .IsOptional();

        }
    }
}
