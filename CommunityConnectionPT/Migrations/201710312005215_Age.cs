namespace CommunityConnectionPT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Age : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Medicine", c => c.String());
            AddColumn("dbo.AspNetUsers", "Insurance", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Insurance");
            DropColumn("dbo.AspNetUsers", "Medicine");
            DropColumn("dbo.AspNetUsers", "Age");
        }
    }
}
