namespace GuestHouse.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Building",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        RoomId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Room",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RoomName = c.String(nullable: false, maxLength: 50),
                        NumberOfPersons = c.Int(nullable: false),
                        PricePerNight = c.Decimal(nullable: false, precision: 8, scale: 2),
                        HasOwnBathroom = c.Boolean(nullable: false),
                        Description = c.String(),
                        BuildingId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Building", t => t.BuildingId, cascadeDelete: true)
                .Index(t => t.BuildingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Room", "BuildingId", "dbo.Building");
            DropIndex("dbo.Room", new[] { "BuildingId" });
            DropTable("dbo.Room");
            DropTable("dbo.Building");
        }
    }
}
