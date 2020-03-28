namespace TradersPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Traders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Traders",
                c => new
                    {
                        TraderId = c.Int(nullable: false, identity: true),
                        TraderName = c.String(),
                        RegistrationDate = c.DateTime(),
                        TradeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TraderId)
                .ForeignKey("dbo.Trades", t => t.TradeId, cascadeDelete: false)
                .Index(t => t.TradeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Traders", "TradeId", "dbo.Trades");
            DropIndex("dbo.Traders", new[] { "TradeId" });
            DropTable("dbo.Traders");
        }
    }
}
