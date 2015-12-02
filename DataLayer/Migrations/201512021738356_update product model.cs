namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateproductmodel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Imege");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Imege", c => c.String(nullable: false));
        }
    }
}
