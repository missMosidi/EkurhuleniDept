namespace Ekurhuleni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LinkProfileAndApplication : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Residents", "CustomerProfile_Id", c => c.Guid());
            CreateIndex("dbo.Residents", "CustomerProfile_Id");
            AddForeignKey("dbo.Residents", "CustomerProfile_Id", "dbo.CustomerProfiles", "Id");
            DropColumn("dbo.Residents", "title");
            DropColumn("dbo.Residents", "surname");
            DropColumn("dbo.Residents", "IDno");
            DropColumn("dbo.Residents", "cellNumber");
            DropColumn("dbo.Residents", "Landline");
            DropColumn("dbo.Residents", "faxNumber");
            DropColumn("dbo.Residents", "Address");
            DropColumn("dbo.Residents", "line2");
            DropColumn("dbo.Residents", "Postalcode");
            DropColumn("dbo.Residents", "streetName");
            DropColumn("dbo.Residents", "suburb");
            DropColumn("dbo.Residents", "code");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Residents", "code", c => c.Int(nullable: false));
            AddColumn("dbo.Residents", "suburb", c => c.String(nullable: false));
            AddColumn("dbo.Residents", "streetName", c => c.String(nullable: false));
            AddColumn("dbo.Residents", "Postalcode", c => c.Int(nullable: false));
            AddColumn("dbo.Residents", "line2", c => c.String());
            AddColumn("dbo.Residents", "Address", c => c.String());
            AddColumn("dbo.Residents", "faxNumber", c => c.String());
            AddColumn("dbo.Residents", "Landline", c => c.String());
            AddColumn("dbo.Residents", "cellNumber", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.Residents", "IDno", c => c.String(nullable: false, maxLength: 13));
            AddColumn("dbo.Residents", "surname", c => c.String(nullable: false));
            AddColumn("dbo.Residents", "title", c => c.Int(nullable: false));
            DropForeignKey("dbo.Residents", "CustomerProfile_Id", "dbo.CustomerProfiles");
            DropIndex("dbo.Residents", new[] { "CustomerProfile_Id" });
            DropColumn("dbo.Residents", "CustomerProfile_Id");
        }
    }
}
