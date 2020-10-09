namespace Ekurhuleni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCircuit1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Residents", "size", c => c.String(nullable: false));
            AddColumn("dbo.Residents", "CircuitBreaker_ID", c => c.Int());
            CreateIndex("dbo.Residents", "CircuitBreaker_ID");
            AddForeignKey("dbo.Residents", "CircuitBreaker_ID", "dbo.CircuitBreakers", "ID");
            DropColumn("dbo.Residents", "circuit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Residents", "circuit", c => c.Int(nullable: false));
            DropForeignKey("dbo.Residents", "CircuitBreaker_ID", "dbo.CircuitBreakers");
            DropIndex("dbo.Residents", new[] { "CircuitBreaker_ID" });
            DropColumn("dbo.Residents", "CircuitBreaker_ID");
            DropColumn("dbo.Residents", "size");
        }
    }
}
