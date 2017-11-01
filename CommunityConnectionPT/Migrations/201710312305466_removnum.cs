namespace CommunityConnectionPT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removnum : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "Number");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Number", c => c.String());
        }
    }
}
