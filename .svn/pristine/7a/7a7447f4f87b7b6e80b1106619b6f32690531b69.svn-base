namespace Ekurhuleni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResidentModelModified11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Residents", "AppStatus", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Residents", "AppStatus");
        }
    }
}
