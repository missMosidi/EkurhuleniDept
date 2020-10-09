namespace Ekurhuleni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResidentValidate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Residents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserType = c.String(),
                        meterType = c.Int(nullable: false),
                        title = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        surname = c.String(nullable: false),
                        IdType = c.Int(nullable: false),
                        IDno = c.String(nullable: false, maxLength: 13),
                        cellNumber = c.String(nullable: false, maxLength: 10),
                        Landline = c.String(),
                        faxNumber = c.String(),
                        email = c.String(nullable: false),
                        Address = c.String(),
                        line2 = c.String(),
                        Postalcode = c.Int(nullable: false),
                        streetName = c.String(nullable: false),
                        suburb = c.String(nullable: false),
                        code = c.Int(nullable: false),
                        vat = c.Int(nullable: false),
                        voltage = c.Int(nullable: false),
                        circuit = c.Int(nullable: false),
                        resTarrif = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Residents");
        }
    }
}
