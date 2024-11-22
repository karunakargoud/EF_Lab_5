namespace EF_Lab_5.Migrations
{
    using EF_Lab_5.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Diagnostics;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF_Lab_5.DAL.OnlineMarketContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EF_Lab_5.DAL.OnlineMarketContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            List<Product>products= new List<Product>();
            {
                new Product() { ProductId = 9001, ProductName = "Pomegranate - Regular", Quantity = "1Kg", Price = 223, },
            };
        }
    }
}
