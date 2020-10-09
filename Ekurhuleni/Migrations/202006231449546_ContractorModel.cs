namespace Ekurhuleni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContractorModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contractors",
                c => new
                    {
                        contractorID = c.Int(nullable: false, identity: true),
                        title = c.Int(nullable: false),
                        initials = c.String(nullable: false),
                        name = c.String(nullable: false),
                        surname = c.String(nullable: false),
                        businessName = c.String(nullable: false),
                        contactPerson = c.String(nullable: false),
                        officeNumber = c.String(nullable: false),
                        cellNumber = c.String(nullable: false),
                        IDNumberType = c.Int(nullable: false),
                        IDNumber = c.String(nullable: false),
                        faxNumber = c.String(),
                        email = c.String(nullable: false),
                        RegNo = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.contractorID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contractors");
        }
    }
}
