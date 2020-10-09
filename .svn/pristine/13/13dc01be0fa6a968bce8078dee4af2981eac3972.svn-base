namespace Ekurhuleni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplicationTypeModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeOfApplication = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.CustomerProfiles", "Email", c => c.String());
            AddColumn("dbo.Residents", "TypeOfApplication", c => c.String(nullable: false));
            AddColumn("dbo.Residents", "ApplicationType_ID", c => c.Int());
            CreateIndex("dbo.Residents", "ApplicationType_ID");
            AddForeignKey("dbo.Residents", "ApplicationType_ID", "dbo.ApplicationTypes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Residents", "ApplicationType_ID", "dbo.ApplicationTypes");
            DropIndex("dbo.Residents", new[] { "ApplicationType_ID" });
            DropColumn("dbo.Residents", "ApplicationType_ID");
            DropColumn("dbo.Residents", "TypeOfApplication");
            DropColumn("dbo.CustomerProfiles", "Email");
            DropTable("dbo.ApplicationTypes");
        }
    }
}
