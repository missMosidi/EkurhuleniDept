namespace Ekurhuleni.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserProfile : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerProfiles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TypeOfCustomer = c.Int(nullable: false),
                        FName = c.String(nullable: false, maxLength: 50),
                        LName = c.String(nullable: false, maxLength: 50),
                        Title = c.Int(nullable: false),
                        IDNumber = c.String(nullable: false, maxLength: 13),
                        Gender = c.Int(nullable: false),
                        Cell_Phone = c.String(nullable: false, maxLength: 10),
                        Work_Phone = c.String(maxLength: 10),
                        Unit_Number = c.String(),
                        Block_Complex_Name = c.String(),
                        Street_Name = c.String(nullable: false),
                        Suburb = c.String(nullable: false),
                        Postal_Code = c.String(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerProfiles", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.CustomerProfiles", new[] { "UserId" });
            DropTable("dbo.CustomerProfiles");
        }
    }
}
