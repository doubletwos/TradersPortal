namespace TradersPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StateAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.States",
                c => new
                    {
                        StateId = c.Int(nullable: false, identity: true),
                        StateName = c.String(),
                    })
                .PrimaryKey(t => t.StateId);
            
            AddColumn("dbo.Traders", "StateId", c => c.Int(nullable: false));
            CreateIndex("dbo.Traders", "StateId");
            AddForeignKey("dbo.Traders", "StateId", "dbo.States", "StateId", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Traders", "StateId", "dbo.States");
            DropIndex("dbo.Traders", new[] { "StateId" });
            DropColumn("dbo.Traders", "StateId");
            DropTable("dbo.States");
        }
    }
}
