namespace BigSchool2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (4,'GIÁO ÁN')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (5,'GIÁO TRÌNH')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (6,'GIÁO VỤ')");
        }
        
        public override void Down()
        {
        }
    }
}
