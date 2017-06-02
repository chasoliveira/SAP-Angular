using OAuthAspNetWebApiRest.Domain.Models;
using System.Data.Entity.Migrations;

namespace OAuthAspNetWebApiRest.Data
{
    public class AppDbContextInitialize
    {
        public AppDbContextInitialize(AppDbContext context)
        {
            context.Database.CreateIfNotExists();

            context.Products.AddOrUpdate(
              p => p.Name,
              new Product { Name = "Rice", Quantity = 5 },
              new Product { Name = "Bean", Quantity = 10 },
              new Product { Name = "Tomato", Quantity = 15 },
              new Product { Name = "Steack", Quantity = 20 }
            );
            context.SaveChanges();
        }
    }
}
