namespace Project_Tranquility.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MaintainanceTask",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Status = c.Int(nullable: false),
                        Start = c.DateTime(),
                        Deadline = c.DateTime(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsPriority = c.Boolean(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        CompletionDate = c.DateTime(),
                        ApprovedDate = c.DateTime(),
                        ApprovedComplete = c.Boolean(nullable: false),
                        Department_Id = c.Int(),
                        Staff_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Department", t => t.Department_Id)
                .ForeignKey("dbo.Staff", t => t.Staff_Id)
                .Index(t => t.Department_Id)
                .Index(t => t.Staff_Id);
            
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Staff",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Department_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Department", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MaintainanceTask", "Staff_Id", "dbo.Staff");
            DropForeignKey("dbo.Staff", "Department_Id", "dbo.Department");
            DropForeignKey("dbo.MaintainanceTask", "Department_Id", "dbo.Department");
            DropIndex("dbo.Staff", new[] { "Department_Id" });
            DropIndex("dbo.MaintainanceTask", new[] { "Staff_Id" });
            DropIndex("dbo.MaintainanceTask", new[] { "Department_Id" });
            DropTable("dbo.Staff");
            DropTable("dbo.Department");
            DropTable("dbo.MaintainanceTask");
        }
    }
}
