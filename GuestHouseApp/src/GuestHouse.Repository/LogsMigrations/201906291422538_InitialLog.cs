namespace GuestHouse.Repository
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialLog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TimeStamp = c.DateTime(nullable: false),
                        Message = c.String(),
                        Level = c.String(),
                        Exception = c.String(),
                        Logger = c.String(),
                        AdditionalData = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Logs");
        }
    }
}
