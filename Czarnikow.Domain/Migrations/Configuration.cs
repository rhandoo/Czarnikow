namespace Czarnikow.Domain.Migrations
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Czarnikow.Domain.TradeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Czarnikow.Domain.TradeDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Products.AddOrUpdate(
     new Product { ProductId = 1, Description = "Sugar" },
     new Product { ProductId = 2, Description = "Ethanol" });

            context.Clients.AddOrUpdate(
             new Client { ClientId = 1, Name = "Client-A" },
              new Client { ClientId = 2, Name = "Client-B" });

            context.Trades.AddOrUpdate(
          new Trade { TradeId = 1, ProductId = 1, ClientId = 1, CreatedBy = "John", CreatedDate = DateTime.Now, Date = DateTime.Now.AddDays(-1), Amount = 123456.89, Qty = 12 },
          new Trade { TradeId = 2, ProductId = 2, ClientId = 2, CreatedBy = "Smith", CreatedDate = DateTime.Now, Date = DateTime.Now.AddDays(-1), Amount = 834783.89, Qty = 12 },
          new Trade { TradeId = 3, ProductId = 1, ClientId = 2, CreatedBy = "Rob", CreatedDate = DateTime.Now, Date = DateTime.Now.AddDays(-1), Amount = 374643.89, Qty = 14 });

        }
    }
}
