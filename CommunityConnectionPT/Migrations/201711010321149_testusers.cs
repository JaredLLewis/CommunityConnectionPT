namespace CommunityConnectionPT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testusers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Age = c.Int(nullable: false),
                        YearlyIncome = c.Double(nullable: false),
                        Medicine = c.String(),
                        Insurance = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "Age");
            DropColumn("dbo.AspNetUsers", "Medicine");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Medicine", c => c.String());
            AddColumn("dbo.AspNetUsers", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            DropTable("dbo.ApplicationModels");
        }
    }
}
