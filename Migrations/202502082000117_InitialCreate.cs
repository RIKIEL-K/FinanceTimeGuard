namespace prjFinanceTime.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alert",
                c => new
                    {
                        AlertID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        Message = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        Status = c.Int(),
                        Category = c.Int(),
                    })
                .PrimaryKey(t => t.AlertID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 50),
                        UserEmail = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        CreatedAt = c.DateTime(nullable: false),
                        Image_ImageID = c.Int(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Image", t => t.Image_ImageID)
                .Index(t => t.Image_ImageID);
            
            CreateTable(
                "dbo.Budget",
                c => new
                    {
                        BudgetID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        MonthlyLimit = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.BudgetID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Image",
                c => new
                    {
                        ImageID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Path = c.String(nullable: false),
                        UserID = c.Int(nullable: false),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.ImageID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.User_UserID)
                .Index(t => t.UserID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Report",
                c => new
                    {
                        ReportID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Title = c.String(),
                        GeneratedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReportID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Tache",
                c => new
                    {
                        TaskID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.TaskID)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Transaction",
                c => new
                    {
                        TransactionID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategorieID = c.Int(nullable: false),
                        date = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.TransactionID)
                .ForeignKey("dbo.Categorie", t => t.CategorieID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.CategorieID);
            
            CreateTable(
                "dbo.Categorie",
                c => new
                    {
                        CategorieID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Type = c.Int(),
                    })
                .PrimaryKey(t => t.CategorieID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alert", "UserID", "dbo.User");
            DropForeignKey("dbo.Transaction", "UserID", "dbo.User");
            DropForeignKey("dbo.Transaction", "CategorieID", "dbo.Categorie");
            DropForeignKey("dbo.Tache", "UserID", "dbo.User");
            DropForeignKey("dbo.Report", "UserID", "dbo.User");
            DropForeignKey("dbo.Image", "User_UserID", "dbo.User");
            DropForeignKey("dbo.User", "Image_ImageID", "dbo.Image");
            DropForeignKey("dbo.Image", "UserID", "dbo.User");
            DropForeignKey("dbo.Budget", "UserID", "dbo.User");
            DropIndex("dbo.Transaction", new[] { "CategorieID" });
            DropIndex("dbo.Transaction", new[] { "UserID" });
            DropIndex("dbo.Tache", new[] { "UserID" });
            DropIndex("dbo.Report", new[] { "UserID" });
            DropIndex("dbo.Image", new[] { "User_UserID" });
            DropIndex("dbo.Image", new[] { "UserID" });
            DropIndex("dbo.Budget", new[] { "UserID" });
            DropIndex("dbo.User", new[] { "Image_ImageID" });
            DropIndex("dbo.Alert", new[] { "UserID" });
            DropTable("dbo.Categorie");
            DropTable("dbo.Transaction");
            DropTable("dbo.Tache");
            DropTable("dbo.Report");
            DropTable("dbo.Image");
            DropTable("dbo.Budget");
            DropTable("dbo.User");
            DropTable("dbo.Alert");
        }
    }
}
