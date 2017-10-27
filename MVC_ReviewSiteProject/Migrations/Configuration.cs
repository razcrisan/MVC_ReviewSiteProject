namespace MVC_ReviewSiteProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC_ReviewSiteProject.Models.MVC_ReviewSiteProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MVC_ReviewSiteProject.Models.MVC_ReviewSiteProjectContext";
        }

        protected override void Seed(MVC_ReviewSiteProject.Models.MVC_ReviewSiteProjectContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
