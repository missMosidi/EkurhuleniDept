namespace Ekurhuleni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResidentModelModified : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Residents", "vat", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Residents", "vat", c => c.Int(nullable: false));
        }
    }
}
