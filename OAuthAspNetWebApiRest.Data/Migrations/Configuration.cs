namespace OAuthAspNetWebApiRest.Data.Migrations
{
    using Domain.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppDbContext context)
        {
            context.Database.CreateIfNotExists();
         
            context.Products.AddOrUpdate(
              p => p.Name,
              new Product { Name = "Rice", Quantity = 5 },
              new Product { Name = "Bean" , Quantity = 10},
              new Product { Name = "Tomato", Quantity = 15 }
            );

        }
    }
}
