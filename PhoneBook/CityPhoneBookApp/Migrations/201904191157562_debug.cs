namespace CityPhoneBookApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class debug : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhoneNumbers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Number = c.String(),
                        OwnerName = c.String(),
                        CityId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhoneNumbers");
        }
    }
}
