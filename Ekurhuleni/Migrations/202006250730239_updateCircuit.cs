namespace Ekurhuleni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCircuit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CircuitBreakers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        size = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CircuitBreakers");
        }
    }
}
