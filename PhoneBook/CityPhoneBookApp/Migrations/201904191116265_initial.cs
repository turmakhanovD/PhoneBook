namespace CityPhoneBookApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cities", "PhoneNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cities", "PhoneNumber", c => c.String());
        }
    }
}
