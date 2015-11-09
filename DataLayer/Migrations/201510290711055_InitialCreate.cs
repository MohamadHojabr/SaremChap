namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chapters",
                c => new
                    {
                        ChapterId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ChapterId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        ChapterId = c.Int(nullable: false),
                        Authors = c.String(nullable: false),
                        SubjectLead = c.String(nullable: false),
                        SubjectContent = c.String(nullable: false),
                        SubjectImage = c.String(nullable: false),
                        Status = c.Int(nullable: false),
                        SubjectDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SubjectId)
                .ForeignKey("dbo.Chapters", t => t.ChapterId, cascadeDelete: true)
                .Index(t => t.ChapterId);
            
            CreateTable(
                "dbo.Fields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TitleEn = c.String(),
                        TitleFa = c.String(),
                        RequiredField = c.Boolean(nullable: false),
                        DisabledField = c.Boolean(nullable: false),
                        EffectivePrice = c.Boolean(nullable: false),
                        Options = c.String(),
                        Finance = c.Decimal(precision: 18, scale: 2),
                        FieldType = c.Int(nullable: false),
                        FormId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Forms", t => t.FormId, cascadeDelete: true)
                .Index(t => t.FormId);
            
            CreateTable(
                "dbo.Forms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fa_Title = c.String(nullable: false),
                        En_Title = c.String(nullable: false),
                        Product_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_ID, cascadeDelete: true)
                .Index(t => t.Product_ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductCategoryID = c.Int(nullable: false),
                        name = c.String(nullable: false),
                        imege = c.String(nullable: false),
                        describtion = c.String(nullable: false),
                        Form_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Forms", t => t.Form_Id)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCategoryID, cascadeDelete: true)
                .Index(t => t.Form_Id)
                .Index(t => t.ProductCategoryID);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        priceID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        neme = c.String(nullable: false),
                        Quantity = c.Int(nullable: false),
                        value = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.priceID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        ProductCategoryID = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        imege = c.String(nullable: false),
                        describtion = c.String(nullable: false),
                        SuperCategory = c.Int(),
                    })
                .PrimaryKey(t => t.ProductCategoryID);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        GalleryId = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        describtion = c.String(),
                    })
                .PrimaryKey(t => t.GalleryId);
            
            CreateTable(
                "dbo.GalleryItems",
                c => new
                    {
                        GalleryItemId = c.Int(nullable: false, identity: true),
                        GalleryId = c.Int(nullable: false),
                        name = c.String(nullable: false),
                        describtion = c.String(),
                        url = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GalleryItemId)
                .ForeignKey("dbo.Galleries", t => t.GalleryId, cascadeDelete: true)
                .Index(t => t.GalleryId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 160),
                        LastName = c.String(nullable: false, maxLength: 160),
                        Address = c.String(nullable: false, maxLength: 70),
                        PostalCode = c.String(nullable: false, maxLength: 10),
                        Phone = c.String(maxLength: 24),
                        Mobile = c.String(nullable: false, maxLength: 24),
                        Email = c.String(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubmitFormId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.Values",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Val = c.String(),
                        Date = c.DateTime(nullable: false),
                        SubmitId = c.Int(nullable: false),
                        FieldId = c.Int(nullable: false),
                        FormId = c.Int(nullable: false),
                        Order_OrderID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fields", t => t.FieldId, cascadeDelete: true)
                .ForeignKey("dbo.Forms", t => t.FormId)
                .ForeignKey("dbo.Orders", t => t.Order_OrderID)
                .Index(t => t.FieldId)
                .Index(t => t.FormId)
                .Index(t => t.Order_OrderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Values", "Order_OrderID", "dbo.Orders");
            DropForeignKey("dbo.Values", "FormId", "dbo.Forms");
            DropForeignKey("dbo.Values", "FieldId", "dbo.Fields");
            DropForeignKey("dbo.GalleryItems", "GalleryId", "dbo.Galleries");
            DropForeignKey("dbo.Forms", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.Products", "ProductCategoryID", "dbo.ProductCategories");
            DropForeignKey("dbo.Prices", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "Form_Id", "dbo.Forms");
            DropForeignKey("dbo.Fields", "FormId", "dbo.Forms");
            DropForeignKey("dbo.Subjects", "ChapterId", "dbo.Chapters");
            DropIndex("dbo.Values", new[] { "Order_OrderID" });
            DropIndex("dbo.Values", new[] { "FormId" });
            DropIndex("dbo.Values", new[] { "FieldId" });
            DropIndex("dbo.GalleryItems", new[] { "GalleryId" });
            DropIndex("dbo.Forms", new[] { "Product_ID" });
            DropIndex("dbo.Products", new[] { "ProductCategoryID" });
            DropIndex("dbo.Prices", new[] { "ProductID" });
            DropIndex("dbo.Products", new[] { "Form_Id" });
            DropIndex("dbo.Fields", new[] { "FormId" });
            DropIndex("dbo.Subjects", new[] { "ChapterId" });
            DropTable("dbo.Values");
            DropTable("dbo.Orders");
            DropTable("dbo.GalleryItems");
            DropTable("dbo.Galleries");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Prices");
            DropTable("dbo.Products");
            DropTable("dbo.Forms");
            DropTable("dbo.Fields");
            DropTable("dbo.Subjects");
            DropTable("dbo.Chapters");
        }
    }
}
