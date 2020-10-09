namespace Ekurhuleni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class angaz1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Residents", "size", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Residents", "size", c => c.String(nullable: false));
        }
    }
}
