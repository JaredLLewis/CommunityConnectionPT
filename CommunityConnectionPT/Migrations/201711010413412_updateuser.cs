namespace CommunityConnectionPT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateuser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ApplicationModels", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.ApplicationModels", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.ApplicationModels", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.ApplicationModels", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.ApplicationModels", "Medicine", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ApplicationModels", "Medicine", c => c.String());
            AlterColumn("dbo.ApplicationModels", "PhoneNumber", c => c.String());
            AlterColumn("dbo.ApplicationModels", "Email", c => c.String());
            AlterColumn("dbo.ApplicationModels", "LastName", c => c.String());
            AlterColumn("dbo.ApplicationModels", "FirstName", c => c.String());
        }
    }
}
