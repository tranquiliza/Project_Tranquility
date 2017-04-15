namespace Project_Tranquility.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "ZIPCode", c => c.Int(nullable: false));
            AddColumn("dbo.Product", "Image", c => c.String());
            AddColumn("dbo.Product", "Manufacturer_Id", c => c.Int());
            AddColumn("dbo.Color", "Percentage", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Material", "Percentage", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            CreateIndex("dbo.Product", "Manufacturer_Id");
            AddForeignKey("dbo.Product", "Manufacturer_Id", "dbo.Manufacturer", "Id");
            DropColumn("dbo.Customer", "ZIP");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customer", "ZIP", c => c.Int(nullable: false));
            DropForeignKey("dbo.Product", "Manufacturer_Id", "dbo.Manufacturer");
            DropIndex("dbo.Product", new[] { "Manufacturer_Id" });
            DropColumn("dbo.Material", "Percentage");
            DropColumn("dbo.Color", "Percentage");
            DropColumn("dbo.Product", "Manufacturer_Id");
            DropColumn("dbo.Product", "Image");
            DropColumn("dbo.Customer", "ZIPCode");
        }
    }
}
