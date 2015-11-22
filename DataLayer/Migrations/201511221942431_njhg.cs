namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class njhg : DbMigration
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
                        FormId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        FaTitle = c.String(),
                        EnTitle = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FormId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductCategoryId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Imege = c.String(nullable: false),
                        Describtion = c.String(nullable: false),
                        Form_FormId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Forms", t => t.Form_FormId)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCategoryId, cascadeDelete: true)
                .Index(t => t.Form_FormId)
                .Index(t => t.ProductCategoryId);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        PriceId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Neme = c.String(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PriceId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        ProductCategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Imege = c.String(nullable: false),
                        Describtion = c.String(nullable: false),
                        SuperCategory = c.Int(),
                    })
                .PrimaryKey(t => t.ProductCategoryId);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        GalleryId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Describtion = c.String(),
                    })
                .PrimaryKey(t => t.GalleryId);
            
            CreateTable(
                "dbo.GalleryItems",
                c => new
                    {
                        GalleryItemId = c.Int(nullable: false, identity: true),
                        GalleryId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Describtion = c.String(),
                        Url = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GalleryItemId)
                .ForeignKey("dbo.Galleries", t => t.GalleryId, cascadeDelete: true)
                .Index(t => t.GalleryId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
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
                .PrimaryKey(t => t.OrderId);
            
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
                        Order_OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fields", t => t.FieldId, cascadeDelete: true)
                .ForeignKey("dbo.Forms", t => t.FormId)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId)
                .Index(t => t.FieldId)
                .Index(t => t.FormId)
                .Index(t => t.Order_OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Values", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.Values", "FormId", "dbo.Forms");
            DropForeignKey("dbo.Values", "FieldId", "dbo.Fields");
            DropForeignKey("dbo.GalleryItems", "GalleryId", "dbo.Galleries");
            DropForeignKey("dbo.Forms", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "ProductCategoryId", "dbo.ProductCategories");
            DropForeignKey("dbo.Prices", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "Form_FormId", "dbo.Forms");
            DropForeignKey("dbo.Fields", "FormId", "dbo.Forms");
            DropForeignKey("dbo.Subjects", "ChapterId", "dbo.Chapters");
            DropIndex("dbo.Values", new[] { "Order_OrderId" });
            DropIndex("dbo.Values", new[] { "FormId" });
            DropIndex("dbo.Values", new[] { "FieldId" });
            DropIndex("dbo.GalleryItems", new[] { "GalleryId" });
            DropIndex("dbo.Forms", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "ProductCategoryId" });
            DropIndex("dbo.Prices", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "Form_FormId" });
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
