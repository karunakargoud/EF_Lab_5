namespace EF_Lab_5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstTime : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brand",
                c => new
                    {
                        BrandId = c.Int(nullable: false, identity: true),
                        BrandName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.BrandId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        ProductName = c.String(nullable: false, maxLength: 50),
                        Quantity = c.String(nullable: false, maxLength: 15),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoryId = c.Int(nullable: false),
                        BranndId = c.Int(nullable: false),
                        ProductTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Brand", t => t.BranndId, cascadeDelete: true)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.ProductType", t => t.ProductTypeId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.BranndId)
                .Index(t => t.ProductTypeId);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryId = c.Int(nullable: false),
                        CName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.ProductType",
                c => new
                    {
                        ProductTypeId = c.Int(nullable: false),
                        PTName = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.ProductTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "ProductTypeId", "dbo.ProductType");
            DropForeignKey("dbo.Product", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.Product", "BranndId", "dbo.Brand");
            DropIndex("dbo.Product", new[] { "ProductTypeId" });
            DropIndex("dbo.Product", new[] { "BranndId" });
            DropIndex("dbo.Product", new[] { "CategoryId" });
            DropTable("dbo.ProductType");
            DropTable("dbo.Category");
            DropTable("dbo.Product");
            DropTable("dbo.Brand");
        }
    }
}
