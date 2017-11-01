namespace CommunityConnectionPT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedusers : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ApplicationModels", "FirstName", c => c.String());
            AlterColumn("dbo.ApplicationModels", "LastName", c => c.String());
            AlterColumn("dbo.ApplicationModels", "Email", c => c.String());
            AlterColumn("dbo.ApplicationModels", "PhoneNumber", c => c.String());
            AlterColumn("dbo.ApplicationModels", "Medicine", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ApplicationModels", "Medicine", c => c.String(nullable: false));
            AlterColumn("dbo.ApplicationModels", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.ApplicationModels", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.ApplicationModels", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.ApplicationModels", "FirstName", c => c.String(nullable: false));
        }
    }
}
