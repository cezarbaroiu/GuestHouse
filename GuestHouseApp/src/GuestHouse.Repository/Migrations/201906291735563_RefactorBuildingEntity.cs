namespace GuestHouse.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactorBuildingEntity : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Building", "RoomId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Building", "RoomId", c => c.Guid(nullable: false));
        }
    }
}
