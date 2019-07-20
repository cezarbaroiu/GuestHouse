namespace GuestHouse.Repository
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UnknownChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Logs", "AdditionalIdentifier", c => c.String());
            AlterColumn("dbo.Logs", "Message", c => c.String(nullable: false, maxLength: 4000));
            AlterColumn("dbo.Logs", "Level", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Logs", "Exception", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Logs", "Logger", c => c.String(maxLength: 100));
            AlterColumn("dbo.Logs", "AdditionalData", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Logs", "AdditionalData", c => c.String());
            AlterColumn("dbo.Logs", "Logger", c => c.String());
            AlterColumn("dbo.Logs", "Exception", c => c.String());
            AlterColumn("dbo.Logs", "Level", c => c.String());
            AlterColumn("dbo.Logs", "Message", c => c.String());
            DropColumn("dbo.Logs", "AdditionalIdentifier");
        }
    }
}
