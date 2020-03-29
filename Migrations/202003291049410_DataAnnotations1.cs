namespace TradersPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Traders", "Mobile", c => c.String(nullable: false));
            AlterColumn("dbo.Traders", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Traders", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Traders", "Mobile", c => c.String());
        }
    }
}
