namespace ReviewsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "CategoryID", "dbo.Categories");
            DropPrimaryKey("dbo.Categories");
            AddColumn("dbo.Categories", "CategoryID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Categories", "CategoryID");
            AddForeignKey("dbo.Reviews", "CategoryID", "dbo.Categories", "CategoryID", cascadeDelete: true);
            DropColumn("dbo.Categories", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "ID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Reviews", "CategoryID", "dbo.Categories");
            DropPrimaryKey("dbo.Categories");
            DropColumn("dbo.Categories", "CategoryID");
            AddPrimaryKey("dbo.Categories", "ID");
            AddForeignKey("dbo.Reviews", "CategoryID", "dbo.Categories", "ID", cascadeDelete: true);
        }
    }
}
