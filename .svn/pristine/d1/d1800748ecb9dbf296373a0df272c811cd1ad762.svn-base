namespace Ekurhuleni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class angaz : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Residents", "TypeOfApplication", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Residents", "TypeOfApplication", c => c.String(nullable: false));
        }
    }
}
