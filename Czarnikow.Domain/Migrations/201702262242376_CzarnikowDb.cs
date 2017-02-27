namespace Czarnikow.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CzarnikowDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.Trades",
                c => new
                    {
                        TradeId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Amount = c.Double(nullable: false),
                        Qty = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.TradeId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trades", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Trades", "ClientId", "dbo.Clients");
            DropIndex("dbo.Trades", new[] { "ClientId" });
            DropIndex("dbo.Trades", new[] { "ProductId" });
            DropTable("dbo.Trades");
            DropTable("dbo.Products");
            DropTable("dbo.Clients");
        }
    }
}
