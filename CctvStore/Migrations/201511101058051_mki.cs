namespace CctvStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mki : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catalogs",
                c => new
                    {
                        CatalogId = c.Int(nullable: false, identity: true),
                        CatalogName = c.String(),
                    })
                .PrimaryKey(t => t.CatalogId);
            
            AddColumn("dbo.Categories", "CatalogId", c => c.Int(nullable: false));
            CreateIndex("dbo.Categories", "CatalogId");
            AddForeignKey("dbo.Categories", "CatalogId", "dbo.Catalogs", "CatalogId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "CatalogId", "dbo.Catalogs");
            DropIndex("dbo.Categories", new[] { "CatalogId" });
            DropColumn("dbo.Categories", "CatalogId");
            DropTable("dbo.Catalogs");
        }
    }
}
