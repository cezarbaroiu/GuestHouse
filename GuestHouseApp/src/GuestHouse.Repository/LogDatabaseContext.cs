using System.Data.Entity;
using GuestHouse.Entities;

namespace GuestHouse.Repository
{
    public class LogDatabaseContext : LogContextBase
    {
        public LogDatabaseContext() : base("name=GuestHouseLogsConnection", new LogsContextConfigurationModule())
        {
        }

        public virtual DbSet<Log> Logs { get; set; }
    }
}
