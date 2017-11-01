namespace CommunityConnectionPT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removInsur : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "Insurance");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Insurance", c => c.Int(nullable: false));
        }
    }
}
