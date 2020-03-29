namespace TradersPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Traders", "BusinessName", c => c.String(nullable: false));
            AlterColumn("dbo.Traders", "ContactFirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Traders", "ContactLastName", c => c.String(nullable: false));
            AlterColumn("dbo.Traders", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Traders", "RegistrationDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Traders", "RegistrationDate", c => c.DateTime());
            AlterColumn("dbo.Traders", "Email", c => c.String());
            AlterColumn("dbo.Traders", "ContactLastName", c => c.String());
            AlterColumn("dbo.Traders", "ContactFirstName", c => c.String());
            AlterColumn("dbo.Traders", "BusinessName", c => c.String());
        }
    }
}
