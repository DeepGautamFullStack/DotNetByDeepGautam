namespace ClientServiceWebAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ClientServiceWebAPI.Models.ClientServiceWebAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ClientServiceWebAPI.Models.ClientServiceWebAPIContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Clients.AddOrUpdate(x => x.Id,
       new Models.Client() { Id = 1, Name = "JP Moragn", Code="JPMC" },
       new Models.Client() { Id = 2, Name = "Morgan Stanley", Code = "MS" },
       new Models.Client() { Id = 3, Name = "Goldman", Code = "GS" }
       );

        }
    }
}
