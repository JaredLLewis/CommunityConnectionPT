namespace CommunityConnectionPT.Migrations
{
    using CommunityConnectionPT.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CommunityConnectionPT.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CommunityConnectionPT.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            //context.Roles.AddOrUpdate(r => r.Name,
            //new IdentityRole { Name = "Admin" },
            //new IdentityRole { Name = "Member" }
            //);
            //UserManager.AddToRole("UserId", "UserRole");

            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            string[] roleNames = { "Admin", "Member" };
            IdentityResult roleResult;
            foreach(var roleName in roleNames)
            {
                if (!RoleManager.RoleExists(roleName))
                {
                    roleResult = RoleManager.Create(new IdentityRole(roleName));
                }
            }

            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            UserManager.AddToRole("064b40d1-662d-416f-b116-eee0d7dd1e83", "Admin");
           // UserManager.AddToRole("50769af5-49b5-47f5-bc98-c9a2e282d711", "Admin");



        }
    }
}
