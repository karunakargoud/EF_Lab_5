using EF_Lab_5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Lab_5.DAL
{
    internal class OnlineMarketContext:DbContext
    {
        public OnlineMarketContext() : base()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);     
        }
        public DbSet<Category> categories { get; set; }

        public DbSet<Brand> brands { get; set; }
        public DbSet<ProductType>productTypes { get; set; }

        public DbSet<Product> products { get; set; }
    }
}
