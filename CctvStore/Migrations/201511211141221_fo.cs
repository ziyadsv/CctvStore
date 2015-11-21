namespace CctvStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TroubleShootings",
                c => new
                    {
                        TroubleShootingId = c.Int(nullable: false, identity: true),
                        ErrorTitle = c.String(maxLength: 50),
                        ErrorDescription = c.String(),
                        ErrorUrl = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TroubleShootingId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TroubleShootings");
        }
    }
}
