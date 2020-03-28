namespace TradersPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TraderUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Traders", "BusinessName", c => c.String());
            AddColumn("dbo.Traders", "ContactFirstName", c => c.String());
            AddColumn("dbo.Traders", "ContactLastName", c => c.String());
            AddColumn("dbo.Traders", "Telephone", c => c.String());
            AddColumn("dbo.Traders", "Mobile", c => c.String());
            AddColumn("dbo.Traders", "Email", c => c.String());
            DropColumn("dbo.Traders", "TraderName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Traders", "TraderName", c => c.String());
            DropColumn("dbo.Traders", "Email");
            DropColumn("dbo.Traders", "Mobile");
            DropColumn("dbo.Traders", "Telephone");
            DropColumn("dbo.Traders", "ContactLastName");
            DropColumn("dbo.Traders", "ContactFirstName");
            DropColumn("dbo.Traders", "BusinessName");
        }
    }
}
