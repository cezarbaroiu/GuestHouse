using System.Data.Entity.Migrations;

namespace GuestHouse.Repository.Migrations
{
    public class DatabaseContextConfiguration : DbMigrationsConfiguration<DatabaseContext>
    {
        public DatabaseContextConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(DatabaseContext context)
        {
            
        }
    }
}
