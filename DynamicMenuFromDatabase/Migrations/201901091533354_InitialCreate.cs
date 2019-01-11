namespace DynamicMenuFromDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuMsts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MenuText = c.String(),
                        PerentID = c.Int(),
                        MenuUrl = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MenuMsts");
        }
    }
}
