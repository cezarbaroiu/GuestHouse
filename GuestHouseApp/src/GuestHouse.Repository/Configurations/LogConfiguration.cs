using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using GuestHouse.Entities;

namespace GuestHouse.Repository.Configurations
{
    public class LogConfiguration : EntityTypeConfiguration<Log>
    {
        public LogConfiguration()
        {
            ToTable(Tables.Logs);

            HasKey(c => c.Id);

            Property(x => x.Level).HasColumnName("Level").HasMaxLength(20).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Logger).HasColumnName("Logger").HasMaxLength(100).IsOptional()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.AdditionalData).HasColumnName("AdditionalData").HasMaxLength(1000).IsOptional()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Exception).HasColumnName("Exception").HasMaxLength(1000).IsOptional()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Message).HasColumnName("Message").HasMaxLength(4000).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.TimeStamp).HasColumnName("Timestamp").IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
