using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestHouse.Core.Models;
namespace GuestHouse.Repository.Mapping
{
    public class RoomMapping : EntityTypeConfiguration<Room>
    {
        public RoomMapping()
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
