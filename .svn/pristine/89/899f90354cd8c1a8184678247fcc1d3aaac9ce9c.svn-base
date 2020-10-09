namespace Ekurhuleni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class residentmodelModifier : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Residents", "Name", c => c.String());
            AlterColumn("dbo.Residents", "email", c => c.String());
            AlterColumn("dbo.Residents", "vat", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Residents", "vat", c => c.String(nullable: false));
            AlterColumn("dbo.Residents", "email", c => c.String(nullable: false));
            AlterColumn("dbo.Residents", "Name", c => c.String(nullable: false));
        }
    }
}
