using System.Data.Entity.Migrations;

namespace GuestHouse.Repository
{
    public class LogContextConfiguration : DbMigrationsConfiguration<LogDatabaseContext>
    {
        public LogContextConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"LogsMigrations";
        }

        protected override void Seed(LogDatabaseContext context)
        {
             
        }
    }
}
