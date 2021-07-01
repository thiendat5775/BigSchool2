namespace BigSchool2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyBookCategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        CoverImage = c.String(),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Books", new[] { "CategoryID" });
            DropTable("dbo.Categories");
            DropTable("dbo.Books");
        }
    }
}
