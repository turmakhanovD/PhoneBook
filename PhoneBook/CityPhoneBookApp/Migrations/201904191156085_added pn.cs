namespace CityPhoneBookApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cities", "OwnerName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cities", "OwnerName", c => c.String());
        }
    }
}
