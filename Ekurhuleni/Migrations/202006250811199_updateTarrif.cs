namespace Ekurhuleni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTarrif : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tarrifs",
                c => new
                    {
                        tarrifID = c.String(nullable: false, maxLength: 128),
                        Btarrif = c.String(),
                        ResTarrif = c.String(),
                    })
                .PrimaryKey(t => t.tarrifID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tarrifs");
        }
    }
}
