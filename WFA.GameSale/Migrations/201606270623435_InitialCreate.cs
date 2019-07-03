namespace WFA.GameSale.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        GameName = c.String(),
                        GamePrice = c.Int(nullable: false),
                        Sales_SaleId = c.Int(),
                    })
                .PrimaryKey(t => t.GameId)
                .ForeignKey("dbo.Sales", t => t.Sales_SaleId)
                .Index(t => t.Sales_SaleId);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        SaleId = c.Int(nullable: false, identity: true),
                        GameId = c.Int(nullable: false),
                        PlayerId = c.Int(nullable: false),
                        BuyMoney = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SaleId);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        PlayerId = c.Int(nullable: false, identity: true),
                        PlayerName = c.String(),
                        PlayerMail = c.String(),
                        Password = c.String(),
                        PlayerAccount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RegistrationDate = c.DateTime(nullable: false),
                        Sales_SaleId = c.Int(),
                    })
                .PrimaryKey(t => t.PlayerId)
                .ForeignKey("dbo.Sales", t => t.Sales_SaleId)
                .Index(t => t.Sales_SaleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "Sales_SaleId", "dbo.Sales");
            DropForeignKey("dbo.Games", "Sales_SaleId", "dbo.Sales");
            DropIndex("dbo.Players", new[] { "Sales_SaleId" });
            DropIndex("dbo.Games", new[] { "Sales_SaleId" });
            DropTable("dbo.Players");
            DropTable("dbo.Sales");
            DropTable("dbo.Games");
        }
    }
}
